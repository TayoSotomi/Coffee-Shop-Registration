﻿using Microsoft.AspNetCore.Identity;

namespace Coffee_Shop_Registration.Models
{
    public class NewUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Lactose { get; set; }
        public string Flavor { get; set; }

    }
}
