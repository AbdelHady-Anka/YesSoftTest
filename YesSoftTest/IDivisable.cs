using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    public interface IDivisable<T> where T : IDivisable<T>
    {
        void Divisable(EvNum ev);
    }
}
