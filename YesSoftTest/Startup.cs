using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace YesSoftTest
{
    public class Startup : IStartup
    {

        public void Configure(IServiceCollection services)
        {
            services.AddScoped<IDispatcher, Dispatcher>();
            List<Type> divisableTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsDivisableInterface()))
                .ToList();

            divisableTypes.ForEach(dt => AddDivisable(services, dt));
        }

        private void AddDivisable(IServiceCollection services, Type dt)
        {
            Type interfaceType = dt.GetInterfaces().Single(i => i.IsDivisableInterface());
            services.AddScoped(interfaceType, dt);
        }

        public void Run(IServiceCollection services)
        {
            var dispatcher = services.BuildServiceProvider().GetService<IDispatcher>();
            for(var i=0; i<100; i++)
            {
                dispatcher.Dispatch(new EvNum { Num= i });
            }
        }
    }
}
