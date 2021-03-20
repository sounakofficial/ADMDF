using System;

namespace ObserverImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IObserver subscriber1 = new MessageSubscriberOne();
            IObserver subscriber2 = new MessageSubscriberTwo();
            IObserver subscriber3 = new MessageSubscriberThree();

            MessagePublisher publisher = new MessagePublisher();
            publisher.Attach(subscriber1);
            publisher.Attach(subscriber2);

            publisher.NotifyUpdate(new Message("First Broadcast"));
            publisher.Detach(subscriber1);
            publisher.Attach(subscriber3);
            Console.WriteLine();
            publisher.NotifyUpdate(new Message("Second Broadcast"));
            Console.WriteLine();
            publisher.ChangeState("inactive");
        }
    }
}