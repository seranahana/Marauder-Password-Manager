namespace SimplePM.Library
{
    internal static class ServicesUri
    {
        private const string baseAddress = "localhost:5001";

        internal const string Entries = $"https://{baseAddress}/api/v1/entries/sync/";
        internal const string Accounts = $"https://{baseAddress}/api/v1/accounts";
        internal const string MasterPassword = $"https://{baseAddress}/api/v1/accounts/master";
        internal const string Rsa = $"https://{baseAddress}/api/v1/rsa/";
        internal const string Test = $"https://{baseAddress}/api/v1/test/";
    }
}
