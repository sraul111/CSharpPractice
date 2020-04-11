using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
       //program can't declare overload the 2 methods  which differs only on parameters modifier
        //public void Method1(ref int x) { }
        //public void Method1(out int x) { x=2; }

        //methods are not overloaded because their return type differs
        //public string Method2(int x) { return "s"; }
        //public int Method2(int x) { return  1;}

        static void Main(string[] args)
        {
            //the difference between Convert.ToInt32 and Int32.Parse is that Int32.TryParse don't handle 
            //null argument and throws ArgumentNull Exception.
            string s = null;
            Console.WriteLine(Convert.ToInt32(s));
            Console.WriteLine(Int32.Parse(s));
            Console.ReadKey();
        }
    }
}
