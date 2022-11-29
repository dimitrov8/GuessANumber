using System;

namespace GuessANumber
{
    class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            bool gameLoop = true;
            int tries = 0;

            while (gameLoop)
            {
                Console.Write("Guess a number (1-100): ");
                string palyerInput = Console.ReadLine();
                bool isValid = int.TryParse(palyerInput, out int playerNumber);

                if (isValid)
                {
                    tries++;
                    if (playerNumber == computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You guessed it! After {tries} tries.");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Would you like to play again?");
                        Console.Write("Enter Y or N: ");
                        Console.ResetColor();
                        string playAgain = Console.ReadLine();

                        if (playAgain == "n" || playAgain == "N" || playAgain == "No" || playAgain == "no")
                        {
                            gameLoop = false;
                            return;
                        }
                        else if (playAgain == "y" || playAgain == "Y" || playAgain == "Yes" || playAgain == "yes")
                        {
                            Console.Clear();
                            tries = 0;
                            randomNumber = new Random();
                            computerNumber = randomNumber.Next(1, 101);
                        }
                        else
                        {
                            gameLoop = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice!");
                            Console.ResetColor();
                        }
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input!");
                    Console.ResetColor();
                }
            }
        }
    }
}


