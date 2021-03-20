using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverImpl
{
    internal interface IObserver
    {
        void Update(Message m);
    }
}