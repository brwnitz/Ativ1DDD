using Microsoft.Extensions.DependencyInjection;
using Model.Domain.Interfaces;
using Model.Infra.Data.Repository;
using Model.Services.Services;
using System;

namespace Model.Infra.CrossCut
{
    public static class Injector
        {
            public static void AddDependencyInjectionConfig(this IServiceCollection services)
            {

                services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
                services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));             

            }
        }
    

}

