using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimplePM.Library.Networking
{
    public class RetryHandler : DelegatingHandler
    {
        protected const int Retries = 5;
        public RetryHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }

        protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (int i = 1; i <= Retries; i++)
            {
                try
                {
                    response = base.Send(request, cancellationToken);
                }
                catch (InvalidOperationException)
                {
                    continue;
                }
                catch (TaskCanceledException)
                {
                    continue;
                }
                catch (HttpRequestException)
                {
                    continue;
                }
                if (response is not null)
                {
                    break;
                }
            }
            if (response is null)
            {
                response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
                var jsonData = JsonConvert.SerializeObject("Server unreachable");
                var buffer = Encoding.UTF8.GetBytes(jsonData);
                response.Content = new ByteArrayContent(buffer);
            }
            return response;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (int i = 1; i <= Retries; i++)
            {
                try
                {
                    response = await base.SendAsync(request, cancellationToken);
                }
                catch (InvalidOperationException)
                {
                    continue;
                }
                catch (TaskCanceledException)
                {
                    continue;
                }
                catch (HttpRequestException)
                {
                    continue;
                }
                if (response is not null)
                {
                    break;
                }
            }
            if (response is null)
            {
                response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
                var jsonData = JsonConvert.SerializeObject("Server unreachable");
                var buffer = Encoding.UTF8.GetBytes(jsonData);
                response.Content = new ByteArrayContent(buffer);
            }
            return response;
        }
    }
}
