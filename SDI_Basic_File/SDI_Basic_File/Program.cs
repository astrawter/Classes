using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI_Basic_File
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alexandria Strawter
              Section 01
              Commenting and Console     
              8/31/2016  
             */
            Console.WriteLine("Hello World");
            Console.Write("This is just a write.");
            Console.Write("This is just a write.\r\n");

            /*Alexandria Strawter
              Section 01
              Variables and Characters    
              8/31/2016  
             */

            //char are onlu ONE character long and must be surronded by single quotes 'x'
            //Declare a variable
            char firstLetter;

            //Define a variable
            firstLetter = 'A';

            //Print the variable toconsole
            Console.WriteLine(firstLetter);

            //Declare and Define
            char secondLetter = 'b';
            Console.WriteLine(secondLetter);

            //String is more than one character and must use double quotes "x"
            string wholeSentence = "Why do I have to repeat this class";

            Console.WriteLine(wholeSentence);

            /*Alexandria Strawter
             Section 01
             Numeric Integral Datatypes  
             8/31/2016  
            */

            //Numeric Data Types

            //sbyte - signed byte  positive or negative
            sbyte exSbyte = 50;
            Console.WriteLine(exSbyte);

            //short
            short exShort = 1000;
            Console.WriteLine(exShort);

            //integer
            int exInt = 6000000;
            Console.WriteLine(exInt);

            //long
            long exLong = 451232454784632;
            Console.WriteLine(exLong);

            /*Alexandria Strawter
            Section 01
            Numeric Decimal Datatypes  
            8/31/2016  
           */

            //float decimal numbers up to 7 places
            //Use suffix of f or F
            float exFloat = 13.3456f;
            Console.WriteLine(exFloat);

            //double decimal numbers up to 15
            double exDouble = 12.3456;
            Console.WriteLine(exDouble);

            //decimal more precision and smaller range for money or financial calculations
            //Use suffix of m or M
            decimal exDecimal = 16.54m;
            Console.WriteLine(exDecimal);

            /*Alexandria Strawter
             Section 01
             Unsigned vs Signed Number Datatypes
             8/31/2016  
            */

            //unsigned is only positive values

            //byte 0-255
            byte exByte = 214;
            Console.WriteLine(exByte);

            //ushort positive 0 to 65635
            ushort exUshort = 45024;
            Console.WriteLine(exUshort);

            //uint
            uint exUint = 4563678;
            Console.WriteLine(exUint);

            //ulong
            ulong exUlong = 54785653328;
            Console.WriteLine(exUlong);
            //short -32,768 to 32,767


            /*Alexandria Strawter
            Section 01
            Arrays
            8/31/2016  
           */

            int[] arrayName = new int[2];
            arrayName[0] = 12;
            arrayName[1] = 25;

            string[] fruits = new string[4];
            fruits[0] = "apple";
            fruits[1] = "banana";
            fruits[2] = "grapes";
            fruits[3] = "pears";

            Console.WriteLine(fruits[2]);

            fruits[2] = "strawberry";
            Console.WriteLine(fruits[2]);

            int[] bills = new int[2];
            bills[0] = 123;
            bills[1] = 234;
            int total = bills[0] + bills[1];
            Console.WriteLine("My total amount for bills is $" + total);

            //dataype[] arrayname = new datatype[] {"enter", "values", "here"};
            string[] names = new string[] { "Lexi", "Zaria", "Roxy", "Liz" };
             
            Console.WriteLine("Hi my name is "+ names[0]);

            Console.WriteLine("MY daughters name is " + names[1]);

            Console.WriteLine("I have "+ names.Length +" items in my array!");

            /*Alexandria Strawter
              Section 01
              Basic Expressions
              8/31/2016  
             */

            int a = 2;
            //adds one and changes value of a 
            a++;
            //adds 3 and changes value of a
            a+= 3;
           
            Console.WriteLine(a);
            Console.WriteLine(a + 3);

            //Expression to find age
            int currentYear = 2016;

            //year you were born
            int yearBorn = 1993;

            int age = currentYear - yearBorn - 1;
            Console.WriteLine("My current age is " + age);

            Console.WriteLine(5 % 2);

            /*Alexandria Strawter
              Section 01
              Using Modulo
              8/31/2016  
             */

            decimal normal = 36 / 10m;
            Console.WriteLine(normal);

            int modulo = 36 % 10;
            Console.WriteLine(modulo);

            int eveOrOdd = 31 % 2;
            Console.WriteLine(eveOrOdd);


            /*Alexandria Strawter
             Section 01
             Order of Operations
             8/31/2016  
            */

            //PEMDAS
            //find the average of four quizzes
            double[] average = new double[] {85, 100, 80, 90};
            double sum = (average[0] + average[1] + average[2] + average[3]) / 4;
            Console.WriteLine("The average of the "+average.Length+" quizzes are " + sum);

            //Find the perimeter
            int length = 8;
            int width = 6;
            int perimeter = 2 * length + 2 * width;
            Console.WriteLine(perimeter);

            /*Alexandria Strawter
              Section 01
              Assignment Operators
              8/31/2016  
             */

            // = means is ex: apple = red;

            // ++ adds 1tp the value ex: a++ is the same as a = a + 1;

            int b = 3;
            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);

            // -- subtracts 1 from the value

            int c = 4;
            Console.WriteLine(c);
            c--;
            Console.WriteLine(c);

            // += adds and then changes the value of the variable

            c += 4;
            Console.WriteLine(c);

            c -= 2;
            Console.WriteLine(c);

            c *= 2;
            Console.WriteLine(c);

            c /= 2;
            Console.WriteLine(c);

            /*Alexandria Strawter
              Section 01
              Implicit & Explicit Conversions
              8/31/2016  
             */

            short num = 23456;
            Console.WriteLine(num);

            //convert implicitly
            int bignum = num;
            Console.WriteLine(bignum);

            //explicit conversion large to small
            double x = 1234.56;
            Console.WriteLine(x);

            //convert to int
            int xConverted = (int)x;
            Console.WriteLine(xConverted);

            //convert to sbyte
            int z = 130;
            Console.WriteLine(z);

            sbyte zConverted = (sbyte)z;
            Console.WriteLine(zConverted);

            /*Alexandria Strawter
              Section 01
              Conversion Helper Classes
              8/31/2016  
             */

            //Convert class
            string stringValue = "56";
            Console.WriteLine(stringValue);
            int multiplied = Convert.ToInt32(stringValue);
            multiplied *= 2;
            Console.WriteLine(multiplied);

            //Parse : Converts string version into a different data type
            string gonnaParse = "156000";

            int salary = int.Parse(gonnaParse);
            Console.WriteLine("My current salary is $" + salary);

            Console.WriteLine("My quarterly salary is $"+ salary / 4);

            /*Alexandria Strawter
              Section 01
              Prompting The User 
              8/31/2016  
             */

            //Ask user question then listen for the response
            Console.WriteLine("Please type in your name and press enter");

            //now listen and create variable to get the user answer
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName);

            //Calculate perimeter of  a rectrangle
            Console.WriteLine("We will be finding the perimeter of a rectangle! \r\nEnter a width and hit return:");
            string widthString = Console.ReadLine();
            double newWidth = double.Parse(widthString);
            Console.WriteLine("Enter a length and hit return:");
            string lengthString = Console.ReadLine();
            double newLength = double.Parse(lengthString);
            double perimeterUser = 2 * newLength + 2 * newWidth;
            Console.WriteLine("The perimeter is " + perimeterUser);


        }
    }
}
