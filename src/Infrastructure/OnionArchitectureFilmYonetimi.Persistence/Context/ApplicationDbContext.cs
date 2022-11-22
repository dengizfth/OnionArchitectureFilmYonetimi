using Microsoft.EntityFrameworkCore;
using OnionArchitectureFilmYonetimi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnionArchitectureFilmYonetimi.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Film> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(
                    new Film() { 
                    Id =Convert.ToInt32(Guid.NewGuid()),
                    Name = "Iron Man",
                    CreateYear = 2012
                    },
                    new Film()
                    {
                        Id = Convert.ToInt32(Guid.NewGuid()),
                        Name = "Wonder Woman",
                        CreateYear = 2016
                    },
                    new Film()
                    {
                        Id = Convert.ToInt32(Guid.NewGuid()),
                        Name = "aaaaa",
                        CreateYear = 3333
                    },
                    new Film()
                    {
                        Id = Convert.ToInt32(Guid.NewGuid()),
                        Name = "bbbbb",
                        CreateYear = 2222
                    },
                    new Film()
                    {
                        Id = Convert.ToInt32(Guid.NewGuid()),
                        Name = "ccccc",
                        CreateYear = 1111
                    }
                );
        }
    }
}
