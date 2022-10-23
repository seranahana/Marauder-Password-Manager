using System;
using SimplePM.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePM.Library.Assets.Processors
{
    public interface IEntriesProcessor
    {
        /// <summary>
        /// Encrypts login and password with AES alogirthm and adds entry to storage
        /// </summary>
        /// 
        /// <param name="name">Entry name</param>
        /// <param name="url">Entry URL</param>
        /// <param name="login">Entry login</param>
        /// <param name="password">Entry password</param>
        /// <param name="masterpassword">Master password as a part of AES key</param>
        void Create(string name, string url, string login, string password, string masterpassword);

        /// <summary>
        /// Removes single entry from storage
        /// </summary>
        /// 
        /// <param name="id">Entry unigue identificator</param>
        /// 
        /// <exception cref="ArgumentException">Entry with this identificator does not exist.</exception>
        void Delete(string id);
        void ReencryptAll(string oldMasterPassword, string newMasterPassword);

        /// <summary>
        /// Retrieves single entry from storage and decrypts it's user information
        /// </summary>
        /// 
        /// <param name="id">Entry ID</param>
        /// <param name="masterpassword">Master password as a part of AES key</param>
        /// 
        /// <returns>Returns SimplePM.Library.Models.Entry object</returns>
        Entry Retrieve(string id, string masterpassword);

        /// <summary>
        /// Retrieves all entries from storage and sorts it by name
        /// </summary>
        /// 
        /// <exception cref="InvalidOperationException">Throws this type of exception if sorting fails</exception>
        /// 
        /// <returns>Entries as sorted List<SimplePM.Library.Models> (logins and passwords are encrypted) or null if repository is empty</returns>
        IEnumerable<Entry> RetrieveAll();
        void SaveChanges();

        /// <summary>
        /// Performs three step client-server entries synchronization synchronously(!).
        /// Step 1: Performs request to get all entries stored on server side id's and versions. 
        /// Step 2: Check data internal storage for changes and performs request to get full data for entries that should be added or updated.
        /// Step 3: Performs request to post all entries changed on client side.
        /// </summary>
        /// 
        /// <param name="accountId">User account identificator.</param>
        /// 
        /// <exception cref="ArgumentNullException">The ownerID parameter is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="IncompleteSyncException">See exception details.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        void Synchronize(string accountId);

        /// <summary>
        /// Performs three step client-server entries synchronization asynchronously.
        /// Step 1: Performs request to get all entries stored on server side id's and versions. 
        /// Step 2: Check data internal storage for changes and performs request to get full data for entries that should be added or updated.
        /// Step 3: Performs request to post all entries changed on client side.
        /// </summary>
        /// 
        /// <param name="accountId">User account identificator.</param>
        /// 
        /// <exception cref="ArgumentNullException">The ownerID parameter is null or whitespace.</exception>
        /// 
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue or was rejected by server.</exception>
        /// 
        /// <exception cref="IncompleteSyncException">See exception details.</exception>
        /// 
        /// <exception cref="InvalidOperationException">The request message was already sent by the System.Net.Http.HttpClient instance.</exception>
        Task SynchronizeAsync(string accountId);

        /// <summary>
        /// Updates all entry values in storage
        /// </summary>
        /// 
        /// <param name="id">Entry ID</param>
        /// <param name="name">Entry name</param>
        /// <param name="url">Entry URL</param>
        /// <param name="login">Entry login</param>
        /// <param name="password">Entry password</param>
        /// <param name="masterpassword">Master password as a part of AES key</param>
        /// 
        /// <exception cref="InvalidOperationException">Throws InvalidOperationException if entry not found, internal storage is corrupted or missing</exception>
        void Update(string id, string name, string url, string login, string password, string masterpassword);
    }
}