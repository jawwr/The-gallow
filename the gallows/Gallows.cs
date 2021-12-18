using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace the_gallows
{
    public class Gallows
    {
        public static void Input(string word, int health)
        {
            
            char input;
            List<char> letter = new List<char>();
            string newword = GenerateWords(word, letter);
            DrawGallow(health, newword);
            bool end = false;
            do
            {
                input = char.Parse(Console.ReadLine());
                if (word.Contains(input, StringComparison.OrdinalIgnoreCase))
                {
                    if(!letter.Contains(input))
                        letter.Add(input);
                }
                else
                {
                    health--;
                }
                newword = GenerateWords(word, letter);
                DrawGallow(health, newword);
                if (health == 0) 
                { 
                    Console.WriteLine("Вы проиграли");
                    Console.WriteLine($"Слово {word}");
                    break;
                }

                if (newword == word)
                {
                    Console.WriteLine("Вы выиграли");
                    end = true;
                }
            } while (!end);

            
        }

        static string GenerateWords(string word,List<char> letters)
        {
            string newword = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                newword += letters.Contains(word[i])
                    ? word[i]
                    : '_';
            }

            return newword;
        }

        static void DrawGallow(int health, string word)
        {
            Console.Clear();
            Console.WriteLine(word);
            Console.WriteLine($"Жизни:{health}");
        }
    }
}