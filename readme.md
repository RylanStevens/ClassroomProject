Final Project

1:
Ultimate asperations for project: 
    In the beginning I was looking for an easy project but I didn't realize how difficult this would end up being. 

Why is this project interesting? 
    I think the games are fun and even though this is a simple version of a game. The idea of using one menu to play many games is very cool to me. I like the idea of it

Actually attempted:
    I ended up getting the whole thing to work even though I didn't end up adding all 10 things I need to. At this point i'm just scared that my code won't work if I try to add the other 3 things. I also tried to make it so you could play a computer in tic tac toe and that ended up breaking the entire code so I just made a 2 player tic tac toe game

Learned: 
    I learned on a higher level of how those interfaces work, how to implement them and how to put multiple files into one project and have it work

2:

Flow Chart
Start
  |
Menu
  |
User input
  |
_______________
|        |        |
RPS     Hang      TTT
  |       |         |
  ___________________
  start game
  end
  exit program

  Psuedocode:
  StartGame
  Make game board
  Loop until game ends:
  display player's turn
  player will enter a row and column
  while the move is invalid: 
  Make player enter valid row and column
  place X or O on board
  If current player wins:
    print player x or o wins
    exit loop
If the board is full:
    print "draw"
    exit loop
switch player x or o
end StartGame


CRC cards:
GameMenu:
    responsibilities:
        -Display game menu options
        -Allow user to select game
        -start the selected game
    Collaborators:
        Rockpaperscissors
        hangman
        tictactoe
        IGame
TicTacToe (class)
    responsibilities:
        manage game logic
        track players turn
        check for win
        display board
    Collaborators:
        tictactoeboard
Tictactoeboard
    responsibilities:
        maintain tictactoe board
        provide functionality for board markers
        check for win or draw 
    Collaborators:
        tictactoe
Rockpaperscissors
    responsibilities:
        Allow choice for both players
        determine outcome
    Collaborators:
        IGame
Hangman
    responsibilities:
       randomly select word
       allow guesses
       display attempts remaining and guessed word
    Collaborators:
       IGame
    
       
    
Required Elements:
    Classes:
        I used classes in pretty much every single file. Mostly throughout the game code.
    Polymorphism:
        The IGame interface is inherited throughout the game code to keep them together. That way the game objects are treated uniformly.
    Fields and Properties:
        
    Generic Methods or classes:
    Interfaces:
    Null:
    Exception Handling:
    
