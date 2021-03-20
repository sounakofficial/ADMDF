using System;

namespace AbstractFactoryImpl
{
    public class FurnitureOrder : Order
    {
        public override void ProcessOrder()
        {
            Console.WriteLine("Processing Furniture Order");
        }
    }
}