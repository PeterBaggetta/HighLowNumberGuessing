# High/Low Number Guessing Game

**High/Low Number Guessing Game** is a simple C# application where the player tries to guess a randomly generated number between 1 and 100.  
The program provides hints and limits the number of guesses, making it both fun and challenging.  

## Features
- **Random number generation**: Secret number is chosen randomly between 1 and 100 (inclusive).  
- **Guess limit**: Player has 7 attempts per round to guess correctly.  
- **Hint system**:  
  - Informs if a guess is *too high* or *too low*.  
  - Warns when the player is *within 5 digits* of the correct answer.  
- **Win/Loss detection**: Victory when guessed correctly or reveals the number if all guesses are used.  
- **Replay option**: Player can choose to play multiple rounds without restarting the program.  

## How It Works
1. The program greets the player and starts a new round.  
2. A random secret number between 1 and 100 is generated.  
3. The player has up to **7 guesses** to find the number.  
   - Each guess is compared to the secret number.  
   - The program provides feedback: *too high*, *too low*, or *close*.  
4. If the player guesses correctly, they win. Otherwise, the correct number is shown.  
5. At the end of each round, the player is asked if they want to play again.  

## Purpose
This project was developed for educational purposes to practice:  
- Writing interactive command-line applications in C#  
- Using loops and conditionals for game logic  
- Implementing random number generation  
- Tracking game state (win/loss, remaining guesses)  
- Handling user input and replay functionality  
