using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 1000001);

            string numberInWords = NumberToWords(number);

            Console.WriteLine($"{number} - {numberInWords}");

            string NumberToWords(int num)
            {
                if (num == 0)
                    return "ноль";

                string words = "";

                if ((num / 1000) > 0)
                {
                    words += NumberToWords(num / 1000) + " тысяча ";
                    num %= 1000;
                }

                if ((num / 100) > 0)
                {
                    words += HundredsToWords(num / 100) + " ";
                    num %= 100;
                }

                if (num > 0)
                {
                    if (num < 20)
                        words += UnitsToWords(num);
                    else
                    {
                        words += TensToWords(num / 10);
                        if ((num % 10) > 0)
                            words += " " + UnitsToWords(num % 10);
                    }
                }

                return words.Trim();
            }

            string UnitsToWords(int num)
            {
                switch (num)
                {
                    case 1: return "один";
                    case 2: return "два";
                    case 3: return "три";
                    case 4: return "четыре";
                    case 5: return "пять";
                    case 6: return "шесть";
                    case 7: return "семь";
                    case 8: return "восемь";
                    case 9: return "девять";
                    case 10: return "десять";
                    case 11: return "одиннадцать";
                    case 12: return "двенадцать";
                    case 13: return "тринадцать";
                    case 14: return "четырнадцать";
                    case 15: return "пятнадцать";
                    case 16: return "шестнадцать";
                    case 17: return "семнадцать";
                    case 18: return "восемнадцать";
                    case 19: return "девятнадцать";
                    default: return "";
                }
            }

            string TensToWords(int num)
            {
                switch (num)
                {
                    case 2: return "двадцать";
                    case 3: return "тридцать";
                    case 4: return "сорок";
                    case 5: return "пятьдесят";
                    case 6: return "шестьдесят";
                    case 7: return "семьдесят";
                    case 8: return "восемьдесят";
                    case 9: return "девяносто";
                    default: return "";
                }
            }

            string HundredsToWords(int num)
            {
                switch (num)
                {
                    case 1: return "сто";
                    case 2: return "двести";
                    case 3: return "триста";
                    case 4: return "четыреста";
                    case 5: return "пятьсот";
                    case 6: return "шестьсот";
                    case 7: return "семьсот";
                    case 8: return "восемьсот";
                    case 9: return "девятьсот";
                    default: return "";
                }
            }

            int[,] array = new int[5, 6];

            int value = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    array[i, j] = value;
                    value++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
