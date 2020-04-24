using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Americano : Beverage
    {
        
        public override double Cost()
        {
            return 3.00;
        }

        public override string GetDescription()
        {
            return "Real Americano";
        }
    }
}
