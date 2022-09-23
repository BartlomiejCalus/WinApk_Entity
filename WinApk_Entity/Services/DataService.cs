using Microsoft.EntityFrameworkCore;
using AutoMapper;

using WinApk_Entity.Entities;
using WinApk_Entity.Models;

namespace WinApk_Entity.Services
{
    public class DataService
    {
        ApkDbContext _dbContext = new ApkDbContext();
        Mapper _mapper;

        public DataService()
        {
            var config = new MapperConfiguration(cfg=>
            cfg.CreateMap<Restaurant, RestaurantDto>()
            .ForMember(m => m.City, c => c.MapFrom(s => s.Address.City))
            .ForMember(m => m.Street, c => c.MapFrom(s => s.Address.Street)));

            _mapper = new Mapper(config);
        }

        public IEnumerable<RestaurantDto> ShowData()
        {
            var result = _dbContext
                .Restaurants
                .Include(s => s.Address)
                .ToList();

            var restaurantsDto = _mapper.Map<List<RestaurantDto>>(result);

            return restaurantsDto;
        }

        public IEnumerable<RestaurantDto> GetRestaurant(string search)
        {
            var result = _dbContext
                .Restaurants
                .Include(r => r.Address)
                .Where(r => r.Name == search)
                .ToList();

            if (result == null)
                return null;

            var restaurantsDto = _mapper.Map<List<RestaurantDto>>(result);

            return restaurantsDto;

        }

        public IEnumerable<RestaurantDto> GetRestaurant(string city = "", string street = "")
        {
            var result = _dbContext
                .Restaurants
                .Include(r => r.Address)
                .Where(r => r.Address.City == city || r.Address.Street == street)
                .ToList();

            if (result == null)
                return null;

            var restaurantsDto = _mapper.Map<List<RestaurantDto>>(result);


            return restaurantsDto;

        }
    }
}
