using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetKodehive.Data.Interface.Repositories;
using NetKodehive.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetKodehive.Data
{
    public class DataDependencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaRepository, MahasiswaRepository>();
        }
    }
}
