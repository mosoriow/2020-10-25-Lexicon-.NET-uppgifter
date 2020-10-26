/*
 * According to Wikipedia, FizzBuzz is a group word game for children to teach them about
 * division. This may or may not be true, but this question is generally used to torture screen 
 * young computer science graduates during programming interviews.
 * 
 * Basically, this is how it works: you print the integers from 1 to N, replacing any of them 
 * divisible by X with Fizz or, if they are divisible by Y, with Buzz. If the number is divisible 
 * by both X and Y, you print FizzBuzz instead.
 * 
 * Check the samples for further clarification.
 * 
 * Input
 * Input contains a single test case. Each test case contains three integers on a single line, X, 
 * Y and N (1<=X<Y<=N<=100).
 * 
 * Output
 * Print integers from 1 to N in order, each on its own line, replacing the ones divisible by X 
 * with Fizz, the ones divisible by Y with Buzz and ones divisible by both X and Y with FizzBuzz.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz program");
            int X, Y, N;
            bool invalidInput = true;

            do
            {
                Console.Write("Input X (Fizz): ");
                 X = Int32.Parse(Console.ReadLine());
                Console.Write("Input Y (Buzz): ");
                Y = Int32.Parse(Console.ReadLine());
                Console.Write("Input N (total number of iterations): ");
                N = Int32.Parse(Console.ReadLine());
                if ((1 <= X) && (X < Y) && (Y <= N) && (N <= 100))
                    invalidInput = false;
                else
                    Console.WriteLine("Invalid input. Values should be within 1<=X<Y<=N<=100");
            } while (invalidInput);

            for(int i=1;i<=N;i++)
            {
                if (i % X == 0) Console.Write("Fizz");
                if (i % Y == 0) Console.Write("Buzz");
                if ((i % X != 0) && (i % Y != 0)) Console.Write(i);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
