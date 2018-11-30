using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal = ");
            int dec = int.Parse(Console.ReadLine());

            int remainder = dec % 2;
            int quotient = dec / 2;
            string bin = remainder.ToString();
            while (quotient > 0)
            {
                remainder = quotient % 2;
                quotient /= 2;
                bin = remainder + bin;
            }
            Console.WriteLine("{0} = {1}(2)", dec, bin);
        }
    }
}