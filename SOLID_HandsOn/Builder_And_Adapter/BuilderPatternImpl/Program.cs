using System;

namespace BuilderPatternImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //adult package
            Console.WriteLine("Adult Package:");
            PackageBuilder packageBuilder = new AdultPackageBuilder();
            PackageCreator pc = new PackageCreator(packageBuilder);
            pc.CreatePackage();
            Package temp = pc.GetPackage();
            temp.GetInfo();

            Console.WriteLine();

            //child package
            Console.WriteLine("Child Package:");
            packageBuilder = new ChildPackageBuilder();
            pc = new PackageCreator(packageBuilder);
            pc.CreatePackage();
            temp = pc.GetPackage();
            temp.GetInfo();
        }
    }
}