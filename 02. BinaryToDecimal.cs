//Write a program to convert binary numbers to their decimal representation.

static int BinaryToDec(string number)
{
    int result = 0;
    int length = number.Length - 1;
    for (int i = 0; i < number.Length; i++)
    {
        result += ((number[i] - '0') * ((int)Math.Pow(2, length)));
        length--;
    }
    return result;
}
static string DecimalToBinary(int number) 
{
    string result = "";
    for (int bitNum = 15; bitNum >= 0; bitNum--)
    {
        int bitValue = (number >> bitNum) & 1;
        result += bitValue;
    }
    return result;
}

