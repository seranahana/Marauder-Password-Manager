using System;

namespace SimplePM.Library
{
    public interface IPasswordGenerator
    {
        /// <summary>
        /// Generates new reliable cryptographically secure byte sequence. 
        /// By reliable means that result string will contain at least one uppercase letter, one lowercase letter, 
        /// one number and one non-digit and non-letter symbol. 
        /// All length values lower than 8 and greater than 128 will throw ArgumentOutOfRangeException.
        /// </summary>
        /// 
        /// <param name="length">Required password length.</param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">length parameter is greater then 128 or lower then 8.</exception>
        /// <returns>Cryptographically secure password with specified length.</returns>
        string Generate(int length);
    }
}