using System.Collections.Generic;

namespace ObserverCaseStudy
{
    class NotificationService : INotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifySubscriber()
        {
            foreach (var observer in observers)
            {
                observer.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
