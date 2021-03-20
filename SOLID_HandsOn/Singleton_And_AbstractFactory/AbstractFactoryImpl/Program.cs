using System;

namespace AbstractFactoryImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Mercedes");
            Factory mercedesFactory = new MercedesFactory();
            var client = new Client(mercedesFactory);
            client.GetHeadlightDetails();
            client.GetTireDetails();
            Console.WriteLine("\n");
            Console.WriteLine("Audi");
            Factory audiFactory = new AudiFactory();
            client = new Client(audiFactory);
            client.GetHeadlightDetails();
            client.GetTireDetails();
        }
    }
}