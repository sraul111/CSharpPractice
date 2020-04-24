using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondinementsDecorator
    {
        private readonly  Beverage beverage;

        public Mocha(Beverage beverage):base(beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
           return beverage.Cost() + .20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
