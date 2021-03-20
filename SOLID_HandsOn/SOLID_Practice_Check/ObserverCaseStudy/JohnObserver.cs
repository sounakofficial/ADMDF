using System;

namespace ObserverCaseStudy
{
    internal class JohnObserver : INotificationObserver
    {
        public int Name { get => Name; set => Name = value; }

        public void OnServerDown()
        {
            Console.WriteLine("John server down..");
        }
    }
}