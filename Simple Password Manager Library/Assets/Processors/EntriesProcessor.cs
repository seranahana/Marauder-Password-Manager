using Newtonsoft.Json;
using SimplePM.Library.Assets.DataAccess;
using SimplePM.Library.Cryptography;
using SimplePM.Library.Models;
using SimplePM.Library.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimplePM.Library.Assets.Processors
{
    public class EntriesProcessor : IEntriesProcessor
    {
        private readonly IEntriesDataAccess _entriesDataAccess;
        private readonly ISyncOperationsDataAccess _syncOperationsDataAccess;
        private readonly IHttpHandler _httpHandler;

        public EntriesProcessor(IEntriesDataAccess entriesDataAccess, ISyncOperationsDataAccess syncOperationsDataAccess, IHttpHandler httpHandler)
        {
            _entriesDataAccess = entriesDataAccess;
            _syncOperationsDataAccess = syncOperationsDataAccess;
            _httpHandler = httpHandler;
        }

        public void Create(string name, string url, string login, string password, string masterpassword)
        {
            string encryptedLogin = CryptographyProvider.AES.Encrypt(login, masterpassword);
            string encryptedPassword = CryptographyProvider.AES.Encrypt(password, masterpassword);
            string id = Guid.NewGuid().ToString("N");
            var entry = new Entry
            {
                ID = id,
                Version = 1,
                Name = name,
                URL = url,
                Login = encryptedLogin,
                Password = encryptedPassword
            };
            _entriesDataAccess.Create(entry);
            _syncOperationsDataAccess.Create(id, EntrySyncOperation.Create);
        }

        public void Delete(string id)
        {
            if (!_entriesDataAccess.Delete(id))
            {
                throw new ArgumentException($"Entry with id {id} not found");
            }
            _syncOperationsDataAccess.Create(id, EntrySyncOperation.Delete);
        }

        public void Update(string id, string name, string url, string login, string password, string masterpassword)
        {
            string encryptedLogin = CryptographyProvider.AES.Encrypt(login, masterpassword);
            string encryptedPassword = CryptographyProvider.AES.Encrypt(password, masterpassword);
            var updatedEntry = new Entry
            {
                ID = id,
                Name = name,
                URL = url,
                Login = encryptedLogin,
                Password = encryptedPassword
            };
            if (!_entriesDataAccess.Update(id, updatedEntry))
            {
                throw new ArgumentException($"Entry with id {id} not found");
            }
            _syncOperationsDataAccess.Create(id, EntrySyncOperation.Update);
        }

        public Entry Retrieve(string id, string masterpassword)
        {
            Entry entry = _entriesDataAccess.Retrieve(id);
            entry.Login = CryptographyProvider.AES.Decrypt(entry.Login, masterpassword);
            entry.Password = CryptographyProvider.AES.Decrypt(entry.Password, masterpassword);
            return entry;
        }

        public IEnumerable<Entry> RetrieveAll()
        {
            IEnumerable<Entry> entries = _entriesDataAccess.RetrieveAll();
            return entries;
        }

        public void SaveChanges()
        {
            _entriesDataAccess.Save();
            _syncOperationsDataAccess.Save();
        }

        public void ReencryptAll(string oldMasterPassword, string newMasterPassword)
        {
            List<Entry> entries = _entriesDataAccess.RetrieveAll().ToList();
            foreach (Entry entry in entries)
            {
                string decryptedLogin = CryptographyProvider.AES.Decrypt(entry.Login, oldMasterPassword);
                string decryptedPassword = CryptographyProvider.AES.Decrypt(entry.Password, oldMasterPassword);
                entry.Login = CryptographyProvider.AES.Encrypt(decryptedLogin, newMasterPassword);
                entry.Password = CryptographyProvider.AES.Encrypt(decryptedPassword, newMasterPassword);
                _entriesDataAccess.Update(entry.ID, entry);
                _syncOperationsDataAccess.Create(entry.ID, EntrySyncOperation.Update);
            }
        }

        public async Task SynchronizeAsync(string accountId)
        {
            if (string.IsNullOrWhiteSpace(accountId))
            {
                throw new ArgumentNullException(nameof(accountId));
            }

            // Step 1: Get checklist (only entries ID's and versions)
            Dictionary<string, string> headers = new()
            {
                { "accountID", accountId }
            };
            string checkListResponse = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Get, ServiceType.Entries, "checklist", null, headers);
            List<Entry> checklist = JsonConvert.DeserializeObject<List<Entry>>(checkListResponse);
            List<Entry> syncOperationsList = RetrieveSyncOperationsList().ToList();
            Dictionary<string, EntrySyncOperation> updatelist = CheckForUpdates(checklist, syncOperationsList);
            string[] idList = updatelist.Keys.ToArray();

            // Step 2: Get bodies of all entries that should be added or updated 
            Dictionary<string, string[]> arrayHeaders = new()
            {
                { "idList", idList }
            };
            string updateListResponse = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Get, ServiceType.Entries, "updatelist", null, headers, arrayHeaders);
            List<Entry> updates = JsonConvert.DeserializeObject<List<Entry>>(updateListResponse);
            AddOrUpdateToStorage(updatelist, updates);

            // Step 3: Send all entries that should be added/updated/deleted on server side
            try
            {
                await _httpHandler.CreateAndSendAsync(HttpMethod.Post, ServiceType.Entries, null, syncOperationsList, headers);
                _syncOperationsDataAccess.Clear();
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.UnprocessableEntity:
                        throw new IncompleteSyncException();
                    default:
                        throw;
                }
            }
        }

        public void Synchronize(string accountId)
        {
            if (string.IsNullOrWhiteSpace(accountId))
            {
                throw new ArgumentNullException(nameof(accountId));
            }

            // Step 1: Get checklist (only entries ID's and versions)
            Dictionary<string, string> headers = new()
            {
                { "accountID", accountId }
            };
            string checkListResponse = _httpHandler.CreateAndSend<string>(HttpMethod.Get, ServiceType.Entries, "checklist", null, headers);
            List<Entry> checklist = JsonConvert.DeserializeObject<List<Entry>>(checkListResponse);
            List<Entry> syncOperationsList = RetrieveSyncOperationsList().ToList();
            Dictionary<string, EntrySyncOperation> updatelist = CheckForUpdates(checklist, syncOperationsList);
            string[] idList = updatelist.Keys.ToArray();

            // Step 2: Get bodies of all entries that should be added or updated 
            Dictionary<string, string[]> arrayHeaders = new()
            {
                { "idList", idList }
            };
            string updateListResponse = _httpHandler.CreateAndSend<string>(HttpMethod.Get, ServiceType.Entries, "updatelist", null, headers, arrayHeaders);
            List<Entry> updates = JsonConvert.DeserializeObject<List<Entry>>(updateListResponse);
            AddOrUpdateToStorage(updatelist, updates);

            // Step 3: Send all entries that should be added/updated/deleted on server side
            try
            {
                _httpHandler.CreateAndSend(HttpMethod.Post, ServiceType.Entries, null, syncOperationsList, headers);
                _syncOperationsDataAccess.Clear();
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.UnprocessableEntity:
                        throw new IncompleteSyncException();
                    default:
                        throw;
                }
            }
        }

        // Private Methods
        private void AddOrUpdateToStorage(Dictionary<string, EntrySyncOperation> updatelist, List<Entry> updateValues)
        {
            foreach (var entry in updatelist)
            {
                Entry entryToModify = updateValues.FirstOrDefault(e => e.ID == entry.Key);
                if (entryToModify != null)
                {
                    switch (entry.Value)
                    {
                        case EntrySyncOperation.Create:
                            _entriesDataAccess.Create(entryToModify);
                            break;
                        case EntrySyncOperation.Update:
                            _entriesDataAccess.Update(entry.Key, entryToModify);
                            break;
                    }
                }
            }
        }

        private Dictionary<string, EntrySyncOperation> CheckForUpdates(List<Entry> serverBase, List<Entry> syncOperationsList)
        {
            Dictionary<string, EntrySyncOperation> updatelist = new();
            foreach (var entry in serverBase)
            {
                Entry searchResult = _entriesDataAccess.Retrieve(entry.ID);
                if (searchResult != null)
                {
                    if (entry.Version > searchResult.Version)
                    {
                        updatelist.Add(entry.ID, EntrySyncOperation.Update);
                    }
                }
                else
                {
                    updatelist.Add(entry.ID, EntrySyncOperation.Create);
                }
            }
            List<Entry> localBase = _entriesDataAccess.RetrieveAll().ToList();
            foreach (var entry in localBase)
            {
                if ((!serverBase.Exists(e => e.ID == entry.ID)) && (!syncOperationsList.Exists(e => e.ID == entry.ID)))
                {
                    _entriesDataAccess.Delete(entry.ID);
                }
            }
            return updatelist;
        }

        private IEnumerable<Entry> RetrieveSyncOperationsList()
        {
            IEnumerable<Entry> syncOperationsList = _syncOperationsDataAccess.RetrieveAll();
            foreach (Entry entry in syncOperationsList)
            {
                if (entry.SyncOperation != EntrySyncOperation.Delete)
                {
                    Entry entryData = _entriesDataAccess.Retrieve(entry.ID);
                    if (entryData is not null)
                    {
                        entry.Name = entryData.Name;
                        entry.URL = entryData.URL;
                        entry.Login = entryData.Login;
                        entry.Password = entryData.Password;
                        entry.Version = entryData.Version;
                    }
                }
            }
            return syncOperationsList;
        }
    }
}