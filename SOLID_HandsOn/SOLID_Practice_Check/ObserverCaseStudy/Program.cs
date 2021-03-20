using System;

namespace ObserverCaseStudy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            INotificationService notificationService = new NotificationService();
            INotificationObserver john = new JohnObserver();
            INotificationObserver steve = new SteveObserver();
            notificationService.AddSubscriber(john);
            notificationService.AddSubscriber(steve);

            notificationService.NotifySubscriber();
            Console.WriteLine();
            notificationService.RemoveSubscriber(john);
            notificationService.NotifySubscriber();
        }
    }
}