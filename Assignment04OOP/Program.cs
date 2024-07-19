using Assignment04OOP.ICloneable_Interface;
using Assignment04OOP.Interfaces;
using System.Text;

namespace Assignment04OOP
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($" {series.Current} ");
                    series.GetNext();
                }
                series.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface
            //IMyType myType;
            //MyType myType1 = new MyType();
            //myType1 = new MyType();

            //IMyType myType = new MyType();
            //myType.Id = 3;
            //myType.Print();
            //myType.MyFun(10); 
            #endregion
            #region Ex01
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            //Console.WriteLine("\n ==================");
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);
            #endregion
            #region Ex02 
            //Car car = new Car();
            //car.Backward();
            //car.Forward();
            //Airplane airplane = new Airplane();

            //IFlyable airplane2 = new Airplane();
            //airplane2.Forward();
            #endregion

            #region Shallow & Deep Copy
            #region Array Of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];
            #region Shallow Copy [Stack] On References

            //Arr02 = Arr01;
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            #endregion

            #region Deep Copy [Heap] Clone()
            //Arr02 = (int[])Arr01.Clone();

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            #endregion
            #endregion

            #region  Array Of Reference Type
            #region Array Of String [Immutable Type]
            //string[] Name01 = { "Mohamed" };
            //string[] Name02 = new string[1];
            #region Shallow Copy
            //Name02 = Name01;
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion
            #region Deep Copy
            //Name02 = (string[])Name01.Clone();
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            //Name02[0] = "Ahmed";
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            #endregion
            #endregion
            #region Array Of StringBuilder [Mutable Type]
            //StringBuilder[] Name01 = new StringBuilder[1];
            //Name01[0] = new StringBuilder("Mohamed");
            //StringBuilder[] Name02 = new StringBuilder[1];
            #region Shallow Copy [Stack]
            //Name02 = Name01;
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]); 
            #endregion
            #region Deep Copy [Heap]
            //Name02 = (StringBuilder[])Name01.Clone();
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());
            //Name01[0].Append(" Osama");
            //Console.WriteLine(Name02[0]);
            //Console.WriteLine(Name01[0]);

            #endregion

            #endregion
            #endregion

            #endregion

            #region Shallow Copy and Deep Copy For UserDefiend Datatype
            //Employee employee01 = new Employee()
            //{
            //    Id = 20,
            //    Name = new StringBuilder("Mohamed"),
            //    Salary = 5000
            //};
            //Employee employee02 = new Employee()
            //{
            //    Id = 30,
            //    Name = new StringBuilder("Ali"),
            //    Salary = 7000
            //};
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);

            //employee01 = (Employee) employee02.Clone();
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02);

            //employee02 = new Employee(employee01);
            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee01);
            //Console.WriteLine(employee02.GetHashCode());
            //Console.WriteLine(employee02); 
            #endregion

            #region Built In Interface ICompareable
            //Employee[] employees = new Employee[4]
            //{
            //    new Employee() {Id = 10 , Name = "Mohamed" , Salary = 4000},
            //    new Employee() {Id = 20 , Name = "Omar" , Salary = 3000},
            //    new Employee() {Id = 30 , Name = "Mahmoud" , Salary = 2000},
            //    new Employee() {Id = 40 , Name = "Ahmed" , Salary = 8000}
            //};
            //Array.Sort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            //Console.WriteLine(employees[1].CompareTo(employees[2])); 
            #endregion


        }

    }
}
