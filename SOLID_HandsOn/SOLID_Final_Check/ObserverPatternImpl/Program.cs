using System;

namespace ObserverPatternImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var notificationService = new NotificationService();
            IObserver admin1 = new Observer("admin1");
            IObserver admin2 = new Observer("admin2");
            IObserver admin3 = new Observer("admin3");

            notificationService.Subscribe(admin1);
            notificationService.Subscribe(admin2);
            notificationService.BookTicket(99);

            Console.WriteLine();
            notificationService.Unsubscribe(admin1);
            notificationService.Subscribe(admin3);
            notificationService.BookTicket(1);
        }
    }
}