using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class NewYorkIngredientFactory : PizzaIngredientFactory
    {
        public Clams CreateCalms()
        {
            return new FreshClams();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepporoni CreatePepporoni()
        {
            return new SlicedPepporoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
