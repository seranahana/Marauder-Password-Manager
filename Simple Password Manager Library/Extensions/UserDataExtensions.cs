using SimplePM.Library.Cryptography;
using SimplePM.Library.Models;
using System;

namespace SimplePM.Library
{
    internal static class UserDataExtensions
    {
        /// <summary>
        /// Encrypts all data in instance that is not null with RSA public key
        /// </summary>
        /// 
        /// <param name="rsaPublicKey">RSA public key</param>
        /// 
        /// <exception cref="ArgumentException">Decrypted byte array contains invalid Unicode code points</exception>
        /// 
        /// <exception cref="ArgumentNullException">RSA private key is null
        /// -or- one of RSA private key parameters in null</exception>
        /// 
        /// /// <exception cref="System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.
        ///     -or- The fOAEP parameter is true and the length of the rgb parameter
        ///     is greater than System.Security.Cryptography.RSACryptoServiceProvider.KeySize.
        ///     -or- The key does not match the encrypted data. However, the exception wording
        ///     may not be accurate. For example, it may say Not enough storage is available
        ///    to process this command.</exception>
        /// 
        /// <exception cref="System.Text.EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET)
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        /// 
        /// <exception cref="FormatException">The length of encrypted string,
        ///     ignoring white-space characters, is not zero or a multiple 4.
        ///     -or- The format of encrypted string is invalid. Encrypted string contains a non-base-64 character, more
        ///     than two padding characters, or a non-white space-character among the padding characters.</exception>
        internal static void EncryptPrivateData(this UserData userData, string rsaPublicKey)
        {
            if (rsaPublicKey is null)
            {
                throw new ArgumentNullException(nameof(rsaPublicKey));
            }
            if (userData.Login is not null)
            {
                string encryptedLogin = CryptographyProvider.RSA.Encrypt(userData.Login, rsaPublicKey);
                userData.Login = encryptedLogin;
            }
            if (userData.Password is not null)
            {
                string encryptedPassword = CryptographyProvider.RSA.Encrypt(userData.Password, rsaPublicKey);
                userData.Password = encryptedPassword;
            }
            if (userData.Salt is not null)
            {
                string encryptedSalt = CryptographyProvider.RSA.Encrypt(userData.Salt, rsaPublicKey);
                userData.Salt = encryptedSalt;
            }
            if (userData.MasterPassword is not null)
            {
                string encryptedMasterPassword = CryptographyProvider.RSA.Encrypt(userData.MasterPassword, rsaPublicKey);
                userData.MasterPassword = encryptedMasterPassword;
            }
            if (userData.MasterSalt is not null)
            {
                string encryptedMasterSalt = CryptographyProvider.RSA.Encrypt(userData.MasterSalt, rsaPublicKey);
                userData.MasterSalt = encryptedMasterSalt;
            }
        }

        /// <summary>
        /// Computes hash codes for all not null password fields in UserData instanse and updates them with resulting values. 
        /// If field containing salt is null or empty, a new salt will be generated.
        /// </summary>
        /// 
        /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET) 
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        public static void HashPasswords(this UserData userData)
        {
            if (!string.IsNullOrEmpty(userData.Password))
            {
                userData.HashAccountPassword();
            }
            if (!string.IsNullOrEmpty(userData.MasterPassword))
            {
                userData.HashMasterPassword();
            }
        }

        /// <summary>
        /// Computes hash codes only for Password field in UserData instanse and updates it with resulting value. 
        /// If Salt field is null or empty, a new salt will be generated.
        /// </summary>
        /// 
        /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET) 
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        public static void HashAccountPassword(this UserData userData)
        {
            if (string.IsNullOrEmpty(userData.Salt))
            {
                string salt = CryptographyProvider.SHA256.GenerateSalt();
                string saltedAndHashedPassword = CryptographyProvider.SHA256.SaltAndHashPassword(userData.Password, salt);
                userData.Password = saltedAndHashedPassword;
                userData.Salt = salt;
            }
            else
            {
                string saltedAndHashedPassword = CryptographyProvider.SHA256.SaltAndHashPassword(userData.Password, userData.Salt);
                userData.Password = saltedAndHashedPassword;
            }
        }

        /// <summary>
        /// Computes hash codes only for MasterPassword field in UserData instanse and updates it with resulting value. 
        /// If MasterSalt field is null or empty, a new salt will be generated.
        /// </summary>
        /// 
        /// <exception cref="EncoderFallbackException">A fallback occurred (for more information, see Character Encoding in .NET) 
        ///     -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.</exception>
        public static void HashMasterPassword(this UserData userData)
        {
            if (string.IsNullOrEmpty(userData.MasterSalt))
            {
                string masterSalt = CryptographyProvider.SHA256.GenerateSalt();
                string saltedAndHashedMasterPassword = CryptographyProvider.SHA256.SaltAndHashPassword(userData.MasterPassword, masterSalt);
                userData.MasterPassword = saltedAndHashedMasterPassword;
                userData.MasterSalt = masterSalt;
            }
            else
            {
                string saltedAndHashedMasterPassword = CryptographyProvider.SHA256.SaltAndHashPassword(userData.MasterPassword, userData.MasterSalt);
                userData.MasterPassword = saltedAndHashedMasterPassword;
            }
        }
    }
}
