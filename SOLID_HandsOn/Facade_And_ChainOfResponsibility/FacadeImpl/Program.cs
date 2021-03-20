using System;

namespace FacadeImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}