using System;
using System.Net.Http;
using System.Net.NetworkInformation;

namespace SimplePM.Library.Networking
{
    public class ConnectivityClient : IConnectivityClient
    {
        private readonly IHttpHandler _httpHandler;

        public ConnectivityClient(IHttpHandler httpHandler)
        {
            _httpHandler = httpHandler;
        }

        public bool IsServerReachable()
        {
            if (!IsAnyNetworkAvailable())
            {
                return false;
            }
            try
            {
                _httpHandler.CreateAndSend<string>(HttpMethod.Get, ServiceType.Test);
            }
            catch (HttpRequestException)
            {
                return false;
            }
            return true;
        }

        // Private methods
        private bool IsAnyNetworkAvailable(long minimumSpeed = 10000000)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                return false;
            }
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus != OperationalStatus.Up ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.Loopback ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.Tunnel)
                {
                    continue;
                }
                if (ni.Speed < minimumSpeed)
                {
                    continue;
                }
                if (ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0 ||
                ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    continue;
                }
                if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                return true;
            }
            return false;
        }
    }
}
