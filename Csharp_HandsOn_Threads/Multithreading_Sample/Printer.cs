using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Sample
{
    public class Printer
    {
        private object lockToken = new object();

        public void PrintNumbers()
        {
            lock (lockToken)
            {
                Console.WriteLine($"-> {Thread.CurrentThread.ManagedThreadId} started @{DateTime.Now.ToLongTimeString() } is executing PrintNumbers");
                Console.WriteLine("Your Numbers:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i}, ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
    }
}