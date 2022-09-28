﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using System.ComponentModel.DataAnnotations;

using WinApk_Entity.Models;
using WinApk_Entity.Entities;
using WinApk_Entity.Entities;

namespace WinApk_Entity.Services
{
    public class DishService
    {
        private readonly ApkDbContext _dbContext = new ApkDbContext();

        private readonly Mapper _mapper;

        public DishService()
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<AddDishDto, Dish>());

            _mapper = new Mapper(config);
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
    }
}
