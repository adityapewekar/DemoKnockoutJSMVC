using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StopAndShop.Entites
{
    public class RegistrationEntites
    {
    }

    public class Genders
    {
        public int id { get; set; }
        public string  GenderValue { get; set; }
    }

    public class UserDetails
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }

    }
}