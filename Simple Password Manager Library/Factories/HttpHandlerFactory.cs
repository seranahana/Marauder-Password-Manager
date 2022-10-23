using SimplePM.Library.Networking;

namespace SimplePM.Library.Factories
{
    internal static class HttpHandlerFactory
    {
        internal static IHttpHandler Create()
        {
            return new HttpHandler();
        }
    }
}
