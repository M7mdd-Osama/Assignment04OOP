using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Circle : ICircle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get;}
        public double Area => Math.PI * Radius * Radius;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius} , Area = {Area}") ;
        }
    }
}
