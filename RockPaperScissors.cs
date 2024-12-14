using System;

namespace ClassroomProject
{
    public class RockPaperScissors : IGame
    {
        public void StartGame()
        {
            Console.WriteLine("=== Rock Paper Scissors ===");
            Console.WriteLine("Choose Rock, Paper or Scissors:");
            string[] choices = { "Rock", "Paper", "Scissors" };
            string? playerChoice = Console.ReadLine();
            if (string.IsNullOrEmpty(playerChoice))
            {
                Console.WriteLine("Invalid input. Please try again.");
                return;
            }
            string computerChoice = choices[new Random().Next(3)];

            Console.WriteLine($"Computer chose: {computerChoice}");

            if (playerChoice == computerChoice)
                Console.WriteLine("It's a tie!");
            else if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                    (playerChoice == "Paper" && computerChoice == "Rock") ||
                    (playerChoice == "Scissors" && computerChoice == "Paper"))
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose!");
        }
    }
}

