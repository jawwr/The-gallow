using System;
using System.IO;

namespace the_gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = GetWords();
            int health = 8;
            Gallows.Input(word,health);
        }

        static string GetWords()
        {
            string[] words = File.ReadAllLines("words.txt");
            return words[GetWordNumber(words.Length - 1)];
        }

        static int GetWordNumber(int max)
        {
            Random random = new Random();
            return random.Next(0, max);
        }
    }
}