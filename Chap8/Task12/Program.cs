﻿using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arabic = ");
            int arabic = int.Parse(Console.ReadLine());

            string roman = string.Empty;

            int thousands = arabic / 1000;

            for (int i = 0; i < thousands; i++)
            {
                roman += "M";
            }

            int hundreds = (arabic / 100) % 10;

            switch (hundreds)
            {
                case 1: roman += "C"; break;
                case 2: roman += "CC"; break;
                case 3: roman += "CCC"; break;
                case 4: roman += "CD"; break;
                case 5: roman += "D"; break;
                case 6: roman += "DC"; break;
                case 7: roman += "DCC"; break;
                case 8: roman += "DCCC"; break;
                case 9: roman += "CM"; break;
            }

            int tens = (arabic / 10) % 10;

            switch (tens)
            {
                case 1: roman += "X"; break;
                case 2: roman += "XX"; break;
                case 3: roman += "XXX"; break;
                case 4: roman += "XL"; break;
                case 5: roman += "L"; break;
                case 6: roman += "LX"; break;
                case 7: roman += "LXX"; break;
                case 8: roman += "LXXX"; break;
                case 9: roman += "XC"; break;
            }

            int ones = arabic % 10;

            switch (ones)
            {
                case 1: roman += "I"; break;
                case 2: roman += "II"; break;
                case 3: roman += "III"; break;
                case 4: roman += "IV"; break;
                case 5: roman += "V"; break;
                case 6: roman += "VI"; break;
                case 7: roman += "VII"; break;
                case 8: roman += "VIII"; break;
                case 9: roman += "IX"; break;
            }

            Console.WriteLine("{0} = {1}", arabic, roman);
        }
    }
}