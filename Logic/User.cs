using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User
    {
        public User()
        {

        }

        public User(string name, string pw)
        {
            Username = name;
            Password = pw;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsValid(User user)
        {
            bool valid = true;

            foreach (char letter in user.Username)
            {
                if (char.IsWhiteSpace(letter) || letter == ':')
                {
                    valid = false;
                }
            }

            foreach (char letter in user.Password)
            {
                if (char.IsWhiteSpace(letter) || letter == ':')
                {
                    valid = false;
                }
            }

            return valid;


            if(Username.Contains(':') && Password.Contains(" "))

            
        }
    }

    
}
