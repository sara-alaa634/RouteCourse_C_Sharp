using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment_S4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number

            //Console.Write("enter integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i =1; i<= number;i++)
            //{
            //    Console.Write(i +( i< number?",":"" ));
            //}

            #endregion

            #region Problem 2

            //2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("enter integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write((i* number) + (i < 12 ? "," : ""));
            //}

            #endregion

            #region Problem 3
            //3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("enter integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= number; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write(i  + (i < number-1 ? "," : ""));

            //    }
            //}


            #endregion

            #region Problem 4
            //4- Write a program that takes two integers then prints the power.

            //Console.Write("enter integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine();
            //Console.Write("enter power number: ");
            //int.TryParse(Console.ReadLine(), out int power);
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= number;
            //}
            //Console.WriteLine($"the result: {result}");

            #endregion

            #region Problem 5

            //5- Write a program to enter marks of five subjects and calculate total, average and percentage.


            //Console.WriteLine("enter marks of 5 subjects: ");
            //int[] marks = new int[5];
            //int total = 0;


            //for (int i = 0; i <marks.Length; i++)
            //{
            //    Console.Write($"Subject {i+1}: ");
            //    int.TryParse(Console.ReadLine(), out marks[i]);
            //    total += marks[i];
            //}
            //// expect every subject is 100 mark so total is 500
            //Console.WriteLine("=====================");
            //Console.WriteLine($"Total: {total}");
            //Console.WriteLine($"Average: {total/5}");
            //Console.WriteLine($"Percentage: {(total*100)/500}");

            #endregion

            #region Problem 6
            //6- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("enter the string: ");
            //string word = Console.ReadLine();
            //char[] wordArray = word.ToCharArray();

            //Array.Reverse(wordArray);
            //Console.Write($"reverse of the string:");
            //for (int i=0; i<wordArray.Length; i++)
            //{
            //    Console.Write(wordArray[i]);
            //}

            #endregion

            #region Problem 7

            //7- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("enter the integer: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //int reverse = 0;

            //while(number > 0)
            //{
            //    reverse = reverse * 10 + reverse % 10;
            //    number /= 10;
            //}

            //Console.WriteLine($"reverse of the integer: {reverse}");



            #endregion

            #region Problem 8

            //8- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("enter the beggining of range: ");
            //int.TryParse(Console.ReadLine(), out int start);
            //Console.Write("enter the end of range: ");
            //int.TryParse(Console.ReadLine(), out int end);

            //for (int i=start; i<= end; i++)
            //{
            //    bool isPrimeNumber = true;
            //    if (i <= 1) isPrimeNumber = false;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrimeNumber = false;
            //            break;
            //        }
            //    }
            //    if (isPrimeNumber)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}


            #endregion

            #region Problem 9

            //9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("enter the number: ");
            // int.TryParse(Console.ReadLine(), out int number);
            //string binary = "";
            //while (number > 0)
            //{
            //    binary = (number % 2) + binary;
            //    number /= 2;
            //}
            //Console.WriteLine("binary number is: " + binary);

            #endregion

            #region Problem 10

            //10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("enter the  three points (x1 y1) ,( x2 y2), (x3 y3):");
            //int[,] points = new int[3, 2];
            //for(int i=0; i< 3; i++)
            //{
            //    Console.Write($"enter the x{i+1}: ");
            //    int.TryParse(Console.ReadLine(), out points[i,0]);
            //    Console.Write($"enter the y{i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out points[i, 1]);

            //}
            //bool isStraightLine = (points[1, 1] - points[0, 1]) * (points[2, 0] - points[1, 0]) == (points[2, 1] - points[1, 1]) * (points[1, 0] - points[0, 0]);

            //Console.WriteLine(isStraightLine?"yes those points are on a straight line": "no those points are not on a straight line");


            #endregion


            #region Problem 11

            //11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("enter the size of identity matrix: ");
            //int.TryParse(Console.ReadLine(), out int n);

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1");
            //        }
            //        else
            //        {
            //            Console.Write("0");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Problem 12

            //12- Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("write array size: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] numbers = new int[n];
            //int sum = 0;
            //for(int i=0; i< n; i++)
            //{
            //    Console.Write($"element {i+1} : ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //    sum += numbers[i];

            //}

            //Console.WriteLine($"the sum: {sum}");

            #endregion

            #region Problem 13

            // 13 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


            //Console.Write("write first array size: ");
            //int.TryParse(Console.ReadLine(), out int n1);
            //int[] array1 = new int[n1];
            //Console.WriteLine("enter first array elements: ");
            //for (int i = 0; i < n1; i++)
            //{
            //    Console.Write($"element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out array1[i]);
            //}
            //Console.WriteLine("==========================================");

            //Console.Write("write second array size: ");
            //int.TryParse(Console.ReadLine(), out int n2);
            //int[] array2 = new int[n2];
            //Console.WriteLine("enter second array elements: ");
            //for (int i = 0; i < n2; i++)
            //{
            //    Console.Write($"element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out array2[i]);
            //}

            //Console.WriteLine("==========================================");
            //int[] mergedArray = new int[n1 + n2];
            //Array.Copy(array1, mergedArray, n1);
            //Array.Copy(array2, 0, mergedArray, n1, n2);
            //Array.Sort(mergedArray);

            //Console.WriteLine("merged array: ");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.Write(mergedArray[i] + (i < mergedArray.Length - 1 ? ", " : ""));

            //}



            #endregion

            #region Problem 14

            //14- Write a program in C# Sharp to count the frequency of each element of an array.



            #endregion

            #region Problem 15

            //15- Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("write array size: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] numbers = new int[n];
            //Console.WriteLine("enter values of the array");
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write($"element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}
            //int max = numbers[0];
            //int min = numbers[0];

            //for(int i=1; i<n; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //Console.WriteLine($"max value: {max}");
            //Console.WriteLine($"min value: {min}");



            #endregion

            #region Problem 16

            //16- Write a program in C# Sharp to find the second largest element in an array.

            //Console.Write("write array size: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] numbers = new int[n];
            //Console.WriteLine("enter values of the array");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}

            //Array.Sort(numbers);
            //Console.WriteLine($"the second largest value is : {numbers[n - 2]}");

            #endregion

            #region Problem 17

            //17-. Consider an Array of Integer values with size N, having values as  in this Example

            //Console.Write("write array size: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] numbers = new int[n];
            //Console.WriteLine("enter values of the array");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}
            //int maxDistance = -1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - 1; j > i; j--)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance) maxDistance = distance;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"the longest distance between Two equal cells: {maxDistance}");


            #endregion

            #region Problem 18

            //Console.Write("enter words with space between words: ex:this is a test:");
            //string input = Console.ReadLine();
            //string[] words = input.Split(" ");
            //Array.Reverse(words);
            //Console.WriteLine("===============================");

            //Console.Write($"reversed words:");
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i]+" ");
            //}



            #endregion

            #region Problem 19

            // 19-Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("write array size: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[,] array1 = new int[n,n];
            //Console.WriteLine("enter values of the first array");
            //for (int i = 0; i < n; i++)
            //{
            //    for(int j=0; j < n; j++)
            //    {
            //        Console.Write($"element [{i + 1},{j + 1}] : ");
            //        int.TryParse(Console.ReadLine(), out array1[i, j]);
            //    }

            //}

            //int[,] array2 = new int[n, n];
            //Array.Copy(array1, array2, array1.Length);

            //Console.WriteLine("valuse of second array afrer copy");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.WriteLine($"element [{i + 1},{j + 1}] : {array2[i,j]}");
            //    }

            //}

            #endregion

            #region Problem 20

            //20- Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("write array size: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] numbers = new int[n];
            //Console.WriteLine("enter values of the array");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}

            //Array.Reverse(numbers);
            //Console.Write("elements of the array after reverse: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(numbers[i]+(i<n-1?",":" "));
            //}


            #endregion
        }

    }
}
