using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;
using WinApk_Entity.Models;

namespace WinApk_Entity.Services
{
    public class AccountService
    {

        ApkDbContext _dbContext = new ApkDbContext();
        PasswordHasher<User> _passwordHaser = new PasswordHasher<User>();

        public void RegisterUser(UserRegisterDto dto)
        {
            var newUser = new User()
            {
                Email = dto.Email,
                RoleId = dto.RoleId,
            };

            var passwordHash = _passwordHaser.HashPassword(newUser, dto.Password);
            newUser.PasswordHs = passwordHash;

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
        }

        public string LoginUser(UserLoginDto dto)
        {
            var user = _dbContext.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.Email == dto.Email);

            if (user is null)
            {
                return null;
            }

            var result = _passwordHaser.VerifyHashedPassword(user, user.PasswordHs, dto.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                return null;
            }

            return user.Email;
        }
    }
}
