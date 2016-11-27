using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            float Number1;
            float Number2;
            string line1;
            string line2;

            Console.Write("Insert the first number:  ");
            line1 = Console.ReadLine();
            Number1 = float.Parse(line1);

            Console.Write("Insert the second number:  ");
            line2 = Console.ReadLine();
            Number2 = float.Parse(line2);

            if (Number1 != Number2)
            {
                if (Number1 < Number2)
                {
                    Console.Write("The second number is greater");
                }
                else
                {
                    Console.Write("The first number is greater");
                }
            }
            else
            {
                Console.Write("The numbers are equal");
            }

            Console.ReadKey();

        }
    }
}
