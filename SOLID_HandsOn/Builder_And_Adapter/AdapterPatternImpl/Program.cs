using System;

namespace AdapterPatternImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var car = new BugattiVeyron();

            Console.WriteLine($"Speed in MPH: {car.GetSpeed()}");
            Console.WriteLine($"Price in USD: {car.GetPrice()}");

            Console.WriteLine();

            var adapter = new MovableAdapterImpl(car);
            Console.WriteLine($"Speed in KPH: {adapter.GetSpeed()}");
            Console.WriteLine($"Price in euro: {adapter.GetPrice()}");
        }
    }
}