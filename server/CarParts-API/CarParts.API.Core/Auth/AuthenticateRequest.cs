﻿using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.Auth
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
