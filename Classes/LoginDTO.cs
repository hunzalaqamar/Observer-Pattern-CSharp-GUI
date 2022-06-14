using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_LAB_W14.Classes
{
    public class LoginDTO
    {
        private string username;
        private string password;

        public LoginDTO(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public LoginDTO()
        {
            this.username = "";
            this.password = "";
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
