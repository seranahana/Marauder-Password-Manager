using SimplePM.Library.Networking;

namespace SimplePM.Library.Factories
{
    public static class AccountClientFactory
    {
        public static IAccountClient Create()
        {
            return new AccountClient(HttpHandlerFactory.Create());
        }
    }
}
