using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelAndConsonant
{
    public class EVENorODD
    {
        public static void CheckEvenOrOdd()
        {
            int a;
            Console.WriteLine("Enter a number :");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.ReadLine();
                Console.WriteLine("Enter the number is Even");
             
            }
            else
            {
                Console.ReadLine();
                Console.WriteLine("Enter the number is odd");
               
            }

        }

    }
}
