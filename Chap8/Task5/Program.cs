using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Binary = ");
            string bin = Console.ReadLine();

            int dec = 0;
            int power = 1;
            for (int exponent = 0; exponent < bin.Length; exponent++)
            {
                if (bin[bin.Length - 1 - exponent].Equals('1'))
                {
                    dec += power;
                }
                power *= 2;
            }

            Console.WriteLine("{0}(2) = {1}", bin, dec);
        }
    }
}