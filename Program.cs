using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_without_3rd_var
{
    class Program
    {
        static void Main(string[] args)
        {

            string  r = "rahul";
        int x = 10, y = 5;

            Console.WriteLine("program to swap two number without using third variable");
        x = x* y; 
        y = x / y; 
    x = x / y; 
            Console.WriteLine("after swapping{0},{1}", x, y);
            Console.ReadKey();
}
}
}
