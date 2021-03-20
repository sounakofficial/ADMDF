using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeImpl
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}