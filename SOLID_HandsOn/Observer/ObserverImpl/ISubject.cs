using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverImpl
{
    internal interface ISubject
    {
        void Attach(IObserver o);

        void Detach(IObserver o);

        void NotifyUpdate(Message m);
    }
}