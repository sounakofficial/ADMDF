using System.Text;

namespace ObserverPatternImpl
{
    public interface INotificationService
    {
        void Subscribe(IObserver o);

        void Unsubscribe(IObserver o);

        void Notify();
    }
}