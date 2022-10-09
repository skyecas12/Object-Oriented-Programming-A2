using System;
using System.Threading;
using System.Collections.Generic;


namespace DiceGame_Assignment_2_OOP_S.C
{
    class Die
    {
        public string diceGame(int[] UserResult, int[] RobotResult)
        {
            Random dice = new Random();
            Random UserDice;
            Random RobotDice;
            UserDice = dice;
            RobotDice = dice;
            int totalHumanDice = 0;
            int totalRobotDice = 0;
            //While the loop is seen as true, it will keep running the code until
            //the sequence ends, IE score reached as set in the game class.
            try
            {
                //tries the program and prepares a catch for any inaccuracies
                while (true)
                {
                    Console.WriteLine("You have rolled: ");
                    for (int i = 0; i < UserResult.Length; i++)
                    {
                        UserResult[i] = UserDice.Next(1, 7);
                        Console.WriteLine(UserResult[i]);
                        //using a for loop to display all dice that has been rolled from the random variable,
                        //converting it to an array.
                    }
                    Console.WriteLine("");
                    foreach (int i in UserResult)
                    {
                        totalHumanDice += i;
                    }
                    //adding the total numbers together into the totalhuman dice variable via foreach loop
                    Console.WriteLine("total dice counted: " + totalHumanDice);
                    Console.WriteLine("");
                    Thread.Sleep(500);
                    //added a small delay to improve "realism" of the game
                    Console.WriteLine("The Computer has rolled: ");
                    for (int i = 0; i < RobotResult.Length; i++)
                    {
                        RobotResult[i] = RobotDice.Next(1, 7);
                        Console.WriteLine(RobotResult[i]);
                        //using a for loop to display all dice that has been rolled from the random variable,
                        //converting it to an array.
                    }
                    Console.WriteLine("");
                    foreach (int i in RobotResult)
                    {
                        totalRobotDice += i;
                    }
                    //adding the total numbers together into the totalrobot dice variable via foreach loop
                    Console.WriteLine("Robot dice counted: " + totalRobotDice);
                    break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //hnaldes and catches any incorrect errors inside the program.
            return null;
        }
        /*public string HumanReroll(int[] HumanRerollResult)
        {
            Random dice = new Random();
            Random HumanRerollDice;
            HumanRerollDice = dice;
            while(true)
            {
                Console.WriteLine("You have rolled two of a kind, here is the re-roll");
                for(int i = 0; i < HumanRerollResult.Length; i++)
                {
                    HumanRerollResult[i] = HumanRerollDice.Next(1, 7);
                    Console.WriteLine(HumanRerollResult[i]);

                }
                foreach(int i in HumanRerollResult)
                {
                    _ReRollDictionary[i]++;
                }
                int[] storeTwoKind = new int[5];
                for (int i = 1; i < 6; i++)
                {
                    if(_ReRollDictionary[i].Equals(2))
                    {
                        storeTwoKind[i]++;
                    }
                    Console.WriteLine("Store two kind" + storeTwoKind[i]);
                }
                break;
            }
            return null;
        }
        */
        
        /*public string Robotreroll(int[] RobotRerollResult)
        {
            Random dice = new Random();
            Random RobotRerollDice;
            RobotRerollDice = dice;
            while(true)
            {
                Console.WriteLine("The robot dice re-rolled is :");
                for (int i = 0; i < RobotRerollResult.Length; i++)
                {
                    RobotRerollResult[i] = RobotRerollDice.Next(1, 7);
                    Console.WriteLine(RobotRerollResult[i]);
                }
                break;
            }
            return null;
        }
        */

    }
}

