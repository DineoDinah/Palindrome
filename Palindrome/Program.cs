using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number To Check if is a Palindrome : \n");
            int number = int.Parse(Console.ReadLine());
            int reminder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine("Number {temp} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
