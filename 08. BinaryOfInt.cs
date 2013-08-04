/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.Write("Please, enter a 16 bit integer: ");
        short number = short.Parse(Console.ReadLine());
        byte[] binary = new byte[16];
        ConvertDecimalToBinary(number, binary);
        Console.Write("Binary(short): ");
        PrintBinary(binary);
    }
    static void ConvertDecimalToBinary(short number, byte[] binary)
    {
        bool negative = false;

        if (number < 0)
        {
            negative = true;
            number *= -1;
        }

        byte index = 15;

        do
        {
            binary[index] = (byte)(number % 2);
            number /= 2;
            index--;
        } while (number != 0);

        if (negative)
        {
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == 0)
                {
                    binary[i] = 1;
                }
                else
                {
                    binary[i] = 0;
                }
            }
            index = 15;
            while (binary[index] == 1)
            {
                binary[index] = 0;
                index--;
            }
            binary[index] = 1;
        }
    }

    static void PrintBinary(byte[] array)
    {
        byte counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            counter++;
            if (counter == 4)
            {
                Console.Write(" ");
                counter = 0;
            }
        }
        Console.WriteLine();
    }

}
