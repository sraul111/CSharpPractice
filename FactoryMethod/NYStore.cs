using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FactoryMethod
{
    public class NYStore : PizzaStore
    {
        public override Pizza Create(string typeofPizza)
        {
            Pizza pizza;
            PizzaIngredientFactory ingredientFactory = new NewYorkIngredientFactory();
            switch (typeofPizza.ToLower())
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                   // pizza.Name = "NewYork style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "NewYork style Clam Pizza";
                    break;
                default:
                    pizza = new NoPizza();
                    pizza.Name = "We don't make this Pizza";
                    break;
            }

            return pizza;
        }
    }
}
