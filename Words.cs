using System;
using System.Numerics;
using System.Text;

namespace Module1AssignmentQuestion2
{
	public static class Words
	{
        public static String[] units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
        public static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public static string ToWords(this BigInteger number)
		{
            string wordAsNumber = number.ToString();
            int initialNumbers;
            string prefix = "";
            string? suffix = "";

            if (wordAsNumber.Length < 4)
            {
                if (wordAsNumber.Length == 3)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 2)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 1)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = null;
            }
            else if (wordAsNumber.Length < 7)
            {
                if (wordAsNumber.Length == 6)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 5)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 4)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = " Thousand";
            }
            else if (wordAsNumber.Length <= 9)
            {
                if (wordAsNumber.Length == 9)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 8)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 7)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = " Million";
            }
            else if (wordAsNumber.Length <= 12)
            {
                if (wordAsNumber.Length == 12)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 11)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 10)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = " Billion";
            }
            else if (wordAsNumber.Length <= 15)
            {
                if (wordAsNumber.Length == 15)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 14)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 13)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = " Trillion";
            }
            else if (wordAsNumber.Length <= 18)
            {
                if (wordAsNumber.Length == 18)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 17)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 16)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = " Quadrillion";
            }
            else if (wordAsNumber.Length <= 21)
            {
                if(wordAsNumber.Length == 21)
                {
                    initialNumbers = Initial3Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 20)
                {
                    initialNumbers = Initial2Numbers(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                if (wordAsNumber.Length == 19)
                {
                    initialNumbers = Initial1Number(wordAsNumber);
                    prefix = PrefixDigitsToWords(initialNumbers);
                }
                suffix = " Quintillion";
            }
            else if(wordAsNumber.Length > 21)
            {
                prefix = "The number is too big. Please enter the number of less than 21 digits.";
            }
      
            
            return prefix + suffix;
        }

        public static int Initial3Numbers(string wordAsNumber)
        {
            return int.Parse(wordAsNumber.Substring(0,3));
        }

        public static int Initial2Numbers(string wordAsNumber)
        {
            return int.Parse(wordAsNumber.Substring(0, 2));
        }

        public static int Initial1Number(string wordAsNumber)
        {
            return int.Parse(wordAsNumber.Substring(0, 1));
        }


        public static string PrefixDigitsToWords(int i)
        {
            string ResultPrefix = "";

            if (i < 20)
            {
                ResultPrefix = units[i];
            }
            else if (i < 100)
            {
                ResultPrefix = tens[i / 10] + ((i % 10 > 0) ? " " + PrefixDigitsToWords(i % 10) : "");
            }
            else if (i < 1000)
            {
                ResultPrefix =  units[i / 100] + " Hundred"
                        + ((i % 100 > 0) ? " And " + PrefixDigitsToWords(i % 100) : "");
            }
            return ResultPrefix;
        }
	}
}

