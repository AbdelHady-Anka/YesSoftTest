using Microsoft.Extensions.DependencyInjection;

namespace YesSoftTest
{
    public class AppBuidler
    {
        private readonly IServiceCollection _services;


        public AppBuidler(IServiceCollection services)
        {
            _services = services;
        }


        public AppBuidler UseStartup<TStartup>() 
            where TStartup: class, IStartup
        {
            _services.AddSingleton<IStartup, TStartup>();
            return this;
        }

       public IApp Build()
        {
            return new App(_services);
        }

    }
}