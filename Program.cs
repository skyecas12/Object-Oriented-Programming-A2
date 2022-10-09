using System;

namespace DiceGame_Assignment_2_OOP_S.C
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerturn = new Player();
            Game Gameplay = new Game();
            playerturn.PlayerGenerator();
            //initiates the program to start the game, the player will enter their name, and then begin to start rolling dice
            //once entered their name and pressed r key to begin.
            while (true)
            {
                Gameplay.RandomGameDice();
            }

        }
    }
}
