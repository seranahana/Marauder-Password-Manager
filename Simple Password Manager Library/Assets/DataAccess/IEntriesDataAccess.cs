using SimplePM.Library.Models;
using System.Collections.Generic;

namespace SimplePM.Library.Assets.DataAccess
{
    public interface IEntriesDataAccess
    {
        void Create(Entry entry);
        bool Delete(string id);
        Entry Retrieve(string id);
        IEnumerable<Entry> RetrieveAll();
        void Save();
        bool Update(string id, Entry entry);
    }
}