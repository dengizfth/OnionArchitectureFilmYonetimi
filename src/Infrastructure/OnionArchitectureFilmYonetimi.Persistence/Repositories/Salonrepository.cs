using OnionArchitectureFilmYonetimi.Application.Interfaces.Repositories;
using OnionArchitectureFilmYonetimi.Domain.Entities;
using OnionArchitectureFilmYonetimi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureFilmYonetimi.Persistence.Repositories
{
    class Salonrepository : GenericRepository<Salon>, ISalonRepository
    {
        public Salonrepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }

    }
}
