using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture1.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        // Nuget: Microsoft.Extensions.DependencyInjection.Abstractions
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
         
            return services;
        }
    }
}
