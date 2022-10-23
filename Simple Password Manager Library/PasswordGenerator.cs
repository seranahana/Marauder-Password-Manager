using System;
using System.Security.Cryptography;
using System.Text;

namespace SimplePM.Library
{
    public sealed class PasswordGenerator : IPasswordGenerator
    {
        private readonly RandomNumberGenerator rng;

        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string NumericCharacters = "0123456789";
        private const string NonAlphanumericCharacters = "~!@#$%^&*()-_=+<,>.?:;{}[]\"'`/\\";
        private const int iterations = 50;

        public PasswordGenerator()
        {
            rng = RandomNumberGenerator.Create();
        }

        public string Generate(int length)
        {
            if (length < 8 || length > 128)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            StringBuilder builder = new();
            while (true)
            {
                int newCharPositionInUppercaseLettersSet = Next(0, UppercaseLetters.Length - 1);
                builder.Append(UppercaseLetters[newCharPositionInUppercaseLettersSet]);
                if (builder.Length == length)
                {
                    break;
                }

                int newCharPositionInLowercaseLettersSet = Next(0, LowercaseLetters.Length - 1);
                builder.Append(LowercaseLetters[newCharPositionInLowercaseLettersSet]);
                if (builder.Length == length)
                {
                    break;
                }

                int newCharPositionInNumericSet = Next(0, NumericCharacters.Length - 1);
                builder.Append(NumericCharacters[newCharPositionInNumericSet]);
                if (builder.Length == length)
                {
                    break;
                }

                int newCharPositionInNonAlphanumericSet = Next(0, NonAlphanumericCharacters.Length - 1);
                builder.Append(NonAlphanumericCharacters[newCharPositionInNonAlphanumericSet]);
                if (builder.Length == length)
                {
                    break;
                }
            }
            string password = Rearrange(builder.ToString());
            return password;
        }

        private int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(minValue));
            }
            if (minValue == maxValue)
            {
                return minValue;
            }
            long diff = maxValue - minValue;
            while (true)
            {
                byte[] uint32Buffer = new byte[4];
                rng.GetBytes(uint32Buffer);
                uint rand = BitConverter.ToUInt32(uint32Buffer, 0);

                long max = (1 + (long)uint.MaxValue);
                long remainder = max % diff;
                if (rand < max - remainder)
                {
                    return (int)(minValue + (rand % diff));
                }
            }
        }

        private string Rearrange(string password)
        {
            for (int i = 0; i < iterations; i++)
            {
                int lengthOfMovingPart = Next(0, password.Length - 1);
                password = string.Format("{0}{1}", password[^lengthOfMovingPart..], password[..^lengthOfMovingPart]);
            }
            return password;
        }
    }
}
