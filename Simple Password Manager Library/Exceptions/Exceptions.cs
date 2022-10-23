using System;

namespace SimplePM.Library
{
    public class NotConfiguredException : Exception
    {

        public NotConfiguredException(string type) : base($"Instanse of {type} was created, but it's configuration failed for some reason. " +
            "If you are going to use this instanse you should check if the IsConfigured flag is set before use, and also you may call Configure method manually")
        {
        }

        public NotConfiguredException(string type, Exception inner) : base($"Instanse of {type} was created, but it's configuration failed for some reason. " +
            "If you are going to use this instanse you should check if the IsConfigured flag is set before use, and also you may call Configure method manually", inner)
        {
        }

        public static void ThrowIfNotConfigured(bool isConfigured, string type, string configurationFailureMessage)
        {
            if (!isConfigured)
            {
                throw new NotConfiguredException(type, new Exception(configurationFailureMessage));
            }
        }
    }

    public class IncompleteSyncException : Exception
    {
        public IncompleteSyncException() : base("Synchronization was completed, but some of entries provided by client side were not found on server side." +
            "This may occur when these entries were deleted using another client while this was offline.")
        {
        }

        public IncompleteSyncException(string message) : base(message)
        {
        }

        public IncompleteSyncException(Exception inner) : base("Synchronization was completed, but some of entries provided by client side were not found on server side." +
            "This may occur when these entries were deleted using another client while this was offline.", inner)
        {
        }

        public IncompleteSyncException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
