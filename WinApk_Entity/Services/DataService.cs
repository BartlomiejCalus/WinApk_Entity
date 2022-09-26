using Microsoft.EntityFrameworkCore;
using AutoMapper;

using WinApk_Entity.Entities;
using WinApk_Entity.Models;
using WinApk_Entity.Forms;

namespace WinApk_Entity.Services
{
    public class DataService
    {
        private readonly ApkDbContext _dbContext = new ApkDbContext();
        private readonly Mapper _mapper, _mapperDish;

        public DataService()
        {
            var config = new MapperConfiguration(cfg=>
            cfg.CreateMap<Restaurant, RestaurantDto>()
            .ForMember(m => m.City, c => c.MapFrom(s => s.Address.City))
            .ForMember(m => m.Street, c => c.MapFrom(s => s.Address.Street)));

            var config2 = new MapperConfiguration(cfg =>
            cfg.CreateMap<Dish, DishDto>());

            _mapper = new Mapper(config);
            _mapperDish = new Mapper(config2);
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

        public IEnumerable<DishDto> GetDishes(string search)
        {
            var result = _dbContext
                .Restaurants
                .Include(r => r.Dishes)
                .FirstOrDefault(r => r.Name == search);

            if (result == null)
                return null;

            var dishes = result.Dishes.ToList();

            var dishesDto = _mapperDish.Map<List<DishDto>>(dishes);

            return dishesDto;

        }

        public void SettingsMenu(int role, Panel panel)
        {
            panel.Controls.Clear();
            MangerPanel MangerPanel_vr = new MangerPanel(role) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MangerPanel_vr.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(MangerPanel_vr);
            MangerPanel_vr.Show();
        }

        public DataGridView SetGrid(Panel panel)
        {
            panel.Controls.Clear();
            DataGrid DataGrid_vr = new DataGrid() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DataGrid_vr.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(DataGrid_vr);
            DataGrid_vr.Show();
            
            return DataGrid_vr.gridView;
        }
    }
}
