//Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number, using 0 and 1 only");
        string bin = Console.ReadLine();
        BinaryToDec(bin);
    }
    static void BinaryToDec(string bin)
    {
        int dec = 0;
        int j = bin.Length - 1;

        for (int i = 0; i < bin.Length; i++)
        {
            dec += ((bin[i] - '0') * ((int)Math.Pow(2, j)));
            j--;
        }

        Console.WriteLine(dec);
    }

}

