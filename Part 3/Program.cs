using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime now = DateTime.Today;
            //string name;
            //string greeting = "Hello There ";
            //int userAge;
            //int year = now.Year;

            //Console.WriteLine("Please enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine($"{greeting}{name}");
            //;
            //Console.WriteLine("Please type your age");
            //userAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(year - userAge);
            int numOne;
            int numTwo;
            int numThree;
            int sum;
            Console.WriteLine("type three numbers");
            numOne = Convert.ToInt32(Console.ReadLine());
            numTwo = Convert.ToInt32(Console.ReadLine());
            numThree = Convert.ToInt32(Console.ReadLine());
            sum = numOne + numTwo + numThree;
            Console.WriteLine($"The sum is... {sum}");
            Console.ReadLine();
        }
    }
}
