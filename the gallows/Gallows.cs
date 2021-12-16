using System;
using System.Collections.Generic;

namespace the_gallows
{
    public class Gallows
    {
        public static void Input(string word, int health)
        {
            DrawWords(word, new List<char>(),health);
            char input;
            List<char> letter = new List<char>();
            bool end = false;
            do
            {
                input = char.Parse(Console.ReadLine());
                if (word.Contains(input, StringComparison.OrdinalIgnoreCase))
                    letter.Add(input);
                else
                    health--;
                
                DrawWords(word, letter, health);
                if (health == 0) 
                { 
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            } while (!end);
        }

        static void DrawWords(string word,List<char> letters, int health)
        {
            Console.Clear();
            string newword = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                newword += letters.Contains(word[i])
                    ? word[i]
                    : '_';
            }
            Console.WriteLine(newword);
            Console.WriteLine($"Жизни:{health}");
        }
    }
}