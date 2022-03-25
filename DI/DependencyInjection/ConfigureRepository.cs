using Data.DataConnector;
using Data.Interfaces.DataConnector;
using Data.Repository;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<Repository<Base>>((serviceProvider) => (Repository<Base>)serviceProvider.GetRequiredService<IRepository<Base>>());
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}