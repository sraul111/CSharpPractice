using System.Threading;

namespace SingletonPattern
{
    public class ChocolateBoilerEarlyInstance
    {
        private static ChocolateBoilerEarlyInstance uniqueInstance = new ChocolateBoilerEarlyInstance();
        public static int count;
        private ChocolateBoilerEarlyInstance()
        {
            Interlocked.Increment(ref count);
        }

        public static ChocolateBoilerEarlyInstance GetInstance()
        {
            return uniqueInstance;
        }

        ~ChocolateBoilerEarlyInstance()
         {
             Interlocked.Decrement(ref count);

         }


    }
}
