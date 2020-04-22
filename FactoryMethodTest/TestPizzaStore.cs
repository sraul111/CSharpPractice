using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod;
using NUnit;
using NUnit.Framework;

namespace FactoryMethodTest
{
    [TestFixture]
    public class TestPizzaStore
    {
        [Test]
        public void Test1()
        {
            PizzaStore nystore = new NYStore();
            var expectedPizzaObject =nystore.Create("Cheese");
            PizzaIngredientFactory ingredientFactory = new NewYorkIngredientFactory();
            var actualPizzaObject = new CheesePizza(ingredientFactory);
        }
    }
}
