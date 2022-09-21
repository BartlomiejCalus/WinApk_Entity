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

            var restaurantDto = _mapper.Map<List<RestaurantDto>>(result);

            return restaurantDto;
        }
    }
}
