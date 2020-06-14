using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    class Dby3 : IDivisable<Dby3>
    {
        private readonly IDispatcher _dispatcher;

        public Dby3(IDispatcher dispatcher)
        {
            this._dispatcher = dispatcher;
        }

        public void Divisable(EvNum ev)
        {
            if(ev.Num % 3 == 0)
            {
                Console.WriteLine("Hello (" + ev.Num + ")");
            }
        }
    }
}
