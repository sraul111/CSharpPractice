using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract  class PizzaStore
    {
        public abstract Pizza Create(string typeofPizza);
    }
}
