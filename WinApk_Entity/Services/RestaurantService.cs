using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;
using WinApk_Entity.Models;

namespace WinApk_Entity.Services
{
    public class RestaurantService
    {
        private readonly ApkDbContext _dbContext = new ApkDbContext();
        private readonly Mapper _mapper, _mapperToDto;

        public RestaurantService()
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<AddRestaurantDto, Restaurant>()
            .ForMember(s => s.Address, c => c.MapFrom(dto => 
            new Address() {
                City = dto.City, 
                Street = dto.Street, 
                PostCode = dto.PostCode
            })));

            var configToDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<Restaurant, AddRestaurantDto>()
            .ForMember(m => m.City, c => c.MapFrom(s => s.Address.City))
            .ForMember(m => m.Street, c => c.MapFrom(s => s.Address.Street))
            .ForMember(m => m.PostCode, c => c.MapFrom(s => s.Address.PostCode)));

            _mapper = new Mapper(config);
            _mapperToDto = new Mapper(configToDto);

        }
        public List<Restaurant> LoadRestaurant()
        {
            var restaurants = _dbContext
                .Restaurants
                .ToList();

            return restaurants;
        }

        public AddRestaurantDto ShowRestaurant (string name)
        {
            var restaurant = _dbContext
                .Restaurants
                .Include(r=>r.Address)
                .FirstOrDefault(r => r.Name == name);

            var result = _mapperToDto.Map<AddRestaurantDto>(restaurant);

            return result;
        }

        public void AddRestaurant(AddRestaurantDto dto)
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

            var restaurant = _mapper.Map<Restaurant>(dto);

            _dbContext
                .Restaurants
                .Add(restaurant);

            _dbContext.SaveChanges();
        }

        public void DeleteRestaurant(string name)
        {
            var result = _dbContext
                .Restaurants
                .Include(r => r.Address)
                .Include(r=>r.Dishes)
                .FirstOrDefault(d => d.Name == name);

            if (result == null)
            {
                return;
            }

            var adress = _dbContext
                .Addresses
                .FirstOrDefault(a => a.Restaurant == result);

            var dishes = _dbContext
                .Dishs
                .Where(d => d.Restaurant == result)
                .ToList();

            if (dishes != null)
            {
                foreach(var dish in dishes)
                {
                    _dbContext.Remove(dish);
                }
            }
            _dbContext.Remove(adress);
            _dbContext.Remove(result);
            _dbContext.SaveChanges();
        }

        public void EditRestaurant(string name, AddRestaurantDto dto)
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

            var restaurant = _dbContext
               .Restaurants
               .FirstOrDefault(r => r.Name == name);

            restaurant.Name = dto.Name;
            restaurant.Description = dto.Description;
            restaurant.Address.City = dto.City;
            restaurant.Address.Street = dto.Street;
            restaurant.Address.PostCode = dto.PostCode;

            _dbContext.SaveChanges();
        }

    }
}
