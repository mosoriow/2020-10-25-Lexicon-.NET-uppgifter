using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            string firstName = Console.ReadLine();
            Console.Write("Write your surname: ");
            string lastName = Console.ReadLine();
            Console.Write("Write your city: ");
            string city = Console.ReadLine();

            //Console.Write("Result: ");
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            //Console.WriteLine(String.Format("{0} {1} {2}", reverseFirstName, reverseLastName, reverseCity));
            DisplayResult(reversedFirstName, reversedLastName, reversedCity);
            DisplayResult(reversedFirstName + " " + reversedLastName + " " + reversedCity);

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write("Result: ");
            Console.WriteLine(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Result: ");
            Console.WriteLine(message);
        }
    }
}
