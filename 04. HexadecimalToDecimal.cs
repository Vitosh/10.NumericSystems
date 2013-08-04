// Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Text;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please, write a hexadecimal number: ");
        string hexadecimal = Console.ReadLine().PadLeft(8, '0');
        int number = ConvertToDecimal(hexadecimal);
        Console.WriteLine("Decimal: {0}", number);
    }

    static int ConvertToDecimal(string hexadecimal)
    {
        int number = 0;
        if (hexadecimal[0] < 56)
        {
            for (int i = 0, j = hexadecimal.Length - 1; i < hexadecimal.Length; i++, j--)
            {
                if (hexadecimal[i] > 57)
                {
                    number += (hexadecimal[i] - 55) * (int)Math.Pow(16, j);
                }

                else
                {
                    number += (hexadecimal[i] - 48) * (int)Math.Pow(16, j);
                }
            }
            return number;
        }

        else
        {
            string[] binary = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111", };
            StringBuilder binaryNumber = new StringBuilder();
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if (hexadecimal[i] > 57)
                {
                    binaryNumber.Append(binary[hexadecimal[i] - 55]);
                }

                else
                {
                    binaryNumber.Append(binary[hexadecimal[i] - 48]);
                }
            }
            byte index = 31;

            while (binaryNumber[index] != '1')
            {
                binaryNumber[index] = '1';
                index--;
            }
            binaryNumber[index] = '0';

            for (int i = 0, j = binaryNumber.Length - 1; i < binaryNumber.Length; i++, j--)
            {
                if (binaryNumber[i] == '0')
                {
                    number += (int)Math.Pow(2, j);
                }
            }
            return number * -1;
        }
    }
}
