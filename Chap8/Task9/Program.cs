using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Binary = ");
            string bin = Console.ReadLine();

            switch (bin.Length % 4)
            {
                case 1: bin = "000" + bin; break;
                case 2: bin = "00" + bin; break;
                case 3: bin = "0" + bin; break;
            }

            string hex = string.Empty;

            string bin4digits, hexDigit = string.Empty;
            for (int i = 0; i < bin.Length; i += 4)
            {
                bin4digits = bin.Substring(i, 4);
                switch (bin4digits)
                {
                    case "0000": hexDigit = "0"; break;
                    case "0001": hexDigit = "1"; break;
                    case "0010": hexDigit = "2"; break;
                    case "0011": hexDigit = "3"; break;
                    case "0100": hexDigit = "4"; break;
                    case "0101": hexDigit = "5"; break;
                    case "0110": hexDigit = "6"; break;
                    case "0111": hexDigit = "7"; break;
                    case "1000": hexDigit = "8"; break;
                    case "1001": hexDigit = "9"; break;
                    case "1010": hexDigit = "a"; break;
                    case "1011": hexDigit = "b"; break;
                    case "1100": hexDigit = "c"; break;
                    case "1101": hexDigit = "d"; break;
                    case "1110": hexDigit = "e"; break;
                    case "1111": hexDigit = "f"; break;
                }
                hex += hexDigit;
            }

            Console.WriteLine("{0}(2) = {1}(16)", bin, hex);
        }
    }
}