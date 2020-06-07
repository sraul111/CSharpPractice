using System;
using System.Linq;

namespace NonRepeatingCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            var result = obj.GetAllNonRepeatingCharacterInString();
            Console.WriteLine(result);
        }

        public string GetAllNonRepeatingCharacterInString()
        {
            string givenString = "rtrryuup";
            string resultantString = string.Empty;
           //char[] charcontainer = new char[givenString.Length];
           //int i = 0;
           // foreach(char c in givenString)
           // {
           //   if(!charcontainer.Contains(c)){
           //   charcontainer[i] =c;
           //     i++;
           //   }

           // }

           // resultantString = new string(charcontainer);


           var result = givenString
               .GroupBy(c => c)
               .Where(g => g.Count() == 1)
               .Select(g => g.Key);


           resultantString = String.Concat(result);

            return resultantString;

        }
    }
}
