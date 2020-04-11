using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derieved();
            b.Method1();
            Derieved d = new Derieved();
            d.Method1();
            Console.ReadKey();

        }
    }

    public class Base
    {
        public void Method1()
        {
            Console.WriteLine($"Method1 from Base");
        }
    }

    public class Derieved : Base
    {
        public void Method1()
        {
            Console.WriteLine($"Method1 from Derieved");
        }
    }
}
