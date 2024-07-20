using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP.Interfaces
{
    interface IMyType
    {
        public int Id { get; set; }

        public void MyFun(int X);

        public void Print()
        {
            Console.WriteLine("Hello Default Implemented Method From Interface");
        }
    }
}
