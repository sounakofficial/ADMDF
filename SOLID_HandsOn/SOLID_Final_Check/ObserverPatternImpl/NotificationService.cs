using System.Collections.Generic;

namespace ObserverPatternImpl
{
    public class NotificationService : INotificationService
    {
        private List<IObserver> observers = new List<IObserver>();
        private int BookedTicket = 0;

        public void BookTicket(int num)
        {
            BookedTicket += num;
            if (BookedTicket >= 100)
            {
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Notification();
            }
        }

        public void Subscribe(IObserver o)
        {
            observers.Add(o);
        }

        public void Unsubscribe(IObserver o)
        {
            observers.Remove(o);
        }
    }
}