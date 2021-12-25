using System;
using System.Collections.Generic;

namespace the_gallows
{
    public class Gallows
    {
        public static void Input(Gallow gallow)
        {
            string word = gallow.GetWord();
            char input;
            List<char> letter = new List<char>();
            string newword = GenerateWords(word, letter);
            DrawGallow(newword, gallow.GetHealth());
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
                    gallow.Mistake();
                }
                newword = GenerateWords(word, letter);
                DrawGallow(newword, gallow.GetHealth());
                if (gallow.GetHealth() == 0) 
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

        static void DrawGallow(string word, int health)
        {
            Console.Clear();
            Console.WriteLine(word);
            Console.WriteLine($"Жизни:{health}");
        }
    }
}