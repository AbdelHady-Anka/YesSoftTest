using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace YesSoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            App.CreateAppBuilder()
                .UseStartup<Startup>()
                .Build().Run();
        }
    }
}
