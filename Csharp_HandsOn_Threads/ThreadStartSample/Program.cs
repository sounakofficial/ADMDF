using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_HandsOn_Threads
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            //Console.ReadLine();

            Console.WriteLine("***** THreadStart Delegate App *****");
            Console.WriteLine("Do you want [1] or [2] threads?");
            string threadCount = Console.ReadLine();

            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing main");

            Printer p = new Printer();

            switch (threadCount)
            {
                case "2":
                    {
                        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                        backgroundThread.Name = "Secondary";
                        backgroundThread.Start();
                        break;
                    }
                case "1":
                    {
                        p.PrintNumbers();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I dont know what you want..you get 1 thread");
                        goto case "1";
                    }
            }

            Console.WriteLine("Hello this is from main");
            Console.ReadLine();
        }
    }
}