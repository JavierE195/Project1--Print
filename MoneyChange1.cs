using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange2
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyIn;
            int hundreds;
            int hundredsReminder;
            int twenties;
            int twentiesReminder;
            int tens;
            int tensReminder;
            int fives;
            int fivesReminder;
            int centsIn;
            int quarters;
            int quartersReminder;
            int dimes;
            int dimesReminder;
            int nickles;
            int nicklesReminder;
            string line1;
            string line2;

            Console.Write("Insert money amount in dollars: ");
            line1 = Console.ReadLine();
            Console.Write("Insert amount in cents: ");
            line2 = Console.ReadLine();

            moneyIn = int.Parse(line1);
            hundreds = moneyIn / 100;
            hundredsReminder = moneyIn % 100;
            Console.Write("\n Number of Hundred bills: {0}", hundreds);

            twenties = hundredsReminder / 20;
            twentiesReminder = hundredsReminder % 20;
            Console.Write("\n Number of Twenty bills: {0}", twenties);

            tens = twentiesReminder / 10;
            tensReminder = twentiesReminder % 10;
            Console.Write("\n Number of Ten bills: {0}", tens);

            fives = tensReminder / 5;
            fivesReminder = tensReminder % 5;
            Console.Write("\n Number of Five bills: {0}", fives);
            Console.Write("\n Number of One bills: {0}", fivesReminder);

            centsIn = int.Parse(line2);
            quarters = centsIn / 25;
            quartersReminder = centsIn % 25;
            Console.Write("\n Number of Quarters: {0}", quarters);

            dimes = quartersReminder / 10;
            dimesReminder = quartersReminder % 10;
            Console.Write("\n Number of Dimes: {0}", dimes);

            nickles = dimesReminder / 5;
            nicklesReminder = dimesReminder % 5;
            Console.Write("\n Number of Nickles: {0}", nickles);
            Console.Write("\n Number of Pennies: {0}", nicklesReminder);


            Console.ReadKey();

           




        
           





        }
    }
}
