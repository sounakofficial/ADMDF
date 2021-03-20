using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeImpl
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}