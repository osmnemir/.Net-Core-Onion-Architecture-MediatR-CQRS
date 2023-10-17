using ProductApp.Domain.Common;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdd.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity  // T den gönderilecek BaseEntityden başka bişey gönderilemeyecek.
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
