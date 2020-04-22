using System;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        internal Dough dough;
        internal Sauce sauce;
        internal Veggies[] veggie;
        internal Cheese cheese;
        internal Pepporoni pepporoni;
        internal Clams clam;

        internal string Name { get; set; }

        protected abstract void Prepare();
        void Bake()
        {
            Console.WriteLine("Bake for 25 mins at 350");
        }
        void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }



    }
}