using System;

namespace BeverageInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            Beverage b = new HouseBlend("house blend");
             b.Cost();
            b.GetDescription();
        }
    }
}
