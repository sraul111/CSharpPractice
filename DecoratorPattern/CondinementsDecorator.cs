using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class CondinementsDecorator : Beverage
    {
        private readonly Beverage beverage;

        public CondinementsDecorator(Beverage beverage)
        {
           this.beverage = beverage;
        } 

        public override double Cost()
        {
            if (beverage != null)
            {
                return beverage.Cost();
            }

            return 0.00;
        }

        public override string GetDescription()
        {
            if (beverage != null)
            {
                return beverage.GetDescription();
            }

            return "Unknown Beverage";
        }
    }
}
