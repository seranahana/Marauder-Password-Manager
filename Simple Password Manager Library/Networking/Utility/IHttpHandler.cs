using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimplePM.Library.Networking
{
    public interface IHttpHandler
    {
        string CreateAndSend<T>(HttpMethod method,
            ServiceType serviceType,
            string additionToUri = null,
            T content = null,
            Dictionary<string, string> stringHeaders = null,
            Dictionary<string, string[]> arrayHeaders = null) where T : class;

        /// <summary>
        /// Creates HTTP Request with parameters and sends it to corresponding service.
        /// </summary>
        /// 
        /// <typeparam name="T">Any object that is "class". If content is null, T can be any nullable class.</typeparam>
        /// 
        /// <param name="method">HTTP method of request.</param>
        /// <param name="serviceType">Type of API service which would proceed this request.</param>
        /// <param name="additionToUri">Any addition to URI.</param>
        /// <param name="content">Any content that should be passed with request.</param>
        /// <param name="stringHeaders">Additional headers of request as dictionary where key is header name and value is header value.</param>
        /// 
        /// <returns>Returns Tuple<bool, string> where item1 represents successfulness of response and item2 is response as json string</bool></returns>
        /// 
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity
        ///     -or- DNS failure, server certificate validation or timeout.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        Task<string> CreateAndSendAsync<T>(HttpMethod method,
            ServiceType serviceType,
            string additionToUri = null,
            T content = null,
            Dictionary<string, string> stringHeaders = null,
            Dictionary<string, string[]> arrayHeaders = null) where T : class;
    }
}