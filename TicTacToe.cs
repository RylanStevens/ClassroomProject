using System;

namespace ClassroomProject
{
    public class TicTacToe : IGame
    {
        private TicTacToeBoard _board;
        private string _currentPlayer;

        public TicTacToe()
        {
            _board = new TicTacToeBoard();
            _currentPlayer = "X";  
        }
        public void Start()
        {
            StartGame();
        }

        public void StartGame()
        {
            bool gameWon = false;

            while (!gameWon)
            {
                _board.Display();
                Console.WriteLine("Player {0}, it's your turn!", _currentPlayer);

                int row = -1, col = -1;
                bool validMove = false;

                while (!validMove)
                {
                    Console.Write("Enter row (0-2): ");
                    row = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter column (0-2): ");
                    col = Convert.ToInt32(Console.ReadLine());

                    validMove = _board.PlaceMarker(row, col, _currentPlayer);
                    if (!validMove)
                    {
                        Console.WriteLine("Invalid move, try again.");
                    }
                }

                if (_board.CheckWin(_currentPlayer))
                {
                    _board.Display();
                    Console.WriteLine("Player {0} wins!", _currentPlayer);
                    gameWon = true;
                }
                else if (_board.CheckDraw())
                {
                    _board.Display();
                    Console.WriteLine("It's a draw!");
                    gameWon = true;
                }
                else
                {
                    _currentPlayer = (_currentPlayer == "X") ? "O" : "X";  
                }
            }
        }
    }

    public class TicTacToeBoard
    {
        public string[,] Cells { get; private set; } = new string[3, 3];

        public TicTacToeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Cells[i, j] = " ";  
                }
            }
        }

        public void Display()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" {0} | {1} | {2} ", Cells[i, 0], Cells[i, 1], Cells[i, 2]);
                if (i < 2)
                    Console.WriteLine("---|---|---");
            }
        }

        public bool PlaceMarker(int row, int col, string marker)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2 || Cells[row, col] != " ")
                return false;

            Cells[row, col] = marker;
            return true;
        }

        public bool CheckWin(string marker)
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (Cells[i, 0] == marker && Cells[i, 1] == marker && Cells[i, 2] == marker) return true;
                if (Cells[0, i] == marker && Cells[1, i] == marker && Cells[2, i] == marker) return true;
            }

            if (Cells[0, 0] == marker && Cells[1, 1] == marker && Cells[2, 2] == marker) return true;
            if (Cells[0, 2] == marker && Cells[1, 1] == marker && Cells[2, 0] == marker) return true;

            return false;
        }

        public bool CheckDraw()
        {
            foreach (var cell in Cells)
            {
                if (cell == " ") return false;
            }
            return true;
        }
    }


}
