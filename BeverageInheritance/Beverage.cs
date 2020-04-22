using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BeverageInheritance
{
   public abstract class Beverage
    {
        public string description;

        public Beverage(string description)
        {
            this.description = description;
        }
        public void GetDescription()
        {
            Console.Write(description);
        }

        public virtual void Cost()
        {
            Console.WriteLine($"cost inside base");
        }
        // public abstract void Cost();
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend(string description):base(description)
        {

        }
        public void Cost()
        {
           // description = "household blend";
            Console.WriteLine($"cost of House Hold blend is Rs 2");
        }

        public new void GetDescription()
        {
            Console.WriteLine($"Get Description from House Hold blend ");
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast(string description):base(description)
        {

        }
        public override void Cost()
        {
           // description = "Dark Roast";
            Console.WriteLine($"cost of Dark Roast is rs 3");
        }
    }
}
