using SimplePM.Library.Networking;

namespace SimplePM.Library.Factories
{
    public static class ConnectivityClientFactory
    {
        public static IConnectivityClient Create()
        {
            return new ConnectivityClient(HttpHandlerFactory.Create());
        }
    }
}
