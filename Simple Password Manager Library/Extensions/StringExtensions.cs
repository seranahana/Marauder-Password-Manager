using System.Linq;

namespace SimplePM.Library
{
    public static class StringExtensions
    {
        public static bool IsReliablePassword(this string password)
        {
            if (password != null)
            {
                if (password.Length <= 8)
                {
                    return false;
                }
                bool alphabetic = password.Any(ch => char.IsUpper(ch)) && password.Any(ch => char.IsLower(ch));
                bool numeric = password.Any(ch => char.IsDigit(ch));
                bool symbolic = password.Any(ch => !char.IsLetterOrDigit(ch));
                return (alphabetic && numeric && symbolic);
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidLogin(this string login)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                return false;
            }
            if (login.Length < 3)
            {
                return false;
            }
            if (login.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPassword(this string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }
            return true;
        }
    }
}
