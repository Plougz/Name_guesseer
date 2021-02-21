using System;

namespace NameGuesser {
    class Program {
        static void Main(string[] args) {
            int Guesses = 5;
            string UserGuess;
            bool NameFound = false;
            string NameToGuess = "Sofus";

            Console.WriteLine("Welcome to the Name Guesser, the game with a prize pool of absolutely nothing." +
                "\n \nThis is just a stupid program that is made because my teacher Marco said I should. But it's cool.. " +
                "\nAnyway, all you have to do is to guess the name that is hard programmed into this code. You have " + Guesses + " guesses.");

            Console.WriteLine("\n\nEnter your guess:");


            while (!NameFound) {
                UserGuess = Console.ReadLine();

                //If correct  answer
                if (UserGuess.ToLower() == NameToGuess.ToLower()) {
                    Console.WriteLine("Congrats, you've won nothing");
                    NameFound = true;
                    Console.ReadLine();

                    //If incorrect answer
                } else if (!(UserGuess.ToLower() == NameToGuess.ToLower()) && Guesses > 0) {
                    Guesses--;
                    Console.WriteLine("\n\nWRONG! You have " + Guesses + " left \nEnter your guess:");
                }

                //All tries used
                if (Guesses == 0) {
                    Console.WriteLine("Du har brugt alle dine spil, og spillet stopper nu.");
                }
            }
            
            
            
        }
    }
}
