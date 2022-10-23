using SimplePM.Library.Assets.Processors;

namespace SimplePM.Library.Factories
{
    public static class EntriesProcessorFactory
    {
        public static IEntriesProcessor Create()
        {
            return new EntriesProcessor(EntriesDataAccessFactory.Create(),
                SyncOperationsDataAccessFactory.Create(), 
                HttpHandlerFactory.Create());
        }
    }
}
