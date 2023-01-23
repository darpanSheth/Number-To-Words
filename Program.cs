using Module1AssignmentQuestion2;
using System;
using System.Numerics;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

BigInteger number;
do
{
    Write("Please type a valid BigInteger(21 digits maximum) number to convert into words: ");

} while (!BigInteger.TryParse(ReadLine(), out  number));

WriteLine(number.ToWords());

