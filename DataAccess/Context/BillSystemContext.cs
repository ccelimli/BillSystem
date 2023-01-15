using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class BillSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=BillSystem; Trusted_Connection=true");
        }

        public DbSet<AnimalShelter> AnimalShelters { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillImage> BillImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Fag> Fags { get; set; }
        public DbSet<Foundation> Foundations { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
