﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Persistence.Registration
{
    public static class Registration
    {
        public static void AddPersistance(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddDbContext<Context.AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
