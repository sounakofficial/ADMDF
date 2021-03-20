using System;

namespace AbstractFactoryImpl
{
    public class ToysOrder : Order
    {
        public override void ProcessOrder()
        {
            Console.WriteLine("Processing Toys Order");
        }
    }
}