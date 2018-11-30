using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal = ");
            string hex = Console.ReadLine();
            string bin = string.Empty;

            string bin4digits = string.Empty, hexDigit;
            for (int i = 0; i < hex.Length; i++)
            {
                hexDigit = hex[i].ToString().ToLower();
                switch (hexDigit)
                {
                    case "0": bin4digits = "0000"; break;
                    case "1": bin4digits = "0001"; break;
                    case "2": bin4digits = "0010"; break;
                    case "3": bin4digits = "0011"; break;
                    case "4": bin4digits = "0100"; break;
                    case "5": bin4digits = "0101"; break;
                    case "6": bin4digits = "0110"; break;
                    case "7": bin4digits = "0111"; break;
                    case "8": bin4digits = "1000"; break;
                    case "9": bin4digits = "1001"; break;
                    case "a": bin4digits = "1010"; break;
                    case "b": bin4digits = "1011"; break;
                    case "c": bin4digits = "1100"; break;
                    case "d": bin4digits = "1101"; break;
                    case "e": bin4digits = "1110"; break;
                    case "f": bin4digits = "1111"; break;
                }
                bin += bin4digits;
            }

            Console.WriteLine("{0}(16) = {1}(2)", hex, bin);
        }
    }
}