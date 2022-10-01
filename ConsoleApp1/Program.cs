using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Dodge Charger";
            myCar.Year = 2013;
            myCar.Make = "R/T Plus";
        }
    }
}
