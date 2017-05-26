using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Models
{
    public class LoginFormUser
    {
          private string key;
          private string email;
          private string password;
       


        public LoginFormUser(string key,
                             string email,
                             string password
                                   
                                   
                              )
        {
            this.key = key;
            this.email = email;
            this.password = password;
          
           
        }
          public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
