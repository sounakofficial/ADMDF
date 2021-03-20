using System;

namespace AbstractFactoryImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ChannelFactory ecommerceFactory = new ECommerceFactory();
            ChannelFactory teleCallerFactory = new TeleCallerFactory();
            Client client;
            Order order;

            client = new Client(ecommerceFactory, ProductType.Electronic_Products);
            order = client.GetOrder();
            Console.WriteLine($"Order Details: channel - {order.channel}, product-type - {order.productType}");
            order.ProcessOrder();
            Console.WriteLine();

            client = new Client(ecommerceFactory, ProductType.Furniture);
            order = client.GetOrder();
            Console.WriteLine($"Order Details: channel - {order.channel}, product-type - {order.productType}");
            order.ProcessOrder();
            Console.WriteLine();

            client = new Client(ecommerceFactory, ProductType.Toys);
            order = client.GetOrder();
            Console.WriteLine($"Order Details: channel - {order.channel}, product-type - {order.productType}");
            order.ProcessOrder();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();

            client = new Client(teleCallerFactory, ProductType.Electronic_Products);
            order = client.GetOrder();
            Console.WriteLine($"Order Details: channel - {order.channel}, product-type - {order.productType}");
            order.ProcessOrder();
            Console.WriteLine();

            client = new Client(teleCallerFactory, ProductType.Furniture);
            order = client.GetOrder();
            Console.WriteLine($"Order Details: channel - {order.channel}, product-type - {order.productType}");
            order.ProcessOrder();
            Console.WriteLine();

            client = new Client(teleCallerFactory, ProductType.Toys);
            order = client.GetOrder();
            Console.WriteLine($"Order Details: channel - {order.channel}, product-type - {order.productType}");
            order.ProcessOrder();
            Console.WriteLine();
        }
    }
}