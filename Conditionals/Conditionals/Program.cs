using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Alexandria Strawter
             Section 01
             Conditionals
             August 31, 2016
             */

            //Boolean Variables
            bool testing = true;
            bool nope = false;

            Console.WriteLine(testing);
            Console.WriteLine(nope);

            //Relational Operators
            Console.WriteLine(5 < 7);
            Console.WriteLine(7 > 5);

            Console.WriteLine(2 > 5);

            Console.WriteLine(5 <= 5);

            Console.WriteLine(6 < 6);

            Console.WriteLine(6 == 6);

            Console.WriteLine(5 != 4);

            //Conditionals
            //if else statement
            if (true)
            {
                Console.WriteLine("this line will run");
            }


            if (false)
            {
                Console.WriteLine("Will not run");
            }else
            {
                Console.WriteLine("if was false so else should run");
            }


            if (5 < 8)
            {
                Console.WriteLine("Five is less than 8");
            }

            //else if
            int kid = 7;
            if (kid >= 13)
            {
                Console.WriteLine("You can go to the movie");
            }
            else if (kid >=10)
            {
                Console.WriteLine("The child can go with an adult");
            }
            else
            {
                Console.WriteLine("Child can't go to this movie");
            }

            //Simple conditional example
            decimal basePay= 200.00m;
            decimal bonus = 50.00m;
            decimal total = 0;

            int shoes = 55;

            if(shoes >= 50)
            {
                total = basePay + bonus;
                Console.WriteLine(total);
            }else
            {
                total = basePay;
                Console.WriteLine(total);
            }

            //Steak Temp
            /*
             Rare 130-140
             Medium Rare 140-145
             Medium 145-160
             Well Done 160-170
             */

            Console.WriteLine("What is the temperature of your steak in degree F?\r\nHit return when finished.");
            string stringTemp = Console.ReadLine();
            int temp = int.Parse(stringTemp);

            if (temp < 130) {
                Console.WriteLine("Your steak is still raw!\r\nCook it a bit longer.");
            }else if (temp < 140)
            {
                Console.WriteLine("Your steak is Rare!");

            }
            else if (temp < 145) {
                Console.WriteLine("Your steak is Medium Rare!");
            }
            else if (temp < 160)
            {
                Console.WriteLine("Your steak is Medium!");
            }
            else if(temp < 170)
            {
                Console.WriteLine("Your steak is Well done!");
            }
            else
            {
                    Console.WriteLine("Your steak is Overcooked!");
            }

            //Logical Operators

        }
    }
}
