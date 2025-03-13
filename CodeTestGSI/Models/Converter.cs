using System;
using System.Collections.Generic;

namespace CodeTestGSI.Models
{
    public class Converter
    {
        public static List<int> ConvertTextToNumbers(string text)
        {
            Dictionary<char, int> charToNumberMap = new Dictionary<char, int>()
            {
                {'A', 0}, {'B', 1}, {'C', 1}, {'D', 1}, {'E', 2},
                {'F', 3}, {'G', 3}, {'H', 3}, {'I', 4}, {'J', 5},
                {'K', 5}, {'L', 5}, {'M', 5}, {'N', 5}, {'O', 6},
                {'P', 7}, {'Q', 7}, {'R', 7}, {'S', 7}, {'T', 7},
                {'U', 8}, {'V', 9}, {'W', 9}, {'X', 9}, {'Y', 9},
                {'Z', 9}, {' ', 0},

                {'a', 9}, {'b', 8}, {'c', 8}, {'d', 8}, {'e', 7},
                {'f', 6}, {'g', 6}, {'h', 6}, {'i', 5}, {'j', 4},
                {'k', 4}, {'l', 4}, {'m', 4}, {'n', 4}, {'o', 3},
                {'p', 2}, {'q', 2}, {'r', 2}, {'s', 2}, {'t', 2},
                {'u', 1}, {'v', 0}, {'w', 0}, {'x', 0}, {'y', 0},
                {'z', 0}
            };

            List<int> result = new List<int>();
            foreach (char c in text)
            {
                if (charToNumberMap.ContainsKey(c))
                {
                    result.Add(charToNumberMap[c]);
                }
            }
            return result;
        }

        public static string CalculateAlternatingSum(List<int> numbers, out int finalResult)
        {
            int total = numbers[0];
            string process = total.ToString();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (i % 2 == 1) // Index ganjil: Tambah
                {
                    total += numbers[i];
                    process += " + " + numbers[i];
                }
                else // Index genap: Kurangi
                {
                    total -= numbers[i];
                    process += " - " + numbers[i];
                }
            }

            process += " = " + total;
            finalResult = Math.Abs(total);
            return process;
        }

        public static string GenerateIncrementalSeriesWithLetters(int target)
        {
            Dictionary<int, char> numberToLetterMap = new Dictionary<int, char>()
            {
                {0, 'A'}, {1, 'B'}, {2, 'E'}, {3, 'F'}, {4, 'I'},
                {5, 'J'}, {6, 'O'}, {7, 'P'}, {8, 'U'}, {9, 'V'}
            };

            List<string> letterSequence = new List<string>();
            int sum = 0, i = 0;

            while (sum + i <= target)
            {
                letterSequence.Add(numberToLetterMap[i].ToString());
                sum += i;
                i++;
            }

            while (sum < target)
            {
                letterSequence.Add("A");
                letterSequence.Add("B");
                sum += 1;
            }

            return string.Join(" ", letterSequence);
        }

        public static string ConvertFinalOutput(string step3Result)
        {
            List<string> letters = new List<string>(step3Result.Split(' '));

            if (letters.Count >= 2)
            {
                int lastIndex = letters.Count - 1;
                int secondLastIndex = letters.Count - 2;

                if (letters[lastIndex] == "B")
                {
                    letters[secondLastIndex] = "B";
                    letters[lastIndex] = "E";
                }
                else
                {
                    letters[lastIndex] = "E";
                }
            }

            return string.Join(" ", letters);
        }

        public static List<int> ConvertToFinalNumbers(string step4Output)
        {
            Dictionary<char, int> charToNumberMap = new Dictionary<char, int>()
            {
                {'A', 1}, {'B', 1}, {'E', 3}, {'F', 3}, {'I', 5},
                {'J', 5}, {'O', 7}, {'P', 7}, {'U', 9}, {'V', 9}
            };

            List<int> finalNumbers = new List<int>();
            string[] letters = step4Output.Split(' ');

            foreach (string letter in letters)
            {
                if (letter.Length == 1 && charToNumberMap.ContainsKey(letter[0]))
                {
                    finalNumbers.Add(charToNumberMap[letter[0]]);
                }
            }

            return finalNumbers;
        }
    }
}
