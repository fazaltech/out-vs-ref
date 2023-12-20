using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_vs_ref
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 20;
            var y = 20;
            var z = 20;

            Method(x);
            RefMethod(ref y);
            OutMethod(out z);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();


        }

      
        public static void Method(int value)
        {
            value = value + 10;

        }
        public static void RefMethod(ref int value)
        {
            value = value + 10;

        }

        public static void OutMethod(out int value)
        {
            value = 10;

        }

    }
}
