﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP.Interfaces
{
    internal class Car : Vehicle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("Airplane Move Backward");
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
