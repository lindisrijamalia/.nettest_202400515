using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsoleApp
{
    public class WordCounter
    {
        public static int CountWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return 0;

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    public class ArrayUtils
    {
        public static int FindMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array tidak boleh kosong");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }

        public static int[] SortArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array tidak boleh kosong");

            Array.Sort(numbers);
            return numbers;
        }
    }

    public class StringUtils
    {
        public static char FindMostFrequentChar(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("Kata tidak boleh kosong");

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            return frequency.OrderByDescending(x => x.Value).First().Key;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test fungsi CountWords
            string sentence = "Halo, nama saya John Doe";
            int wordCount = WordCounter.CountWords(sentence);
            Console.WriteLine($"Soal 1 : Jumlah kata: {wordCount}");

            // Test fungsi FindMax
            int[] numbers = { 1, 5, 3, 7, 2 };
            int maxNumber = ArrayUtils.FindMax(numbers);
            Console.WriteLine($"Soal 2 : Angka terbesar: {maxNumber}");

            // Test fungsi SortArray
            int[] unsortedNumbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = ArrayUtils.SortArray(unsortedNumbers);
            Console.WriteLine("Soal 3 : Array setelah diurutkan: " + string.Join(", ", sortedNumbers));

            // Test fungsi FindMostFrequentChar
            string word = "hello";
            char mostFrequentChar = StringUtils.FindMostFrequentChar(word);
            Console.WriteLine($"Soal 4 : Huruf yang paling sering muncul: {mostFrequentChar}");

            // Tambahkan ini agar konsol tetap terbuka sampai Anda menekan Enter
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
