using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverImpl
{
    internal class MessageSubscriberOne : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne: " + m.GetMessageContent());
        }
    }
}