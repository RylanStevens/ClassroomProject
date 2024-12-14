using System;

namespace ClassroomProject
{
    public class Hangman : IGame
    {
        public void StartGame()
        {
            Console.WriteLine("=== Hangman ===");
            string[] words = { "programming", "hangman", "chicken", "pickles" };
            string word = words[new Random().Next(words.Length)];
            char[] guessedWord = new string('_', word.Length).ToCharArray();
            int attempts = 6;

            while (attempts > 0 && guessedWord.Contains('_'))
            {
                Console.WriteLine($"Word: {new string(guessedWord)}");
                Console.Write("Guessed a letter: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || input.Length != 1)
                {
                    Console.WriteLine("No input provided. Please try again.");
                    continue;
                }
                char guess = input[0];

                if (word.Contains(guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess)
                        guessedWord[i] = guess;
                    }
                    Console.WriteLine("Correct!");
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Wrong! Attempts left: {attempts}");
                }
            }

            if (!guessedWord.Contains('_'))
                Console.WriteLine($"You win! The word was {word}.");
            else
                Console.WriteLine($"You lose! The word was {word}");
        }
    }
}