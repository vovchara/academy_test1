using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    class GenerMeth
    {
        public void Main()
        {
            int x = 7;
            int y = 25;
            Swap(ref x, ref y); // или так Swap(ref x, ref y);
            Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

            string s1 = "hello";
            string s2 = "bye";
            Swap(ref s1, ref s2); // или так Swap(ref s1, ref s2);
            Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello

            var www = Foo<string>();
            Console.WriteLine(www);

            var qqq = Foo<int>();
            Console.WriteLine(qqq);

            var eee = Foo<Account<int, int>>();
            Console.WriteLine(eee.ToString());
        }

        private void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        private T Foo<T>()
        {
            return default(T);
        }

        //private void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //private void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}

        //private void Swap(ref Account<int, int> x, ref Account<int, int> y)
        //{
        //    Account<int, int> temp = x;
        //    x = y;
        //    y = temp;
        //}
    }
}
