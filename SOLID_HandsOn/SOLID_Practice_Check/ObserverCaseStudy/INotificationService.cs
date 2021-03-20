using System;
using System.Text;

namespace ObserverCaseStudy
{
    internal interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);

        void RemoveSubscriber(INotificationObserver observer);

        void NotifySubscriber();
    }
}