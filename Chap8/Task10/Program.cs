using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Binary = ");
            string bin = Console.ReadLine();

            int dec = 0;

            for (int i = 0; i < bin.Length; i++)
            {
                dec *= 2;
                if (bin[i].Equals('1'))
                {
                    dec++;
                }
            }

            Console.WriteLine("{0}(2) = {1}", bin, dec);
        }
    }
}