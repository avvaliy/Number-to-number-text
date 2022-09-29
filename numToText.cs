using System;
using System.Collections.Generic;

namespace numToText
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            Console.WriteLine(numText(num));
        }
        static string numText(ulong num)
        {
            string numText = "", res = "", for_zero = "";
            while (num > 0)
            {
                numText += Convert.ToString(num % 10);
                num /= 10;
            }
            int len = numText.Length;
            List<string> nums3 = new List<string>();
            for (int i = 0; i <= len - 1; i += 3)
            {
                string num3text = "";
                for (int j = 2; j >= 0; j--)
                {
                    if (i + j < len)
                    {
                        num3text += numText[i + j];
                    }
                }
                nums3.Add(num3text);
            }
            for (int i = nums3.Count - 1; i >= 0; i--)
            {
                if (nums3[i].Length == 3)
                {
                    switch (nums3[i][0])
                    {
                        case '1':
                            res += "bir yuz ";
                            break;
                        case '2':
                            res += "ikki yuz ";
                            break;
                        case '3':
                            res += "uch yuz ";
                            break;
                        case '4':
                            res += "to'rt yuz ";
                            break;
                        case '5':
                            res += "besh yuz ";
                            break;
                        case '6':
                            res += "olti yuz ";
                            break;
                        case '7':
                            res += "yetti yuz ";
                            break;
                        case '8':
                            res += "sakkiz yuz ";
                            break;
                        case '9':
                            res += "to'qqiz yuz ";
                            break;
                        default:
                            break;
                    }
                    switch (nums3[i][1])
                    {
                        case '1':
                            res += "o'n ";
                            break;
                        case '2':
                            res += "yigirma ";
                            break;
                        case '3':
                            res += "o'ttiz ";
                            break;
                        case '4':
                            res += "qirq ";
                            break;
                        case '5':
                            res += "ellik ";
                            break;
                        case '6':
                            res += "oltmish ";
                            break;
                        case '7':
                            res += "yetmish ";
                            break;
                        case '8':
                            res += "sakson ";
                            break;
                        case '9':
                            res += "to'qson ";
                            break;
                        default:
                            break;
                    }
                    switch (nums3[i][2])
                    {
                        case '1':
                            res += "bir ";
                            break;
                        case '2':
                            res += "ikki ";
                            break;
                        case '3':
                            res += "uch ";
                            break;
                        case '4':
                            res += "to'rt ";
                            break;
                        case '5':
                            res += "besh ";
                            break;
                        case '6':
                            res += "olti ";
                            break;
                        case '7':
                            res += "yetti ";
                            break;
                        case '8':
                            res += "sakkiz ";
                            break;
                        case '9':
                            res += "to'qqiz ";
                            break;
                        default:
                            break;
                    }
                }
                else if (nums3[i].Length == 2)
                {
                    switch (nums3[i][0])
                    {
                        case '1':
                            res += "o'n ";
                            break;
                        case '2':
                            res += "yigirma ";
                            break;
                        case '3':
                            res += "o'ttiz ";
                            break;
                        case '4':
                            res += "qirq ";
                            break;
                        case '5':
                            res += "ellik ";
                            break;
                        case '6':
                            res += "oltmish ";
                            break;
                        case '7':
                            res += "yetmish ";
                            break;
                        case '8':
                            res += "sakson ";
                            break;
                        case '9':
                            res += "to'qson ";
                            break;
                        default:
                            break;
                    }
                    switch (nums3[i][1])
                    {
                        case '1':
                            res += "bir ";
                            break;
                        case '2':
                            res += "ikki ";
                            break;
                        case '3':
                            res += "uch ";
                            break;
                        case '4':
                            res += "to'rt ";
                            break;
                        case '5':
                            res += "besh ";
                            break;
                        case '6':
                            res += "olti ";
                            break;
                        case '7':
                            res += "yetti ";
                            break;
                        case '8':
                            res += "sakkiz ";
                            break;
                        case '9':
                            res += "to'qqiz ";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (nums3[i][0])
                    {
                        case '1':
                            res += "bir ";
                            break;
                        case '2':
                            res += "ikki ";
                            break;
                        case '3':
                            res += "uch ";
                            break;
                        case '4':
                            res += "to'rt ";
                            break;
                        case '5':
                            res += "besh ";
                            break;
                        case '6':
                            res += "olti ";
                            break;
                        case '7':
                            res += "yetti ";
                            break;
                        case '8':
                            res += "sakkiz ";
                            break;
                        case '9':
                            res += "to'qqiz ";
                            break;
                        default:
                            break;
                    }
                }
                switch (i)
                {
                    case 1:
                        if (res != for_zero)
                            res += "ming ";
                        break;
                    case 2:
                        if (res != for_zero)
                            res += "million ";
                        break;
                    case 3:
                        res += "milliard ";
                        break;
                    default:
                        break;
                }
                for_zero = res;
            }
            return res.Trim();
        }
    }
}
