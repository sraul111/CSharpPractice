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
            Base b = new Derieved("s","r");
            b.Method1Base();
          //b.Method1Derieved();  will give compile errors
            
            Derieved d = new Derieved("s","r");
            d.Method1Derieved();
            d.Method1Base(); 
            Console.ReadKey();

        }
    }

    public class Base
    {
        private readonly string _variable2;
        private readonly string _variable1;

        public Base(string variable1,string variable2)
        {
            _variable1 = variable1;
            _variable2 = variable2;
        }
        public void Method1Base()
        {
            Console.WriteLine($"Method1Base from Base");
        }
        public void Method2Base()
        {
            Console.WriteLine($"Method2Base from Base");
        }
    }

    public class Derieved : Base
    {
        private readonly string _variable1;
        private readonly string _variable2;

        public void Method1Derieved()
        {
            Console.WriteLine($"Method1Derieved from Derieved");
        }
        public void Method2Derieved()
        {
            Console.WriteLine($"Method2Derieved from Derieved");
        }

        public Derieved(string variable1, string variable2) : base(variable1, variable2)
        {
            _variable1 = variable1;
            _variable2 = variable2;
        }
    }
}
