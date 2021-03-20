using System;

namespace ObserverCaseStudy
{
    internal class SteveObserver : INotificationObserver
    {
        public int Name { get => Name; set => Name = value; }

        public void OnServerDown()
        {
            Console.WriteLine("Steve server down...");
        }
    }
}