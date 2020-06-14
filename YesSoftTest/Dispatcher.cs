using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace YesSoftTest
{
    class Dispatcher : IDispatcher
    {
        private readonly IServiceProvider _provider;

        public Dispatcher(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void Dispatch(EvNum ev)
        {
            Type divisableInterface = typeof(IDivisable<>);
            List<Type> dTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsDivisableInterface())).ToList();


            foreach (var dType in dTypes)
            {
                Type type = typeof(IDivisable<>);
                Type iDType = type.MakeGenericType(dType);

                dynamic nextD = _provider.GetService(iDType);
                nextD.Divisable((dynamic)ev);
            }

        }
    }
}
