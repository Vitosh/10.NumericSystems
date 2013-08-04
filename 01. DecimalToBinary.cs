/* Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format
* (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.*/


using System;
using System.Collections.Generic;
class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter short-integer number: ");
        short number = short.Parse(Console.ReadLine());

        Console.Write("Binary representation is: ");
        BinRepresentationOfShort(number);
    }
    static void BinRepresentationOfShort(short num)
    {
        string bin = "";

        for (int bitNum = 15; bitNum >= 0; bitNum--)
        {
            int bitValue = (num >> bitNum) & 1;
            bin += bitValue;
        }
        Console.WriteLine(bin);
    }
}

