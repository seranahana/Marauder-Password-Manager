using Newtonsoft.Json;

namespace SimplePM.Library.Models
{
    public class UserData
    {
        [JsonProperty]
        internal string ID { get; set; }
        [JsonProperty]
        internal string Login { get; set; }
        [JsonProperty]
        internal string Password { get; set; }
        [JsonProperty]
        internal string Salt { get; set; }
        [JsonProperty]
        internal string MasterPassword { get; set; }
        [JsonProperty]
        internal string MasterSalt { get; set; }

        public UserData()
        {
        }

        public UserData(string id, string masterPassword)
        {
            ID = id;
            MasterPassword = masterPassword;
        }

        public UserData(string login, string password, string masterPassword)
        {
            Login = login;
            Password = password;
            MasterPassword = masterPassword;
        }

        public void Decontructor(out string id, out string masterPassword, out string masterSalt)
        {
            id = ID;
            masterPassword = MasterPassword;
            masterSalt = MasterSalt;
        }
    }
}
