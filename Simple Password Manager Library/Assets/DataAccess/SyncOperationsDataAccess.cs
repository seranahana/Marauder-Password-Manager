using SimplePM.Library.Serialization;
using SimplePM.Library.Models;
using System.Collections.Generic;
using System.IO;

namespace SimplePM.Library.Assets.DataAccess
{
    public class SyncOperationsDataAccess : ISyncOperationsDataAccess
    {
        private const string fileName = "spm100-so.bin";
        private static List<(string Id, int Code)> syncOperationsCache;

        public SyncOperationsDataAccess()
        {
            try
            {
                syncOperationsCache = JsonSerializer.ReadFromJsonFile<List<(string, int)>>(fileName) ?? new List<(string, int)>();
            }
            catch (FileNotFoundException)
            {
                syncOperationsCache = new List<(string, int)>();
            }
        }

        public void Create(string id, EntrySyncOperation syncOperation)
        {
            syncOperationsCache.Add((id, (int)syncOperation));
        }

        public IEnumerable<Entry> RetrieveAll()
        {
            List<Entry> result = new();
            foreach (var syncOperation in syncOperationsCache)
            {
                Entry entry = new()
                {
                    ID = syncOperation.Id,
                    SyncOperation = (EntrySyncOperation)syncOperation.Code
                };
                result.Add(entry);
            }
            return result;
        }

        public void Clear()
        {
            syncOperationsCache.Clear();
            using FileStream fileStream = File.Open(fileName, FileMode.Open);
            fileStream.SetLength(0);
        }

        public void Save()
        {
            JsonSerializer.WriteToJsonFile(fileName, syncOperationsCache);
        }
    }
}
