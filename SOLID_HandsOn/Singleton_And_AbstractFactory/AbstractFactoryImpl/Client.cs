using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl
{
    public class Client
    {
        private Headlight headlight;
        private Tire tire;

        public Client(Factory factory)
        {
            headlight = factory.makeHeadlight();
            tire = factory.makeTire();
        }

        public void GetHeadlightDetails()
        {
            Console.WriteLine(headlight.GetType());
        }

        public void GetTireDetails()
        {
            Console.WriteLine(tire.GetType());
        }
    }
}