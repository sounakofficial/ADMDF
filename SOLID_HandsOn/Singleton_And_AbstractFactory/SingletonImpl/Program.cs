using System;

namespace SingletonImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var con = DBConn.getInstance();
            var con2 = DBConn.getInstance();

            Console.WriteLine(object.ReferenceEquals(con, con2));
        }
    }
}