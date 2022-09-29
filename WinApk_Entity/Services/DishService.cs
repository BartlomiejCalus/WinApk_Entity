using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Models;
using WinApk_Entity.Entities;
using WinApk_Entity.Entities;

namespace WinApk_Entity.Services
{
    public class DishService
    {
        private readonly ApkDbContext _dbContext = new ApkDbContext();

        private readonly Mapper _mapper, _mapperToDto;

        public DishService()
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<AddDishDto, Dish>());

            var configToDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<Dish, DishDto>());

            _mapper = new Mapper(config);
            _mapperToDto = new Mapper(configToDto);
        }

        public void LoadRestaurant(ComboBox comboBox)
        {
            var restaurants = _dbContext
                .Restaurants
                .ToList();

            comboBox.DataSource = restaurants;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
        }

        public void LoadDishes (ComboBox comboBox, string name)
        {
            var restaurant = _dbContext
                .Restaurants
                .Include(r=>r.Dishes)
                .FirstOrDefault(r=>r.Name==name);

            var dishes = restaurant?
                .Dishes
                .ToList();

            comboBox.DataSource = dishes;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
        }

        public DishDto showDish(string RestaurantName, string dishName)
        {
            var restaurant = _dbContext
                .Restaurants
                .Include(r => r.Dishes)
                .FirstOrDefault(r => r.Name == RestaurantName);

            var dish = restaurant?
                .Dishes
                .FirstOrDefault(d => d.Name == dishName);

            var result = _mapperToDto.Map<DishDto>(dish);

            return result;

        }

        public void AddDish(AddDishDto dto, string Restaurant)
        {
            var contex = new ValidationContext(dto, null, null);
            var result = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, contex, result, true);

            if (isValid)
            {
                var dish = _mapper.Map<Dish>(dto);

                dish.Restaurant = _dbContext
                    .Restaurants
                    .FirstOrDefault(r => r.Name == Restaurant);

                dish.RestaurantId = dish.Restaurant.Id;

                _dbContext
                    .Dishs
                    .Add(dish);

                _dbContext.SaveChanges();
            }
            else
            {
                foreach (var r in result)
                {
                    MessageBox.Show(r.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }  
        }

        public void DeleteDish(string name)
        {
            var result = _dbContext
                .Dishs
                .FirstOrDefault(d=>d.Name == name);

            if (result != null)
            {
                _dbContext.Remove(result);
                _dbContext.SaveChanges();
            }
        }

        public void EditDish(string RestaurantName, string dishName, AddDishDto dto)
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
               .Include(r => r.Dishes)
               .FirstOrDefault(r => r.Name == RestaurantName);

            var dish = restaurant?
                .Dishes
                .FirstOrDefault(d => d.Name == dishName);

            var toDish = _mapper.Map<Dish>(dto);

            dish.Name = toDish.Name;
            dish.Prize = toDish.Prize;
            dish.Description = toDish.Description;

            _dbContext.SaveChanges();
        }
    }
}
