using System.Collections.Generic;
using System.Text;

namespace ObserverCaseStudy
{
    internal interface INotificationObserver
    {
        public int Name { get; set; }

        void OnServerDown();
    }
}