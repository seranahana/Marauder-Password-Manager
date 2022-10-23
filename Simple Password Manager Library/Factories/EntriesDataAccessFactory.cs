using SimplePM.Library.Assets.DataAccess;

namespace SimplePM.Library.Factories
{
    public static class EntriesDataAccessFactory
    {
        public static IEntriesDataAccess Create()
        {
            return new EntriesDataAccess();
        }
    }
}
