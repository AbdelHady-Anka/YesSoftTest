using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    interface IDispatcher
    {
        void Dispatch(EvNum ev);
    }
}
