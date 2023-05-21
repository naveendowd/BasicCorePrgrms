using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrgrms
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Select a program to run");
                Console.WriteLine("1.Even or odd\n2.Prime factors\n3.Flip The Coin\n4.Harmonic\n5.Leap Year\n" +
                    "6.Quotient and Remainder\n7.Swapping the numbers\n8.Power of 2\n9.Check vowel or consonent\n10.Largest among 3 numebers");
                int programNum = Convert.ToInt32(Console.ReadLine());
                switch (programNum)
                {
                    case 1:
                        FlipCoin.CoinFlip();
                        break;
                    case 2:
                        Factors.PrimeFactor();
                        break;
                    case 3:
                        FlipCoin.CoinFlip();
                        break;
                    case 4:
                        HarmonicNumber.Harmicnumber();
                        break;
                    case 5:
                        LeapYear.Leapyear();
                        break;
                    case 6:
                        QuotientReminder.FindQuotientAndReminder();
                        break;
                    case 7:
                        Swap2Numbers.DisplaySwapTwoNumbers();
                        break;
                    case 8:
                        Powerof2.Power2();
                        break;
                    case 9:
                        VowelorConsonent.CheckVowelOrConsonant();
                        break;
                    case 10:
                        LargestofThree.FindLargestNumber();
                        break;
                    default:
                        Console.WriteLine("Xrong input, Please try again");
                        break;
                }
            }
        }
    }