using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal interface IRectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }
    }
}
