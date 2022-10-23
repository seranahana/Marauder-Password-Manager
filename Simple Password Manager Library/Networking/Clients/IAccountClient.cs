using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimplePM.Library.Networking
{
    public interface IAccountClient
    {
        bool IsConfigured { get; }

        /// <summary>
        /// Performs request to authorize existing user account.
        /// </summary>
        /// <param name="login">User Account username.</param>
        /// <param name="password">User Account password.</param>
        /// 
        /// <returns>Tuple where: ID - user unique identificator, MasterPassword - master password hash, MasterSalt - it's salt.</returns>
        /// 
        /// <exception cref="ArgumentException">Login or password were rejected by server as incorrect.</exception>
        /// 
        /// <exception cref="ArgumentNullException">The login or password parameters is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login or password parameters is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task<(string ID, string MasterPasswordHash, string MasterSalt)> AuthenticateAsync(string login,
            string password,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "");

        /// <summary>
        /// Performs request to change user account password.
        /// </summary>
        /// 
        /// <param name="newPassword">New password.</param>
        /// <param name="currentLogin">Current user account username.</param>
        /// <param name="currentPassword">Current user account password.</param>
        /// 
        /// <exception cref="ArgumentException">currentLogin or currentPassword is invalid</exception>
        /// 
        /// <exception cref="ArgumentNullException">One of the parameters is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login or password parameters is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task ChangePasswordAsync(string newPassword,
            string currentLogin,
            string currentPassword,
            [CallerArgumentExpression("newPassword")] string firstParamName = "",
            [CallerArgumentExpression("currentLogin")] string secondParamName = "",
            [CallerArgumentExpression("currentPassword")] string thirdParamName = "");

        /// <summary>
        /// Performs request to check if login is already occupied.
        /// </summary>
        /// 
        /// <param name="login">Desirable login.</param>
        /// 
        /// <returns>True - if login is available, false - if it's not.</returns>
        /// 
        /// <exception cref="ArgumentNullException">The login parameter is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login parameter is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task<bool> CheckLoginAvailabilityAsync(string login, [CallerArgumentExpression("login")] string paramName = "");

        /// <summary>
        /// Performs request to retrieve RSA public key. Can be called manually if configuration during instanse initialization fails.
        /// </summary>
        /// 
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue such as network connectivity
        ///     -or- DNS failure, server certificate validation or timeout.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        Task ConfigureAsync();

        /// <summary>
        /// Performs request to delete user account.
        /// </summary>
        /// 
        /// <param name="login">User account identificator.</param>
        /// <param name="password">Current user account password.</param>
        /// 
        /// <exception cref="ArgumentNullException">The accountID or password parameters is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login or password parameters is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task DeleteAsync(string login,
            string password,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "");

        /// <summary>
        /// Retrieves master password in salted and hashed form from remote server and assigned salt.
        /// </summary>
        /// <param name="login">Existing user account identificator.</param>
        /// 
        /// <returns>Returns Tuple containing master password hash and it's salt.</returns>
        /// 
        /// <exception cref="ArgumentNullException">The login parameter is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login parameter is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task<(string MasterPasswordHash, string MasterSalt)> GetMasterPasswordAsync(string login,
            [CallerArgumentExpression("login")] string paramName = "");

        /// <summary>
        /// Performs request to register new user account.
        /// </summary>
        /// 
        /// <param name="login">New account login.</param>
        /// <param name="password">New account password.</param>
        /// <param name="masterPassword">New account master password.</param>
        /// 
        /// <returns>String containing new account identificator.</returns>
        /// 
        /// <exception cref="ArgumentNullException">The login, password or masterPassword parameters is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login parameter is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        /// 
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task<(string ID, string MasterPasswordHash, string MasterSalt)> RegisterAsync(string login,
            string password,
            string masterPassword,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "",
            [CallerArgumentExpression("masterPassword")] string thirdParamName = "");

        /// <summary>
        /// Performs request to reset current master password.
        /// </summary>
        /// 
        /// <param name="login">Current account username.</param>
        /// <param name="password">Current account password.</param>
        /// 
        /// <returns>String containing operation code. Pass this code to SetMasterPasswordAsync method.</returns>
        /// 
        /// <exception cref="ArgumentNullException">The login or password parameters is null.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login parameter is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task<string> ResetMasterPasswordAsync(string login,
            string password,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "");

        /// <summary>
        /// Performs request to set master password. 
        /// Operation identificator is required for authentification purposes.
        /// </summary>
        /// 
        /// <param name="currentLogin">Current user account username.</param>
        /// <param name="newMasterPass">New master password.</param>
        /// <param name="operationCode">Operation identificator that server return on calling ResetMasterPasswordAsync method.</param>
        /// 
        /// <exception cref="ArgumentNullException">One of the three parameters is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        ///     The cryptographic service provider (CSP) cannot be acquired. 
        ///     -or- The length of the login parameter is greater than the maximum allowed length. 
        ///     -or- OAEP padding is not supported.</exception>
        ///     
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        /// 
        /// <exception cref="NotConfiguredException">Provider is not configured for exchanging data encrypted using RSA algorithm.</exception>
        Task<(string MasterPasswordHash, string MasterSalt)> SetNewMasterPasswordAsync(string currentLogin,
            string operationCode,
            string newMasterPass,
            [CallerArgumentExpression("currentLogin")] string firstParamName = "",
            [CallerArgumentExpression("operationCode")] string secondParamName = "",
            [CallerArgumentExpression("newMasterPass")] string thirdParamName = "");
    }
}