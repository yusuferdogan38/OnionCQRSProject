using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Application.Registration
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();
            service.AddMediatR(cfg =>cfg.RegisterServicesFromAssembly(assembly));
        }


    }
}
