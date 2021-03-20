using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverImpl
{
    internal class MessagePublisher : ISubject
    {
        private List<IObserver> observers;
        private string state;

        public MessagePublisher()
        {
            observers = new List<IObserver>();
        }

        public void ChangeState(string s)
        {
            state = s;
            NotifyUpdate(new Message("state changed to " + s));
        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyUpdate(Message m)
        {
            foreach (var observer in observers)
            {
                observer.Update(m);
            }
        }
    }
}