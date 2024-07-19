using Assignment04OOP.Interfaces;

namespace Assignment04OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMyType myType;
            //MyType myType1 = new MyType();
            //myType1 = new MyType();
            
            IMyType myType = new MyType();
            myType.Id = 3;
            myType.Print();
            myType.MyFun(10);
        }
    }
}
