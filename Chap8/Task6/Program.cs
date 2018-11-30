using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal = ");
            string hex = Console.ReadLine();

            int dec = 0, power = 1, factor = 0;
            string hexDigit = string.Empty;
            for (int exponent = 0; exponent < hex.Length; exponent++)
            {
                hexDigit =
                   hex[hex.Length - 1 - exponent].ToString().ToLower();
                switch (hexDigit)
                {
                    case "a": factor = 10; break;
                    case "b": factor = 11; break;
                    case "c": factor = 12; break;
                    case "d": factor = 13; break;
                    case "e": factor = 14; break;
                    case "f": factor = 15; break;
                    default: factor = int.Parse(hexDigit); break;
                }
                dec += factor * power;

                power *= 16;
            }

            Console.WriteLine("{0}(16) = {1}", hex, dec);
        }
    }
}