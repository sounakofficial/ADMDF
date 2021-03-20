using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeImpl
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}