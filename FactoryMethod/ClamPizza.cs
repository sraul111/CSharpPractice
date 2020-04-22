using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ClamPizza : Pizza
    {
        private readonly PizzaIngredientFactory _ingredientFactory;

        internal ClamPizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            _ingredientFactory = pizzaIngredientFactory;
        }
        protected override void Prepare()
        {
            Console.WriteLine("Preparing" + Name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            clam = _ingredientFactory.CreateCalms();
        }

    }
}
