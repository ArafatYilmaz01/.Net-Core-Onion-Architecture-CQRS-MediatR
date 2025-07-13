using System;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using MediatR;
using System.Reflection;

namespace OnionArchitectureApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // AutoMapper registration (tüm assembly'lerden yükle)
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // MediatR registration (yeni sürüm uyumlu)
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            // Diğer application katmanı servislerini buraya ekleyebilirsin
        }
    }
}
