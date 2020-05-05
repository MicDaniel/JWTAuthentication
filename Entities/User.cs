﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JWTAuthentication.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        
        /*
            Using JsonIgnore attribute to prevent the password property from being serialized 
            and returned in api responses.
        */

        [JsonIgnore]
        public string Password { get; set; }
        public string Token { get; set; }
    }
}