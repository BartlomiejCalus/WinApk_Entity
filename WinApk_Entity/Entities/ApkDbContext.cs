using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApk_Entity.Entities
{
    internal class ApkDbContext: DbContext
    {
        private readonly string _connectionString =
           "Server=DESKTOP-P6EHEFN\\SQLEXPRESS;DataBase=MyApkDb;Trusted_Connection=True";

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishs { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {

            model.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            model.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired();

            model.Entity<Restaurant>()
                .Property(r => r.Name)
                .IsRequired();

            model.Entity<Dish>()
                .Property(d => d.Name)
                .IsRequired();

            model.Entity<Dish>()
                .Property(d => d.Prize)
                .IsRequired();

            model.Entity<Address>()
               .Property(a => a.Street)
               .IsRequired();

            model.Entity<Address>()
               .Property(a => a.City)
               .IsRequired();

            model.Entity<Address>()
               .Property(a => a.PostCode)
               .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
