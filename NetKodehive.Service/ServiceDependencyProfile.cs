using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetKodehive.Service.Interface.Services;
using NetKodehive.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Service
{
    public class ServiceDependencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaService, MahasiswaService>();
            services.AddScoped<IDbService, DbService>();
        }
    }
}
