using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04OOP.ICloneable_Interface
{
    internal class Employee : ICloneable
    {
        public Employee(Employee employee) //Copy ctor
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        public Employee()
        {
            
        }
        public int Id { get; set; }
        public StringBuilder? Name { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee(this);
            
        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }
    }
}
