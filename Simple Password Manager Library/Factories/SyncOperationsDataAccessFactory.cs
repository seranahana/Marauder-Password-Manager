using SimplePM.Library.Assets.DataAccess;

namespace SimplePM.Library.Factories
{
    internal static class SyncOperationsDataAccessFactory
    {
        internal static ISyncOperationsDataAccess Create()
        {
            return new SyncOperationsDataAccess();
        }
    }
}
