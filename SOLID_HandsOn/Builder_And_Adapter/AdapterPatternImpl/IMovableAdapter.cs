using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternImpl
{
    public interface IMovableAdapter
    {
        double GetSpeed();

        double GetPrice();
    }
}