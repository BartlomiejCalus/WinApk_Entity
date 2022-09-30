using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using WinApk_Entity.Entities;
using WinApk_Entity.Models;

namespace WinApk_Entity.Services
{
    public class UserService
    {
        private readonly ApkDbContext _dbContext = new ApkDbContext();
        PasswordHasher<User> _passwordHaser = new PasswordHasher<User>();
        private readonly Mapper _mapper, _mapperToDto;

        public UserService()
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<UserDto, User>()
            .ForMember(s => s.Role, c => c.MapFrom(dto =>
            new Role()
            {
                Name = dto.RoleName,
                Id = dto.RoleId
                
            })));

            var configToDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<User, UserDto>()
            .ForMember(m => m.RoleName, c => c.MapFrom(s => s.Role.Name)));

            _mapper = new Mapper(config);
            _mapperToDto = new Mapper(configToDto);
        }

        public List<User> LoadUser()
        {
            var users = _dbContext
                .Users
                .ToList();

            return users;
        }

        public UserDto ShowRestaurant(string email)
        {
            var user = _dbContext
                .Users
                .FirstOrDefault(u => u.Email == email);

            var result = _mapperToDto.Map<UserDto>(user);

            return result;
        }

        public void EditUser(string email, UserDto dto)
        {
            var contex = new ValidationContext(dto, null, null);
            var result = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, contex, result, true);

            if (!isValid)
            {
                foreach (var r in result)
                {
                    MessageBox.Show(r.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return;
            }

            var user = _dbContext
               .Users
               .Include(u=>u.Role)
               .FirstOrDefault(u => u.Email == email);

            user.Email = dto.Email;
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Role.Name = dto.RoleName;
            user.RoleId = dto.RoleId;

            _dbContext.SaveChanges();
        }

        public void DeleteUser(string emali)
        {
            var result = _dbContext
                .Users
                .FirstOrDefault(d => d.Email == emali);

            if (result == null)
            {
                return;
            }

            _dbContext.Remove(result);
            _dbContext.SaveChanges();
        }

    }
}
