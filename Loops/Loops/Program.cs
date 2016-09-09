using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 12.32;
            double other = 45.35;
            Console.Write("The first number is {0} and the second number is {1}",num, other);


            int x = 0;
            while(x < 5)
            {
                Console.WriteLine("The counter is at {0}",x);
                x++;
            }

            Console.WriteLine("Please enter your name and it return.");
            string username = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Please do not leave blank!");

                username = Console.ReadLine();
            }

            Console.WriteLine("Hi {0}! Please enter a whole number: ", username);
            string numString = Console.ReadLine();

            int userNum;

            while (!int.TryParse(numString, out userNum)) {
                Console.WriteLine("You have not entered a proper number.\r\nPlease try again!");

                numString = Console.ReadLine();
            }

            //Always runs at least once
            int y = userNum;
            do
            {
                Console.WriteLine("The value of your number is now {0}",y);
                y--;
            } while (y >= 0);

            //for
            for(int count = 0; count < 5; count++){
                Console.WriteLine("The count is at {0}",count);
            }

            //foreach
            int totalSum = 0;
            int[] bills = new int[4] {150,90,85,500};
            foreach (int arrayBills in bills){
                Console.WriteLine("The price of one of my bills is ${0}",arrayBills);
            }

            foreach(int eachBill in bills)
            {
                totalSum += eachBill;
            }

            Console.WriteLine("The sum of my bills is ${0}",totalSum);

            //Breaks

            for (int counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine("The counter is at {0}", counter);
                if (counter == 7)
                {
                    Console.WriteLine("Stopping the loop");
                    break;
                }
            }
            //Continue
            for (int i = 0; i <= 50; i++)
            {
                
                if (i%2 != 0)
                {
                    Console.WriteLine("Skipping one...");
                    continue;
                }
                Console.WriteLine("The value of i is at {0}", i);
            }

            //Zombie Madness

            int zombies = 1;

            int bites = 4;

            int days = 8;

            for(int i = 1; i<=days; i++)
            {
                int newZombies = zombies * bites;
                zombies += newZombies;
                Console.WriteLine("There are {0} zombies on day {1}.", zombies, i);
            }

            int numDays = 1;

            int zombie = 1;
            while(zombie <= 1000000)
            {
                int newZombie = zombie * bites;
                zombie += newZombie;
                Console.WriteLine("The hoarde now contains {0} on day #{1}",zombie, numDays);
                numDays++;
            }
        }
    }
}
