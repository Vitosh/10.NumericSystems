/* Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Collections.Generic;

class HexToBinary
{
    static void Main()
    {
        Console.Write("Enter hex value: ");
        string hex = Console.ReadLine();

        Console.Write("Binary representation is: ");
        HexToBin(hex);
    }

    static void HexToBin(string hex)
    {
        string bin = "";
        int j = hex.Length - 1;
        int number = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            if (char.IsLetter(hex[i]))
            {
                switch (hex[i])
                {
                    case 'A':
                        number = 10;
                        break;
                    case 'B':
                        number = 11;
                        break;
                    case 'C':
                        number = 12;
                        break;
                    case 'D':
                        number = 13;
                        break;
                    case 'E':
                        number = 14;
                        break;
                    case 'F':
                        number = 15;
                        break;
                }
            }
            else
            {
                number = hex[i] - '0';
            }
            for (int bitNum = 3; bitNum >= 0; bitNum--)
            {
                int bitValue = (number >> bitNum) & 1;
                bin += bitValue;
            }
        }
        Console.WriteLine(bin);
    }
}
