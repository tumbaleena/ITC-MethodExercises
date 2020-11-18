using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 
            //Let the user enter 10 numbers, then after that, print the max, min, and average of those numbers.
            List<int> listOfNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
               int number = GetNumber();
               listOfNumbers.Add(number);
            }
            PrintTheMax(listOfNumbers);
            PrintTheMin(listOfNumbers);
            PrintTheAvg(listOfNumbers);


            //EXAMPLE OF METHOD OVERLOADING
            /*int number1 = 5;
            int number2 = 3;
            int number3 = 4;

            int answer1 = AddNumbers(number1, number2);
            int answer2 = AddNumbers(number1, number2, number3);

            Bark();

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);*/
        }
        

        //EXERCISE METHODS
        public static int GetNumber()
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            return number;
        }

        public static void PrintTheMax(List<int> list)
        {
            Console.WriteLine(list.Max());
        }

        public static void PrintTheMin(List<int> list)
        {
            Console.WriteLine(list.Min());

        }

        public static void PrintTheAvg(List<int> list)
        {
            Console.WriteLine(list.Average());

        }


        //EXAMPLE OVERLOAD METHODS
        /*public static int AddNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int AddNumbers(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        public static void Bark()
        {
            Console.WriteLine("Woof!");
        }*/
    }
}

