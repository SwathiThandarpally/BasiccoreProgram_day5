﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelAndConsonant
{
    public static  class CheckAplphabet
    {
        public static void Display()
        {
            Console.WriteLine("Enter any character");

            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'u' )
            {
                Console.WriteLine(ch + " is vowel");

            }else if((ch>='a' && ch<='z') || (ch>='A' && ch<='Z'))
            {
                Console.WriteLine(ch + " is consonant.");
            }
            else
            {
                Console.WriteLine("Enter the correct character");
            }
        }

    }
}
