using System;


namespace DiceGame_Assignment_2_OOP_S.C
{
    class Player
    {
        public string PlayerGenerator()
        {
            //created a player class to allow the user to enter their player name within the game.
            Console.WriteLine("Please enter a Player name");
            string player1 = Console.ReadLine();
            Console.WriteLine("Okay, " + player1 + ", press R to begin the game");
            return null;
        }
    }
}
