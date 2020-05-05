using JWTAuthentication.Entities;
using JWTAuthentication.Helpers;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWTAuthentication.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User 
            {
                Id = 1, FirstName = "Test", LastName = "User", 
                Username = "usernameTest", Password ="passwordTest"
            }
        };

        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                return null;
            }
            else
            {
                return user;
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
