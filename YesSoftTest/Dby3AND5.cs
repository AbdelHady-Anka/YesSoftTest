using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    class Dby3AND5 : IDivisable<Dby3AND5>
    {
        public void Divisable(EvNum ev)
        {
            if(ev.Num % 3 == 0 && ev.Num % 5 == 0)
            {
                Console.WriteLine("Hello World! (" + ev.Num + ")");
            }
        }
    }
}
