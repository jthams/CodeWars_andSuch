using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboards
{
    public class CodeWars
    {
        static void Main(string[] args)
        {
            Solution("wait", "ait");

            Console.Read();

        }

        //FIND THE ANGLE ON A CLOCK WITH A GIVEN TIME 
        public static double clockAngle(int hr, int mm)
        {
            double hrAngle = hr * (360 / 12);
            double minAngle = mm * (360 / 60);

            double difference = Math.Abs(hrAngle - minAngle);
            Console.WriteLine(difference);
            return difference;
        }
        //ROTATE AN ARRAY
        public static bool Rotate(char dir, int push, params int[] x)
        {
            int[] rotatedArray = new int[x.Length];
            if (x == null || x.Length >= 0)
            {
                return false;
            }

            for (int i = 0; i < x.Length - 1; i++)
            {
                if (Char.ToLower(dir) == 'r' && x[i + push] > (x.Length - 1))
                {
                    rotatedArray[i] = x[i - (x.Length - 1)];
                }
                else if (Char.ToLower(dir) == 'r' && x[i + push] <= (x.Length - 1))
                {
                    rotatedArray[i] = x[i];
                }
                else if (Char.ToLower(dir) == 'l' && x[i - push] > x[0])
                {
                    rotatedArray[i] = x[i - push];
                }
            }
            foreach (var item in rotatedArray)
            {
                Console.WriteLine(item);
            }
            return true;

        }
        //REVERSE THE ORDER OF A STRING
        public static string reverseString(string phrase)
        {

            string outputPhrase = "";
            for (int i = (phrase.Length - 1); i >= 0; i--)
            {
                outputPhrase += phrase[i];
            }
            Console.WriteLine(outputPhrase);
            return outputPhrase;

        }
        //TURN A PHRASE INTO camelCase
        public string camelCase(string phrase)
        {
            phrase = phrase.TrimStart();
            string outputString = "";

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ')
                {
                    outputString += char.ToUpper(phrase[(i + 1)]);

                }
                else
                {
                    outputString += phrase[i];
                }
            }
            Console.WriteLine(outputString);

            return outputString;
        }
        //Find the sum of the 2 smallest even integers in a given array
        public static int sumTwoSmallestNumbers(int[] numbers)
        {

            Array.Sort(numbers);
            int sum = numbers[0] + numbers[1];

            return sum;
        }
        // //REMOVING THE VOWELS FROM A STRING
        public static string Disemvowel(string str)
        {
            string vowels = "aeiou";
            string newStr = " ";

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]) == false)
                {
                    newStr += str[i];

                }
            }
            Console.Write(newStr.ToString());

            return str;
        }
        // Sort an array of strings alphabetically
        public static string firstName(string x)
        {
            string p = x.ToLower();
            char[] y = p.ToCharArray();
            for (int i = 0; i < y.Length - 1; i++)
            {
                for (int j = 0; j < y.Length - 1; j++)
                {
                    if (y[j] >= y[j + 1])
                    {
                        char temp = 'a';
                        y[j] = y[j + 1];
                        temp = y[j + 1];
                    }
                }
            }
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(y.ToString());

            return y.ToString();
        }
        //Create a Morse code dictionary
        public static Dictionary<char, string> MorseAlphabet = new Dictionary<char, string>()
        {
            {'a', ".-" },
            {'b', "-..." },
            {'c', "-.-." },
            {'d', "-.." },
            {'e', "." },
            {'f', "..-." },
            {'g', "--." },
            {'h', "...." },
            {'i', ".." },
            {'j', ".---" },
            {'k', "-.-" },
            {'l', ".-.." },
            {'m', "--" },
            {'n', "-." },
            {'o', "---" },
            {'p', ".--." },
            {'q', "--.-" },
            {'r', ".-." },
            {'s', "..." },
            {'t', "-" },
            {'u', "..-" },
            {'v', "...-" },
            {'w', ".--" },
            {'x', "-..-" },
            {'y', "-.--" },
            {'z', "--.." },
            {' ', "-------" }
        };
        //Translate Morse code
        public static StringBuilder translate(string plaintext)
        {
            StringBuilder cyphertext = new StringBuilder();
            foreach (var item in plaintext)
            {
                cyphertext.Append(MorseAlphabet[item]);
            }
            Console.WriteLine(cyphertext);
            return cyphertext;
        }
        public static bool checkSum(int x)
        {
            int[] xArray = new int[x.ToString().Length];
            int temp = x;
            for (int i = 0; i < xArray.Length; i++)
            {
                xArray[i] = temp % 10;
                temp /= 10;
            }
            Console.WriteLine(xArray.Sum());
            if (xArray.Sum() > 9)
            {
                return checkSum(xArray.Sum());
            }
            else
            {
                return true;
            }
        }

        public static void Distinct(string input)
        {
            Dictionary<char, int> Alphabet = new Dictionary<char, int>()
            {
            {'a',0}, {'b',0}, {'c',0}, {'d',0}, {'e',0}, {'f',0}, {'g',0}, {'h',0}, {'i',0}, {'j',0}, {'k',0}, {'l',0}, {'m',0}, {'n',0}, {'o',0}, {'p',0}, {'q',0}, {'r',0}, {'s',0},
             {'t',0}, {'u',0}, {'v',0}, {'w',0}, {'x',0}, {'y',0}, {'z',0}
            };

            foreach (char item in input.ToLower())
            {
                Alphabet[item] = Alphabet[item] + 1;
            }
            foreach (KeyValuePair<char, int> pairs in Alphabet)
            {
                if (pairs.Value > 0)
                {
                    Console.WriteLine(pairs.ToString());
                }
            }


        }
        // Finding complimentary pairs(like DNA)
        public static string MakeComplement(string dna)
        {
            string dnaCompliment = String.Empty;
            // ASSUMPTIONS: A and T , C and G are compliments
            Dictionary<char, char> complements = new Dictionary<char, char>()
            {
                {'A','T'},{'T','A'},
                {'C','G'},{'G','C'}
            };
            foreach (var item in dna.ToUpper())
            {
                dnaCompliment += complements[item];
            }
            Console.WriteLine(dnaCompliment);
            return dnaCompliment;
        }
        //TODO: complete this
        public static int[] FoldArray(int[] array, int runs)
        {
            //The array will always contain numbers and will never be null. 
            //The parameter runs will always be a positive integer greater than 0 
            //and says how many runs of folding your method has to do.
            int runss = runs;
            int[] arrayCopy = new int[array.Length];
            if (arrayCopy.Length%2 != 0)
            {
                 for (int i = 0; i < arrayCopy.Length / 2; i++)
                 {
                     int temp = arrayCopy.Reverse().ToArray()[i];
                     arrayCopy[i] = arrayCopy[i] += temp;
                 }
                 

            }
            foreach (var item in arrayCopy)
            {
                Console.WriteLine(item);
            }
            
            return new int[] { 0 };
        }
        public static bool Solution(string str, string ending)
        {
            if (ending.Length > str.Length)
            {
                return false;
            }
            string returnstring = String.Empty;
            int iValue = str.Length - ending.Length;
            for (int i = iValue; i < str.Length; i++)
            {
                returnstring += str[i];
            }
            
            if (returnstring.ToLower() == ending.ToLower())
            {
                return true;
            }
           
            return false;
        }
        
    }
}



