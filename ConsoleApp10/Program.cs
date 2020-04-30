using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st triangle side:");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd triangle side:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 3rd triangle side:");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] i =  { a, b, c };
            int maxvalue = i.Max(); 

            if (a == b && b== c && a==c)
                Console.WriteLine("Triange is равносторонний");
            else if (a == b || b == c || a == c)
            { 
                Console.WriteLine("Triange is равнобедренный");
            }
            else if ( maxvalue ==a && ) 
        }
    }
}
