using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Persistence.Context;
using OnionArchitectureApp.Persistence.Repositories;

namespace OnionArchitectureApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            // InMemory veritabanı kullanımı
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("memoryDb"));

            // Repository kayıtları
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
