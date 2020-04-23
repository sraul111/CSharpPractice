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
            expectedPizzaObject.Prepare();
            expectedPizzaObject.Bake();
            var dough = expectedPizzaObject.dough;
            Assert.That(dough,Is.InstanceOf<Dough>());
            Assert.That(dough,Is.InstanceOf<ThinCrustDough>());
        }
    }
}
