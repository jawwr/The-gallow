using System;
using System.IO;
using System.Net.NetworkInformation;

namespace the_gallows
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Gallow gallow = new Gallow(GetWords());
            Gallows.Input(gallow);
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