using System;
using System.Text;

namespace ConsoleApp6
 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator");
            Console.Write("Enter a line to be translated:"); //Console.Write makes it so the user input will come up next to this sentence
            
            string userSentence = Console.ReadLine(); // Stores the user's sentence

            StringBuilder finalString = new StringBuilder();
            string[] words = userSentence.Split(' '); // THis line makes an array of each individual word through the string
            string vowels = "aeiou";

            for (int i = 0; i < words.Length; i++) // 
            {
                string beginningLetter = words[i].Substring(0, 1);
                string stemOfWords = words[i].Substring(1, words.Length -1);

                if (beginningLetter == vowels)
                {
                    Console.WriteLine(finalString.Append(words[i] + "way"));
                }
                else
                {
                    Console.WriteLine(finalString.Append(stemOfWords + beginningLetter + "ay"));
                }
            }
            for (int b = 0; b < words.Length; b++)
            {
                Console.WriteLine("  " + words[b]);

            }
          
        }
    }
}
