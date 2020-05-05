using JWTAuthentication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Services.Interfaces
{
    public interface ITokenBuilderService
    {
        string GenerateToken(int userId);
    }
}
