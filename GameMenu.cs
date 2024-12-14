using System;
using System.Collections.Generic;
using ClassroomProject;

namespace ClassroomProject
{
    public class GameMenu  
    {
        private List<IGame> games;

        public GameMenu()
        {
            
            games = new List<IGame>
            {
                new RockPaperScissors(),
                new Hangman(),  
                new TicTacToe()  
            };
        }

        public void DisplayMenu()
        {
            Console.WriteLine("=== Game Menu ===");
            Console.WriteLine("1. Rock Paper Scissors");
            Console.WriteLine("2. Hangman");
            Console.WriteLine("3. Tic Tac Toe");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select a game (1-4): ");
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string? choice = Console.ReadLine();
                if (choice == null)
                {
                    Console.WriteLine("No input privided.");
                    return;
                }
                switch (choice)
                {
                    case "1":
                        games[0].StartGame();
                        break;
                    case "2":
                        games[1].StartGame();
                        break;
                    case "3":
                        games[2].StartGame();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the game menu.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
