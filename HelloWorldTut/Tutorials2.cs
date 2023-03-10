/*||||| NOTES AND SHORTCUTS |||| 

TO BEGIN CODING:
start here.........------v

using System;
namespace Tutorialling
{ 
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}

*/
/* TUT 2 VARIABLES
______________________________________________________________________________________________________________

internal class Program
{
    private static void Main(string[] args)
    {
        {
            string characterName = "John";
            int characterAge;

            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Malcom";
            characterAge = 30;

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}

*/
/* TUT 3 DATA TYPES
 ____________________________________________________________________

internal class Program
{
    private static void Main(string[] args)
    {
        {
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;


            Console.WriteLine(phrase);

            Console.ReadLine(); 
        }
    }
}
*/
/*  TUT 4 'WORKING WITH STRINGS'
  ---------------------------------------------------------------------------------------------------
 
internal class Program
{
    private static void Main(string[] args)
    {
        string phrase = "Giraffe Academy " + "is cool.";
        Console.WriteLine("This is a String Variable, named Phrase");
        Console.WriteLine("Phrase has a value of = " + phrase );
        Console.WriteLine("The Length of Phrase is " + phrase.Length + " characters.");
        Console.WriteLine("This is Phrase  in all caps: " + phrase.ToUpper());
        Console.WriteLine("Is it True or False that Phrase contains the word Academy? " + phrase.Contains("Academy"));
        Console.WriteLine("Is it True or False that Phrase contains the word Academies? " + phrase.Contains("Academies"));
        Console.WriteLine("The 5th index position, in this case, letter, of Phrase is: " + phrase[5]);


        Console.ReadLine();
    }
}

*/
/* TUT 5 WORKING WITH NUMBERS ...
-------------------------------------------------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 6;
       
        Console.WriteLine(-5.763);
        Console.WriteLine(5-8);
        Console.WriteLine(4+2*3);
        Console.WriteLine((4+2)*3);
        Console.WriteLine(5.0+8.1);
        Console.WriteLine(5+8.1);
        Console.WriteLine(5/2);
        Console.WriteLine(5/2.0);
        Console.WriteLine(num);
        num++;
            Console.WriteLine(num);
        num--;
            Console.WriteLine(num);

// Math Methods
        Console.WriteLine(Math.Abs(-40));                   // Absolute Values (x) find the absolute value of x
        Console.WriteLine(Math.Pow(12, 10));            // To the Power of. (x,y) x to the power of y
        Console.WriteLine(Math.Pow(12, 10.2));         // To the Power of. (x,y) x to the power of y
        Console.WriteLine(Math.Sqrt(36));                  // Square Root.  (x) find sq root of x
        Console.WriteLine(Math.Max(4, 90));             // Gives the largest number of the two. (x, y) 
        Console.WriteLine(Math.Min(4, 90));             // Gives the smallest number of the two. (x, y) 
        Console.WriteLine(Math.Round(4.3));           // Rounds off the number (x)

        Console.WriteLine("Press any key to End.");
        Console.ReadLine();
    }

}

*/
/* TUT 6 GETTING USER INPUT 
---------------------------------------------------------------------------------------------------------------

namespace Tutorialling
{ 
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter your name: ");  //Prompt the User
            string name = Console.ReadLine(); // Allows User to type in the Console. Creates a STRING Variable that stores the answer the User puts in.
            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". You are " + age);


            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}

*/
/* BREAK - CREATE AN APP
-------------------------------------------------------------------------------------------------------------------------

namespace Tutorialling
{
    public class Program
    {
        public static void Main()
        {
            int a = 5;
            int b = 20;

            //Logic
            int c = a;
            a = b;
            b = c;

            //Result
            Console.WriteLine("a is: " + a + " b is: " + b);
        }
    }
}
*/
/* TUT 7 BUILDING A CALCULATOR
-----------------------------------------------------------------------------------------------------

namespace Tutorialling
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }
    }
}
*/
/* TUT 8 BUILDING A MAD LIB
 -----------------------------------------------------------------------------------------------------------------------------

namespace Tutorialling
{
    public class MabLib
    {
        public static void Main(string[] args)
        {

            string color, pluralNoun, celebrity; //Defines the string variables "color" "pluralNoun" and "celebrity"

            Console.Write("Enter a color: ");   //prompts user to enter a color
            color = Console.ReadLine();         //stores the answer in the variable 'color'

            Console.Write("Enter a Plural Noun: "); // same as above
            pluralNoun = Console.ReadLine();

            Console.Write("Enter the name of a celebrity: ");
            celebrity = Console.ReadLine();
            
            // writes a Mad Lib from the answers given

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are Blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

        }
    }
}

*/
/* TUT 9 ARRAYS
 -------------------------------------------------------------------------------------------------------------
using System;
namespace Tutorialling
{
    public class Arrays
    {
        public static void Main(string[] args)
        {

            int[] luckyNumber = { 4, 8, 15, 16, 23, 42 }; //Defines a variable that is an Array of values named "luckyNumber". uses '[]' after variable type.
            string[] friends = new string[10] ; //Defines a variable that is a string Array named "friends". the text following the = tells the system how many strings to store in the new variable.

            friends[0] = "Daniel";
            friends[1] = "Stephen";


            luckyNumber[3] = 900;

            Console.WriteLine(luckyNumber[0]);
            Console.WriteLine(luckyNumber[1]);
            Console.WriteLine(luckyNumber[2]);
            Console.WriteLine(luckyNumber[3]);

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);



            Console.WriteLine("Press any key to close.");
            Console.ReadLine();

        }
    }
}

*/
/* TUT 10 METHODS
 -------------------------------------------------------------------------------------------------------------------------------------------------

using System;
namespace Tutorialling
{
    public class Methods
    {
        public static void Main(string[] args)
        {

            Lesson10("Mike", 33); //calls the newly created Method. ("Mike") is the string that fills the methods 'name' slot.

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine(); 

        }

        static void Lesson10(string name, int age) //Creates a new method outside of Main method. (string name) lets the method know it needs to return a string.
        {

            Console.WriteLine("Hello " + name + ", aged " + age);

        }
    }
}

*/
/* TUT 11 RETURN STATEMENTS
 ---------------------------------------------------------------------------------------------------------------------- 

using System;
namespace Tutorialling
{
    public class ReturnStatements
    {
        public static void Main(string[] args)
        {
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
        
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;

        }
    }
}

*/
/* TUT 12 IF STATEMENT
 -------------------------------------------------------------------------------------------------------------------    

namespace Tutorialling
{
    public class ReturnStatements
    {
        public static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;
        
            if (isMale)//checks for true or false.
            {
                Console.WriteLine("You are a male");//returns if true
            }
            else
            {
                Console.WriteLine("You are either not male");//returns if false
            }

         if(isMale && isTall)// uses && which stands for 'and', and checks to see if both are true.
            {
                Console.WriteLine("You are a tall male");
            }
        else
           {
                Console.WriteLine("You are either not tall or not a male");
            }

            isMale = false;

            if (isMale && isTall)// uses && which stands for 'and', and checks to see if both are true.
            {
                Console.WriteLine("You are a tall male");
            }
            else
            {
                Console.WriteLine("You are either not tall or not a male");
            }

            isTall = false;

         if(isMale || isTall)//Checks to see if either variable is true. if either is it returns the first statement
            {
                Console.WriteLine("you are a tall male");
            }
         else
            {
                Console.WriteLine("You are short and not a male");//if both are false it will return this statement
            }

            if (isMale && isTall){// uses && which stands for 'and', and checks to see if both are true.
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall){// the "!" is the negation operator and will negate the value of the bool
                Console.WriteLine("You are a short male");
            } else if(!isMale && isTall) { 
                Console.WriteLine("You are not a male but you are tall");
            }else { 
                Console.WriteLine("You are not tall or not a male");
            }

            isTall = true;

            if (isMale && isTall)
            {// uses && which stands for 'and', and checks to see if both are true.
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {// the "!" is the negation operator and will negate the value of the bool
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not tall or not a male");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }

    }
}

*/
/* TUT 12.2 IF STATEMENTS CONT
 --------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
namespace Tutorialling
{
    public class IfStatements
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(GetMax(20,30,5));

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1>=num2 && num1>=num3)
            { 
               result= num1;    
            }
            else if(num2>=num1 && num2>=num3) 
            {
                result= num2;
            }
            else
            {
                result= num3;
            }


            return result; 
        }

    }
}
*/
/* TUT 13 BUILDING A BETTER CALCULATOR
 -------------------------------------------------------------------------------------------------------------------

using System;
namespace Tutorialling{
    public class BetterCalculator{
        public static void Main(string[] args){

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if(op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 /num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine() ;
        }
    }
}

*/
/* TUT 14 SWITCH STATEMENTS
 --------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
namespace Tutorialling
{
    public class SwitchStatements
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(GetDay(0));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;

            }

            return dayName;
        }
    }
}

*/
/*  TUT 15 WHILE LOOPS
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
namespace Tutorialling
{
    internal class WhileLoops
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}

*/
/* TUT 16 BUILDING A GUESSING GAME
------------------------------------------------------------------------------------------------------------------------------------------- 


using System;
namespace Tutorialling
{
    internal class GuessWhat
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}

*/