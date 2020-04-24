using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SteamedMilk : CondinementsDecorator
    {
        private readonly Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double Cost()
        {
            return _beverage.Cost() + .50;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Steamed Milk";
        }
    }
}
