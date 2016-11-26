using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float Number1;
            float Division;
            float Remainder;
            string line;

            Console.Write("Insert number: ");
            line = Console.ReadLine();
            Number1 = float.Parse(line);
            Division = Number1 / 2;
            Remainder = Number1 % 2;
           
            if (Remainder > 0)
            {
                Console.Write("Is an odd number");
            }
            else
            {
                Console.Write("Is a even number");
            }          
            Console.ReadKey();


             
        }
    }
}
