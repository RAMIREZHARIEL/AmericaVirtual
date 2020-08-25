using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_AmericaVirtual.Models
{
    public class User
    {
        public int id { get; set; }
        public String mail { get; set; }
        public String password { get; set; }

        public User(String mail, String password)
        {
            this.mail = mail;
            this.password = password;
        }

        public User()
        {

        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}