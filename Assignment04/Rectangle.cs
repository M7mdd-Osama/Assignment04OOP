using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Rectangle : IRectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Width { get; }
        public double Height { get; }

        public double Area => Width * Height;

        

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width} , Height = {Height} , Area = {Area}");
        }

    }
}
