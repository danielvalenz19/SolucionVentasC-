﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SistemaVenta.DAL.Interaces;
//using SistemaVenta.DAL.Implemantacion;
//using SistemaVenta.BLL.Interaces;
//using SistemaVenta.BLL.Implemantacion;


namespace SistemaVenta.IOC

{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services,IConfiguration configuration) {
            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        
        }
    }
}
