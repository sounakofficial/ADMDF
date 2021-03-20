using System;

namespace ObserverPatternImpl
{
    public class Observer : IObserver
    {
        public string Name;

        public Observer(string name)
        {
            Name = name;
        }

        public void Notification()
        {
            Console.WriteLine(Name + " notification: 100 tickets booked!!");
        }
    }
}