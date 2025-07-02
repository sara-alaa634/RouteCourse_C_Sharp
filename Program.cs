using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment_S3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1
            // 1.Write a program that allows the user to enter a number then print it.
            //Console.Write("Please Enter Number:");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine($"the number you write is: {number}");
            #endregion

            #region Problem 2

            //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string text = "12se";
            //int convertText = Convert.ToInt32(text);
            //Console.WriteLine(convertText);

            //What happend: the program will throw exception beacuse convert not handle the exception senario as tryParse()
            #endregion

            #region Problem 3
            //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float x = 10.5f;
            //float y = 5.5f;
            //Console.WriteLine($"{x}+{y}={x+y}");

            // What Happend: nothing happend it makes the equation
            #endregion

            #region Problem 4
            //4.Write C# program that Extract a substring from a given string.

            //string text = "hello world";
            //Console.WriteLine($"extract substing from {text} text: {text.Substring(0,7)}");

            #endregion

            #region Problem 5

            //5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int x = 6, y = 5;
            //Console.WriteLine($"X={x}, Y={y}");
            //y = x;
            //Console.WriteLine($"X={x}, Y={y}");
            //x++;
            //Console.WriteLine($"X={x}, Y={y}");

            //What Happend: is when i change the value of x the y not also changed becuase the int is not refrensial type

            #endregion

            #region Problem 6

            //6.	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Class1 class1 = new Class1();
            //Class1 class2 = new Class1() { x=20 , y=20};

            //Console.WriteLine($"class1 x :{class1.x}, y:{class1.y}");
            //Console.WriteLine($"class1 x :{class2.x}, y:{class2.y}");

            //class2 = class1;
            //Console.WriteLine("===========================================");

            //Console.WriteLine($"class1 x :{class1.x}, y:{class1.y}");
            //Console.WriteLine($"class1 x :{class2.x}, y:{class2.y}");

            //class1.x = 100;

            //Console.WriteLine("===========================================");

            //Console.WriteLine($"class1 x :{class1.x}, y:{class1.y}");
            //Console.WriteLine($"class1 x :{class2.x}, y:{class2.y}");

            //What Happend: is when i change the value of class1.x the class2.x also changed becuase the class is refrensial type
            #endregion

            #region Problem 7

            //7.Write C# program that take two string variables and print them as one variable 
            // Console.WriteLine("write your name:");
            // Console.Write("first name: ");
            //string firstName= Console.ReadLine();
            // Console.Write("last name: ");
            // string lastName = Console.ReadLine();


            // Console.WriteLine($"User Full Name: {firstName} {lastName}");

            #endregion

            #region Problem 8

            //8. Write a program that calculates the simple interest given the principal amount, rate of interest, and time. Note: The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.WriteLine("enter the following values for the formula:");
            //Console.Write("principal amount: ");
            //int.TryParse(Console.ReadLine(), out int principle);
            //Console.Write("rate of interest: ");
            //int.TryParse(Console.ReadLine(), out int rate);
            //Console.Write("time: ");
            //int.TryParse(Console.ReadLine(), out int time);

            //Console.WriteLine($"the formula={(principle*rate*time)/100}");

            #endregion

            #region Problem 9

            //9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 

            //Console.WriteLine("enter the following values for the formula of Body Mass Index (BMI):");
            //Console.Write("Weight : ");
            //int.TryParse(Console.ReadLine(), out int weight);
            //Console.Write("Height : ");
            //int.TryParse(Console.ReadLine(), out int height);
            //Console.WriteLine($"the formula={(weight) / (height * height)}");

            #endregion

            #region Problem 10
            /*
             10.	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
                    Note : 
                    a.	that below 10 degrees is "Just Cold"
                    b.	above 30 degrees is "Just Hot"
                    c.	anything else is "Just Good"

             */

            //Console.WriteLine("enter the temprature");
            //int.TryParse(Console.ReadLine(), out int temp);
            //string result = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine($"temp is {result}");

            #endregion

            #region Problem 11

            /*
             11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
                Ex :
                Today’s date : 20 , 11 , 2001
                Today's date : 20 / 11 / 2001
                Today's date : 20 – 11 – 2001
             
             */

            //Console.WriteLine("enter the date");
            //Console.Write("day: ");
            //int.TryParse(Console.ReadLine(), out int day);
            //Console.Write("month: ");
            //int .TryParse(Console.ReadLine(), out int month);
            //Console.Write("year: ");
            //int.TryParse(Console.ReadLine(), out int year);
            //Console.WriteLine($"Today’s date : {day} , {month} , {year}");
            //Console.WriteLine($"Today’s date : {day} / {month} / {year}");
            //Console.WriteLine($"Today’s date : {day} - {month} - {year}");

            #endregion

            #region Problem 12

            /*
             12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
                Example (1)
                Input: 12 
                Output: Yes
                Example (2)
                Input: 9 
                Output: No

             */
            //Console.WriteLine("enter the number");
            //Console.Write("number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine($"the result is :{result}");

            #endregion

            #region Problem 13

            /*
             13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
                Example (1)
                Input: -5
                Output: negative
                Example (2)
                Input: 10
                Output: positive
             */

            //Console.WriteLine("enter the integer number");
            //Console.Write("number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //string result = (number <0) ? "Negative" : "Postive";
            //Console.WriteLine($"the result is :{result}");

            #endregion

            #region Problem 14

            /*
             14- Write a program that takes 3 integers from the user then prints the max element and the min element.
                Example (1)
                Input:7,8,5
                Output:
                max element = 8
                min element = 5
            —--------------------------------
                Example (2)
                Input: 3 6 9
                Outputs:
                Max element = 9
                Min element = 3 
             */

            //Console.WriteLine("enter the integer values");
            //Console.Write("first number: ");
            //int.TryParse(Console.ReadLine(), out int number1);
            //Console.Write("second number: ");
            //int.TryParse(Console.ReadLine(), out int number2);
            //Console.Write("third number: ");
            //int.TryParse(Console.ReadLine(), out int number3);

            //int max = number1, min = number1;
            //// for the max
            //if (number2 > max)
            //    max = number2;
            //if (number3 > max)
            //    max = number3;

            //// for the min
            //if (number2 < min)
            //    min = number2;
            //if (number3 < min)
            //    min = number3;
            //Console.WriteLine($"the result is the maximum number is : {max}, minimun number is : {min}");

            #endregion

            #region Problem 15

            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("enter integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //string result = (number % 2 == 0) ? "Even" : "Odd";
            //Console.WriteLine($"the result is: {result}");

            #endregion

            #region Problem 16

            /*
             16- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
                Example (1)
                Input: O
                Output: vowel
                Example (2)
                Input: b
                Output: Consonant
             */
            //Console.Write("enter the char: ");
            //char.TryParse(Console.ReadLine(), out char character);

            //switch(character) {
            //    case 'a':
            //    case 'A':
            //    case 'e':
            //    case 'E':
            //    case 'i':
            //    case 'I':
            //    case 'o':
            //    case 'O':
            //    case 'u':
            //    case 'U':
            //        Console.WriteLine("vowel char");
            //        break;
            //    default:
            //        Console.WriteLine("consonant char");
            //        break;
            //}

            #endregion

            #region Problem 17


            /*
             Write a program to input the month number and print the number of days in that month.
                Example
                Input: Month Number: 1
                Output: Days in Month: 31
             */

            Console.Write("enter month number: ");
            int.TryParse(Console.ReadLine(), out int month);

            switch (month) { 
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("days in this month is :31");
                break;
            case 2:
                Console.WriteLine("days in this month is :28");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("days in this month is :30");
                break;

            }
            #endregion








        }
    }
}
