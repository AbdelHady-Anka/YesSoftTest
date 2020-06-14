using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    public class App : IApp
    {
        private readonly IServiceCollection _services;

        public App(IServiceCollection services)
        {
            this._services = services;
        }

        public static AppBuidler CreateAppBuilder()
        {

            return new AppBuidler(new ServiceCollection());
        }

        public void Run()
        {
            var startup = _services.BuildServiceProvider().GetService<IStartup>();
            startup.Configure(_services);
            startup.Run(_services);
        }
    }
}
