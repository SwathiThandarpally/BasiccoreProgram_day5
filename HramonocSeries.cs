using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class HramonocSeries
    {
        public static void checkHarmonicSeries()
        {
            int i, n;
            double s = 0.0;

            Console.WriteLine("n\n");
            Console.WriteLine("Calculate the harmonic series:\n");
            Console.WriteLine("\n\n");

            Console.WriteLine("Input the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                s += 1 / (float)i;
            }
        }
    }
}
