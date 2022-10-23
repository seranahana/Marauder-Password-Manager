using SimplePM.Library.Models;
using SimplePM.Library.Serialization;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;

namespace SimplePM.Library.Assets.DataAccess
{

    public class EntriesDataAccess : IEntriesDataAccess
    {
        private const string fileName = "spm100-e.dat";
        private static ConcurrentDictionary<string, Entry> entriesCache;

        public EntriesDataAccess()
        {
            try
            {
                entriesCache = JsonSerializer.ReadFromJsonFile<ConcurrentDictionary<string, Entry>>(fileName);
            }
            catch (FileNotFoundException)
            {
                entriesCache = new ConcurrentDictionary<string, Entry>();
            }
        }

        public void Create(Entry entry)
        {
            entriesCache.AddOrUpdate(entry.ID, entry, UpdateCache);
        }

        public Entry Retrieve(string id)
        {
            if (entriesCache.TryGetValue(id, out Entry entry))
            {
                Entry newEntry = new()
                {
                    SyncOperation = entry.SyncOperation,
                    ID = entry.ID,
                    Version = entry.Version,
                    Name = entry.Name,
                    URL = entry.URL,
                    Login = entry.Login,
                    Password = entry.Password
                };
                return newEntry;
            }
            return null;
        }

        public IEnumerable<Entry> RetrieveAll()
        {
            return entriesCache.Values;
        }

        private Entry UpdateCache(string id, Entry entry)
        {
            Entry old;
            if (entriesCache.TryGetValue(id, out old))
            {
                entry.Version = old.Version++;
                if (entriesCache.TryUpdate(id, entry, old))
                {
                    return entry;
                }
            }
            return null;
        }

        public bool Update(string id, Entry entry)
        {
            if (UpdateCache(id, entry) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            entriesCache.TryRemove(id, out Entry entry);
            if (entry != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Save()
        {
            JsonSerializer.WriteToJsonFile(fileName, entriesCache);
        }
    }
}
