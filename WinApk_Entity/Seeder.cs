using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApk_Entity.Entities;

namespace WinApk_Entity
{
    public class Seeder
    {
        private readonly ApkDbContext _dbContext;

        public Seeder(ApkDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Roles.Any())
                {
                    var roles = GetRoles();
                    _dbContext.Roles.AddRange(roles);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Restaurants.Any())
                {
                    var salons = GetRestaurants();
                    _dbContext.Restaurants.AddRange(salons);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "u Krychy",
                    Description = "Bardzo dobre obiaddy jak u Zosi",

                    Address = new Address()
                    {
                        City = "Częstochowa",
                        Street = "Fiołkowa 6",
                        PostCode = "42-202"
                    },

                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Meksykanska Fala",
                            Description = "Czyste szaleństwo z ziemniakami",
                            Prize = 53.28
                        },
                        new Dish()
                        {
                            Name = "My Słowianie",
                            Description = "Wiemy jak poruszyć kurczaka którego Zosia dała",
                            Prize = 26.63
                        }

                    }
                },

                new Restaurant()
                {
                    Name = "u Zochy",
                    Description = "Bardzo dobre obiaddy jak u Krysi",

                    Address = new Address()
                    {
                        City = "Częstochowa",
                        Street = "Fiołkowa 5",
                        PostCode = "42-202"
                    },

                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Słowiańsa Fala",
                            Description = "Czyste szaleństwo z frytkami",
                            Prize = 28.53
                        },
                        new Dish()
                        {
                            Name = "My Meksykanie",
                            Description = "Wiemy jak poruszyć prosiaka którego Krysia dała",
                            Prize = 42.00
                        }

                    }
                }
            };
            return restaurants;
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "User"
                },
                new Role()
                {
                    Name = "Manager"
                },
                new Role()
                {
                    Name = "Admin"
                }
            };
            return roles;
        }
    }
}
