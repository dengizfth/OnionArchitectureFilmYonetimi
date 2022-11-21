using OnionArchitectureFilmYonetimi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureFilmYonetimi.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {

        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int Id);

        Task<T> AddAsync(T entity);
    }
}
