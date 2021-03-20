using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeImpl
{
    internal class ShapeMaker
    {
        private IShape _circle;
        private IShape _square;
        private IShape _rectangle;

        public ShapeMaker()
        {
            _circle = new Circle();
            _square = new Square();
            _rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }
    }
}