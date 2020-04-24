using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern;
using NUnit.Framework;

namespace CommonTestProjectNUnit
{
    class DecoratorPatternTest
    {
        [Test]
        public void StarbuzzCafe()
        {
            //Beverage beverage = new Americano();
            //Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            //beverage = new Mocha(beverage);
            //Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage1 = new Americano();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            //beverage1 = new DarkRoast();
            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());
        }
    }
}
