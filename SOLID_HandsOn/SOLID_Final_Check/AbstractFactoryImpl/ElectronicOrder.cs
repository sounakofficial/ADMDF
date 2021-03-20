using System;

namespace AbstractFactoryImpl
{
    public class ElectronicOrder : Order
    {
        public override void ProcessOrder()
        {
            Console.WriteLine("Processing Electronic Order");
        }
    }
}