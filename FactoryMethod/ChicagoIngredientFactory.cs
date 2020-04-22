using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ChicagoIngredientFactory : PizzaIngredientFactory
    {
        public Clams CreateCalms()
        {
            return new FrozenClams();
        }

        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepporoni CreatePepporoni()
        {
            return new SlicedPepporoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[]{new Spinach(),new BlackOlive(),new EggPlant()};
        }
    }

   
}
