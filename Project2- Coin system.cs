using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect2_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int Money;
            int Dollars;
            float Quarters;
            int Dimes;
            int Nickles;
            int Pennies;
            string line1;
        
            Console.Write("Insert Money: ");
            line1 = Console.ReadLine();
            Money = int.Parse(line1);
            Dollars = Money / 1;
            Quarters = Money * 4;
            Dimes = Money * 10;
            Nickles = Money * 20;
            Pennies = Money * 100;
            Console.Write("The number of dollar bills are: ");
            Console.Write(Dollars );
            Console.Write("The number of quarters are: ");
            Console.Write(Quarters );
            Console.Write("The number of dimes are: ");
            Console.Write(Dimes );
            Console.Write("The number of nickles are: ");
            Console.Write(Nickles );
            Console.Write("The number of pennies are: ");
            Console.Write(Pennies );

            Console.ReadKey();

            

        }
    }
}
