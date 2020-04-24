using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;

namespace SingletonPattern
{
   public class ChocolateBoiler
   {
       private static ChocolateBoiler uniqueInstance;
       public static int count;
        private ChocolateBoiler()
        {
            Interlocked.Increment(ref count);
        }

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }

            return uniqueInstance;
        }

        public void Fill()
        {

        }

         ~ChocolateBoiler()
        {
            Interlocked.Decrement(ref count);
        }
    }
}
