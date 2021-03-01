using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_HandsOn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var v = Func1Async();
            Console.WriteLine(v.Result);
            Console.ReadLine();
        }

        public static async Task<string> Func1Async()
        {
            Console.WriteLine("Inside func1..waiting for func2");
            string res = await Func2();
            Console.WriteLine("\nfinishing func1..");
            return res;
        }

        public static async Task<string> Func2()
        {
            Console.WriteLine("\nStarting func2..");
            await Task.Delay(5000);
            Console.WriteLine("\nfinishing func2..");
            //Thread.Sleep(1000);
            return "\nText From inside func2";
        }
    }
}