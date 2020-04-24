using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
   public abstract class Beverage
   {
       protected string something;

        public abstract double Cost();
        public abstract string GetDescription();

   }
}
