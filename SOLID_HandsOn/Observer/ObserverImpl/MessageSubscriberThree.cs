using System;

namespace ObserverImpl
{
    internal class MessageSubscriberThree : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberThree: " + m.GetMessageContent());
        }
    }
}