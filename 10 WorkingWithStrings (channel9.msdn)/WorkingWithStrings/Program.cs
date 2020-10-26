using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need \n a new line";
            //string myString = @"Go to your C:\ drive";
            //string myString = String.Format("{1} = {0}", "first", "second");
            //string myString = String.Format("{0:C}", 123.45);
            string myString = String.Format("{0:N}", 1234567890);
            string myString = String.Format("Percentage {0:P}", 0.252);
            string myString = String.Format("Phone Number {0:(###) ###-####}", 123456789012);
            */
            //string myString = " That summer we took threes across the board  ";

            /*
            myString = myString.Substring(6);
            myString = myString.ToUpper();
            myString = myString.Replace(" ","--");
            myString = myString.Remove(6,12);
            myString = myString.Trim();
            */
            StringBuilder myString = new StringBuilder();

            for (int i=0;i<100;i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);

            Console.ReadLine();
        }
    }
}
