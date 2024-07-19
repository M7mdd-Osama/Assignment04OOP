using Assignment04OOP.Interfaces;

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

        }
    }
}
