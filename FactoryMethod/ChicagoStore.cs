using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ChicagoStore : PizzaStore
    {
        public override Pizza Create(string typeofPizza)
        {
            Pizza pizza;
            PizzaIngredientFactory ingredientFactory = new ChicagoIngredientFactory();

            switch (typeofPizza.ToLower())
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago style Clam Pizza";
                    break;
                default :
                    pizza = new NoPizza();
                    pizza.Name = "We don't make this Pizza.";
                    break;
            }

            return pizza;
        }
    }
}