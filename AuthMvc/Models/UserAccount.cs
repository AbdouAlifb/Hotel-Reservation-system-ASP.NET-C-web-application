using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace AuthMvc.Models
{
    public class UserAccount: IdentityUser
    {
        public UserAccount() { }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaiss{ get; set; }
    }
}
