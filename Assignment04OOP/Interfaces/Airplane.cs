using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP.Interfaces
{
    internal class Airplane : Vehicle, IMovable , IFlyable
    {
        public void Backward()
        {
            Console.WriteLine("Airplane Move Backward");
        }
        void IMovable.Forward()
        {
            Console.WriteLine("Airplane Move Forward On Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane Move Forward On Air");
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
