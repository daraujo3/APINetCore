using Api.Domain.Interfaces;
using Data.Context;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDepenciesRepository(IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            //servicesCollection.AddDbContext<MyContext>(
            //    opt => opt.UseMySql("Server=192.168.0.102;Port=3306;Database=dbAPI;Uid=root;Pwd=loja1402")
            //);

            servicesCollection.AddDbContext<MyContext>(
                opt => opt.UseSqlServer("Server=192.168.0.102;Database=dbAPI;User Id=sa;Password=loja1402!")
            );
        }
    }
}
