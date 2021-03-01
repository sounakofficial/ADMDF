using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Only required params:");
            OrderDetail("seller1", "product1");

            Console.WriteLine("\n\nOnly required params:");
            OrderDetail("seller1", "product1", 5, false);

            Console.ReadLine();
        }

        public static void OrderDetail(string sellerName, string productName, int orderQuantity = 1, bool isReturnable = true)
        {
            Console.WriteLine($"Here is the order detail – {orderQuantity} number of {productName} by {sellerName} is ordered. It’s returnable status is {isReturnable}");
        }
    }
}