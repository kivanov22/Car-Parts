﻿using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.Auth
{
    public class UpdateRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
