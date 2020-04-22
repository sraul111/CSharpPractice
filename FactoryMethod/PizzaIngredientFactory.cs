using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepporoni CreatePepporoni();
        public Clams CreateCalms();
    }
}
