using System;
namespace WebGame.Models
{

    public class User
    {
        public string name { get; set; }
        public string password { get; set; }

        public User()
        {
            name = "isaac";
            password = "banana";
        }
    }
}

