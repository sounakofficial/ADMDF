using System;

namespace ObserverImpl
{
    internal class MessageSubscriberTwo : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo: " + m.GetMessageContent());
        }
    }
}