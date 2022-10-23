using Newtonsoft.Json;
using SimplePM.Library.Cryptography;
using SimplePM.Library.Diagnostics;
using SimplePM.Library.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimplePM.Library.Networking
{
    public class AccountClient : IAccountClient
    {
        private string configurationFailureMessage;
        private readonly IHttpHandler _httpHandler;
        private string serverRsaPublicKey;
        private string clientRsaPublicKey;
        private string clientRsaPrivateKey;

        public bool IsConfigured { get; private set; } = false;

        public AccountClient(IHttpHandler httpHandler)
        {
            _httpHandler = httpHandler;
            CreateRSAParameters();
            if (!IsConfigured)
            {
                Task.Run(ConfigureAsync);
            }
        }

        #region ServiceType.Accounts

        /// GET
        /// FromHeader: string encryptedLogin
        public async Task<bool> CheckLoginAvailabilityAsync(string login,
            [CallerArgumentExpression("login")] string paramName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(paramName);
            }
            string encryptedLogin = CryptographyProvider.RSA.Encrypt(login, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                { nameof(encryptedLogin), encryptedLogin }
            };
            string response = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Get, ServiceType.Accounts, "login/availability", null, headers);
            return bool.Parse(response);
        }

        /// POST
        /// ServiceType.Accounts, FromBody: UserData newData
        public async Task<(string ID, string MasterPasswordHash, string MasterSalt)> RegisterAsync(string login, string password, string masterPassword,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "",
            [CallerArgumentExpression("masterPassword")] string thirdParamName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(firstParamName);
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(secondParamName);
            }
            if (string.IsNullOrWhiteSpace(masterPassword))
            {
                throw new ArgumentNullException(thirdParamName);
            }

            UserData data = new(login, password, masterPassword);
            data.EncryptPrivateData(serverRsaPublicKey);
            string response = await _httpHandler.CreateAndSendAsync(HttpMethod.Post, ServiceType.Accounts, null, data);
            UserData newAccountData = JsonConvert.DeserializeObject<UserData>(response);
            return (newAccountData.ID, newAccountData.MasterPassword, newAccountData.MasterSalt);
        }

        /// GET
        /// FromHeader: string encryptedLogin, string encryptedPassword
        public async Task<(string ID, string MasterPasswordHash, string MasterSalt)> AuthenticateAsync(string login, string password,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(firstParamName);
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(secondParamName);
            }
            string encryptedLogin = CryptographyProvider.RSA.Encrypt(login, serverRsaPublicKey);
            string encryptedPassword = CryptographyProvider.RSA.Encrypt(password, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                {nameof(encryptedLogin),  encryptedLogin},
                {nameof(encryptedPassword), encryptedPassword}
            };
            try
            {
                string response = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Get, ServiceType.Accounts, null, null, headers);
                UserData userData = JsonConvert.DeserializeObject<UserData>(response);
                return (userData.ID, userData.MasterPassword, userData.MasterSalt);
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new ArgumentException("Invalid password", secondParamName);
                    case System.Net.HttpStatusCode.NotFound:
                        throw new ArgumentException("Login not found", firstParamName);
                    default:
                        throw;
                }
            }
        }

        /// PATCH
        /// FromHeader: string encryptedNewPassword, string encryptedCurrentLogin, string encryptedCurrentPassword
        public async Task ChangePasswordAsync(string newPassword, string currentLogin, string currentPassword,
            [CallerArgumentExpression("newPassword")] string firstParamName = "",
            [CallerArgumentExpression("currentLogin")] string secondParamName = "",
            [CallerArgumentExpression("currentPassword")] string thirdParamName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new ArgumentNullException(firstParamName);
            }
            if (string.IsNullOrWhiteSpace(currentLogin))
            {
                throw new ArgumentNullException(secondParamName);
            }
            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                throw new ArgumentNullException(thirdParamName);
            }
            string encryptedNewPassword = CryptographyProvider.RSA.Encrypt(newPassword, serverRsaPublicKey);
            string encryptedCurrentLogin = CryptographyProvider.RSA.Encrypt(currentLogin, serverRsaPublicKey);
            string encryptedCurrentPassword = CryptographyProvider.RSA.Encrypt(currentPassword, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                {nameof(encryptedNewPassword), encryptedNewPassword },
                {nameof(encryptedCurrentLogin), encryptedCurrentLogin },
                {nameof(encryptedCurrentPassword), encryptedCurrentPassword}
            };
            try
            {
                await _httpHandler.CreateAndSendAsync<string>(new HttpMethod("PATCH"), ServiceType.Accounts, null, null, headers);
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        throw new ArgumentException("Login not found", secondParamName);
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new ArgumentException("Invalid password", thirdParamName);
                    default:
                        throw;
                }
            }
        }

        /// DELETE
        /// FromHeader: string encryptedLogin, string encryptedPassword
        public async Task DeleteAsync(string login, string password,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(firstParamName);
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(secondParamName);
            }
            string encryptedLogin = CryptographyProvider.RSA.Encrypt(login, serverRsaPublicKey);
            string encryptedPassword = CryptographyProvider.RSA.Encrypt(password, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                {nameof(encryptedLogin),  encryptedLogin},
                {nameof(encryptedPassword), encryptedPassword}
            };
            try
            {
                await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Delete, ServiceType.Accounts, null, null, headers);
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new ArgumentException("Invalid password", secondParamName);
                    default:
                        throw;
                }
            }
        }

        #endregion

        #region ServiceType.MasterPassword

        /// GET
        /// FromHeader: string encryptedLogin
        public async Task<(string MasterPasswordHash, string MasterSalt)> GetMasterPasswordAsync(string login,
            [CallerArgumentExpression("login")] string paramName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(paramName);
            }
            string encryptedLogin = CryptographyProvider.RSA.Encrypt(login, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                {nameof(encryptedLogin), encryptedLogin}
            };
            string response = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Get, ServiceType.MasterPassword, null, null, headers);
            UserData userData = JsonConvert.DeserializeObject<UserData>(response);
            return (userData.MasterPassword, userData.MasterSalt);
        }

        /// POST
        /// FromHeader: string encryptedCurrentLogin, string encryptedCurrentMasterPassOrOperationCode, string encryptedNewMasterPass
        public async Task<(string MasterPasswordHash, string MasterSalt)> SetNewMasterPasswordAsync(string currentLogin,
            string currentMasterPassOrOperationCode,
            string newMasterPass,
            [CallerArgumentExpression("currentLogin")] string firstParamName = "",
            [CallerArgumentExpression("currentMasterPassOrOperationCode")] string secondParamName = "",
            [CallerArgumentExpression("newMasterPass")] string thirdParamName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(currentLogin))
            {
                throw new ArgumentNullException(firstParamName);
            }
            if (string.IsNullOrWhiteSpace(currentMasterPassOrOperationCode))
            {
                throw new ArgumentNullException(secondParamName);
            }
            if (string.IsNullOrWhiteSpace(newMasterPass))
            {
                throw new ArgumentNullException(thirdParamName);
            }
            string encryptedCurrentLogin = CryptographyProvider.RSA.Encrypt(currentLogin, serverRsaPublicKey);
            string encryptedCurrentMasterPassOrOperationCode = CryptographyProvider.RSA.Encrypt(currentMasterPassOrOperationCode, serverRsaPublicKey);
            string encryptedNewMasterPass = CryptographyProvider.RSA.Encrypt(newMasterPass, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                { nameof(encryptedCurrentLogin), encryptedCurrentLogin },
                { nameof(encryptedCurrentMasterPassOrOperationCode), encryptedCurrentMasterPassOrOperationCode },
                { nameof(encryptedNewMasterPass), encryptedNewMasterPass }
            };
            try
            {
                string response = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Post, ServiceType.MasterPassword, null, null, headers);
                UserData masterPassData = JsonConvert.DeserializeObject<UserData>(response);
                return (masterPassData.MasterPassword, masterPassData.MasterSalt);
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new ArgumentException("Invalid password", secondParamName);
                    case System.Net.HttpStatusCode.NotFound:
                        throw new ArgumentException("Login not found", firstParamName);
                    default:
                        throw;
                }
            }
        }

        /// DELETE
        /// FromHeader: string encryptedLogin, string encryptedPassword, string rsaPublicKey
        public async Task<string> ResetMasterPasswordAsync(string login, string password,
            [CallerArgumentExpression("login")] string firstParamName = "",
            [CallerArgumentExpression("password")] string secondParamName = "")
        {
            NotConfiguredException.ThrowIfNotConfigured(IsConfigured, nameof(AccountClient), configurationFailureMessage);
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException(firstParamName);
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(secondParamName);
            }
            string encryptedLogin = CryptographyProvider.RSA.Encrypt(login, serverRsaPublicKey);
            string encryptedPassword = CryptographyProvider.RSA.Encrypt(password, serverRsaPublicKey);
            Dictionary<string, string> headers = new()
            {
                { nameof(encryptedLogin), encryptedLogin },
                { nameof(encryptedPassword), encryptedPassword },
                { "rsaPublicKey", clientRsaPublicKey }
            };
            try
            {
                string encryptedOperationCode = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Delete, ServiceType.MasterPassword, "reset", null, headers);
                return CryptographyProvider.RSA.Decrypt(encryptedOperationCode, clientRsaPrivateKey);
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new ArgumentException("Invalid password", secondParamName);
                    case System.Net.HttpStatusCode.NotFound:
                        throw new ArgumentException("Login not found", firstParamName);
                    default:
                        throw;
                }
            }
        }

        #endregion

        /// GET
        public async Task ConfigureAsync()
        {
            try
            {
                serverRsaPublicKey = await _httpHandler.CreateAndSendAsync<string>(HttpMethod.Get, ServiceType.RSA);
                IsConfigured = true;
            }
            catch (HttpRequestException ex)
            {
                configurationFailureMessage = $"{ex.StatusCode} : {ex.Message}. Additional info: {ex.InnerException.Message}";
            }
            catch (Exception ex)
            {
                configurationFailureMessage = $"{ex.GetType()}: {ex.Message}";
                Logger.CreateExceptionEntry(ex);
            }
        }

        private void CreateRSAParameters()
        {
            var rsa = System.Security.Cryptography.RSA.Create();
            clientRsaPublicKey = rsa.ToXmlStringExt(false);
            clientRsaPrivateKey = rsa.ToXmlStringExt(true);
        }
    }
}
