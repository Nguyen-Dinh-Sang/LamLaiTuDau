using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Repository;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<INguoiDungService, NguoiDungService>();

            // Infrastructure.Data
            services.AddScoped<INguoiDungRepository, NguoiDungRepository>();
        }
    }
}
