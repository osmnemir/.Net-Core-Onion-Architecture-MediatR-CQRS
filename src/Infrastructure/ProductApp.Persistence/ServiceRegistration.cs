using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductAdd.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
