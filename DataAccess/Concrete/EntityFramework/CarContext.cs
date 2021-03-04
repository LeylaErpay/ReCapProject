using Core.Entities;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Concrete.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; 
                                        Database=Car;Trusted_Connection=true");
        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
