using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternImpl
{
    public class Package
    {
        public int sweets { get; set; }
        public int savory { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"This Package Contains Sweets: {sweets}, Savory: {savory}.");
        }
    }
}