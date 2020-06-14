using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    class Dby5 : IDivisable<Dby5>
    {
        public void Divisable(EvNum ev)
        {
            if(ev.Num % 5 == 0)
            {
                Console.WriteLine("World (" + ev.Num + ")");
            }
        }
    }
}
