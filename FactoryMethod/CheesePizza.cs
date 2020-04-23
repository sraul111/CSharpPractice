using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class CheesePizza:Pizza
    {
        private readonly PizzaIngredientFactory _ingredientFactory;

         public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
         public override void Prepare()
        {
            Console.WriteLine("Preparing" + Name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
        }
    }
}
