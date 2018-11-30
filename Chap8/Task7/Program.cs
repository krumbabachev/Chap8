using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal = ");
            int dec = int.Parse(Console.ReadLine());

            int remainder, quotient = dec;
            string hex = string.Empty, hexDigit;
            do
            {
                remainder = quotient % 16;
                quotient /= 16;

                switch (remainder)
                {
                    case 10: hexDigit = "a"; break;
                    case 11: hexDigit = "b"; break;
                    case 12: hexDigit = "c"; break;
                    case 13: hexDigit = "d"; break;
                    case 14: hexDigit = "e"; break;
                    case 15: hexDigit = "f"; break;
                    default: hexDigit = remainder.ToString(); break;
                }
                hex = hexDigit + hex;
            }
            while (quotient > 0);

            Console.WriteLine("{0} = {1}(16)", dec, hex);
        }
    }
}