using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Models
{
    public class ContactFormUser
    {
           private string key;
           private string name;
           private string email;
           private string telephone;
           private string message;



          public ContactFormUser(string key,
                             string name,
                             string email,
                             string telephone,
                             string message
                                   
                                   
                              )
        {
            this.key = key;
            this.name = name;
            this.email = email;
            this.telephone = telephone;
            this.message = message;
          
           
        }
          public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }
          public string Name
          {
              get { return this.name; }
              set { this.name = value; }
          }
          public string Email
          {
              get { return this.email; }
              set { this.email = value; }
          }
          public string Telephone
          {
              get { return this.telephone; }
              set { this.telephone = value; }
          }
          public string Message
          {
              get { return this.message; }
              set { this.message = value; }
          }

    }
}
