using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NHibernateMVC.Models
{
    public class Users
    {
        
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }

    }
    public class ValidationUsers
    {

        public virtual string Name { get; set; }

        public virtual string Password { get; set; }
       
    }
    public class Login_Logout
    {
        public virtual bool Czy_zalogowano { get; set; }
        public virtual bool Czy_wylogowano { get; set; }

    }

}