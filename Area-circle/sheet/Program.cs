using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int area = a * b ;
            int pirmeter = 2 * a * b;
            Console.WriteLine("the area of rectangle is : " + area);
            Console.WriteLine("the pirmeter is : " + pirmeter);
        }
    }
}
