using SimplePM.Library.Models;
using System.Collections.Generic;

namespace SimplePM.Library.Assets.DataAccess
{
    public interface ISyncOperationsDataAccess
    {
        void Clear();
        void Create(string id, EntrySyncOperation syncOperation);
        IEnumerable<Entry> RetrieveAll();
        void Save();
    }
}