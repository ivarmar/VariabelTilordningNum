using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndVoid
{
    internal class MyConsole
    {

        public int MathNumbers()
            {
                Console.Write("Enter the first number: ");
                int input1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int input2 = int.Parse(Console.ReadLine());

                var sum = input1 + input2;
                Console.WriteLine($"You entered {input1} and {input2}");
                return sum;
            }

        public static void Nothing()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This Method does basically nothing");
            //return String.Empty;
        }
        


    }
}
