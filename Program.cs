using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_a_number__contains_a_digit
{
    internal class Program
    {

        static bool IfNumberContains3(int number)

            //*This method will repeatedly check if the given interger contains the digit
            //3 by repeatedly taking out the last number using the modulo % 10
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit == 3)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int number1 = 7201432;
            int number2 = 87501;

            bool contains3_1 = IfNumberContains3(number1);
            bool contains3_2 = IfNumberContains3(number2);

            Console.WriteLine($"{number1} contains the digit 3: {contains3_1}");
            Console.WriteLine($"{number2} contains the digit 3: {contains3_2}");
        }
    }
}
