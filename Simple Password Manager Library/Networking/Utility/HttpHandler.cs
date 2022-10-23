using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SimplePM.Library.Networking
{
    public class HttpHandler : IHttpHandler
    {
        private static HttpClient client;
        private readonly Dictionary<ServiceType, string> servicesTypes;


        public HttpHandler()
        {
            if (client is null)
            {
                client = new(new RetryHandler(new HttpClientHandler()));
            }
            servicesTypes = new Dictionary<ServiceType, string>
            {
                {ServiceType.Entries, ServicesUri.Entries},
                {ServiceType.MasterPassword, ServicesUri.MasterPassword },
                {ServiceType.Accounts, ServicesUri.Accounts },
                {ServiceType.RSA, ServicesUri.Rsa },
                {ServiceType.Test, ServicesUri.Test }
            };
        }

        public string CreateAndSend<T>(HttpMethod method,
            ServiceType serviceType,
            string additionToUri = null,
            T content = null,
            Dictionary<string, string> stringHeaders = null,
            Dictionary<string, string[]> arrayHeaders = null) where T : class
        {
            if (!servicesTypes.TryGetValue(serviceType, out string uri))
            {
                throw new ArgumentException("", nameof(serviceType));
            }
            if (additionToUri != null)
            {
                uri = Path.Combine(uri, additionToUri);
            }
            var request = new HttpRequestMessage(method, uri);
            if (content != null)
            {
                var jsonData = JsonConvert.SerializeObject(content);
                request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            }
            if (stringHeaders != null)
            {
                foreach (var header in stringHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            if (arrayHeaders != null)
            {
                foreach (var header in arrayHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            HttpResponseMessage response = client.Send(request);
            using HttpContent incomingContent = response.Content;
            Stream incomingJsonStream = incomingContent.ReadAsStream();
            using StreamReader reader = new(incomingJsonStream);
            string incomingJson = reader.ReadToEnd();
            if (response.IsSuccessStatusCode)
            {
                return incomingJson;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase, new Exception(incomingJson), response.StatusCode);
            }
        }

        public async Task<string> CreateAndSendAsync<T>(HttpMethod method,
            ServiceType serviceType,
            string additionToUri = null,
            T content = null,
            Dictionary<string, string> stringHeaders = null,
            Dictionary<string, string[]> arrayHeaders = null) where T : class
        {
            if (!servicesTypes.TryGetValue(serviceType, out string uri))
            {
                throw new ArgumentException("", nameof(serviceType));
            }
            if (additionToUri != null)
            {
                uri = Path.Combine(uri, additionToUri);
            }
            var request = new HttpRequestMessage(method, uri);
            if (content != null)
            {
                var jsonData = JsonConvert.SerializeObject(content);
                request.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            }
            if (stringHeaders != null)
            {
                foreach (var header in stringHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            if (arrayHeaders != null)
            {
                foreach (var header in arrayHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            HttpResponseMessage response = await client.SendAsync(request);
            using HttpContent incomingContent = response.Content;
            string incomingJson = await incomingContent.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return incomingJson;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase, new Exception(incomingJson), response.StatusCode);
            }
        }
    }
}
