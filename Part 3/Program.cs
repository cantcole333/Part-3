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
            DateTime now = DateTime.Today;
            string name;
            string greeting = "Hello There ";
            int userAge;
            int year = now.Year;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine($"{greeting}{name}");

            Console.WriteLine("Please type your age");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You were born in... {year - userAge}");
            Console.WriteLine("Please press any key to continue");
            Console.ReadLine();


            double numOne;
            double numTwo;
            double numThree;
            double sum;

            Console.WriteLine("type three numbers");
            numOne = Convert.ToDouble(Console.ReadLine());
            numTwo = Convert.ToDouble(Console.ReadLine());
            numThree = Convert.ToDouble(Console.ReadLine());
            sum = numOne + numTwo + numThree;
            sum = Math.Round(sum, 2);
            Console.WriteLine($"The sum is... {sum}");
            Console.WriteLine("Please press any key to continue");
            Console.ReadLine();


            double kmFirst;
            double kmSecond;
            double kmThird;
            double kmaverage;

            Console.WriteLine("Please input 3 numbers");
            kmFirst = Convert.ToDouble(Console.ReadLine());
            kmSecond = Convert.ToDouble(Console.ReadLine());
            kmThird = Convert.ToDouble(Console.ReadLine());
            kmaverage = (kmFirst + kmSecond + kmThird) / 3;
            kmaverage = Math.Round(kmaverage, 2);
            Console.WriteLine($"the average of the numbers is {kmaverage}km");
            Console.WriteLine("Please press any key to continue");
            Console.ReadLine();


            double leg1;
            double leg2;
            double hypotenuse;

            Console.WriteLine("enter 2 lengths");
            leg1 = Convert.ToDouble(Console.ReadLine());
            leg2 = Convert.ToDouble(Console.ReadLine());
            leg1 = leg1 * leg1;
            leg2 = leg2 * leg2;
            hypotenuse = leg1 + leg2;
            hypotenuse = Math.Sqrt(hypotenuse);
            hypotenuse = Math.Round(hypotenuse, 2);
            Console.WriteLine($"The length of the hypotenuse is... {hypotenuse}");

            Console.ReadLine();
        }
    }
}