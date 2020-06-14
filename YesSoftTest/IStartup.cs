using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    public interface IStartup
    {
        void Configure(IServiceCollection services);
        void Run(IServiceCollection services);
    }
}
