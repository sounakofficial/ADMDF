using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Sample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** MultiThreading Program *****");
            Console.WriteLine($"Main Thread started. ThreadID = {Thread.CurrentThread.ManagedThreadId} ");

            Printer p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintTheNumbers);
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All taskes queued");
            Console.ReadLine();
        }

        private static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }
    }
}