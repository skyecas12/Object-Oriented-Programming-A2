using System;
using System.Collections.Generic;


namespace DiceGame_Assignment_2_OOP_S.C
{
    class Game
    {
        Dictionary<int, int> _HumanDiceDictionary;
        Dictionary<int, int> _RobotDiceDictionary;
        //Creating dictionary for the classes below
        public Game()
        {
            _HumanDiceDictionary = new Dictionary<int, int>()
            {
                {1, 0},
                {2, 0},
                {3, 0},
                {4, 0},
                {5, 0},
                {6, 0},
                //Dictionary for the human dice
            };
            _RobotDiceDictionary = new Dictionary<int, int>()
            {
                {1, 0},
                {2, 0},
                {3, 0},
                {4, 0},
                {5, 0},
                {6, 0},
                //Dictionary for the human dice
            };
        }
        private int _RobotScore;
        public int RobotScore
        {
            //Using get and set to grab a private int through encapsulation.
            get { return _RobotScore; }
            set
            {
                if(value.Equals(0))
                {
                    _RobotScore = value;
                    //Value is pre-set at 0 here
                }
                else
                {
                    value = 0;
                }
            }
        }
        private int _UserScore;
        public int PlayerScore
        {
            //Using get and set to retrieve data from the encapsulated int (private int _UserScore.
            get { return _UserScore; }
            set
            {
                if(value.Equals(0))
                {
                    _UserScore = value;
                }
                else
                {
                    value = 0;
                }
            }
        }
        Dictionary<int, int> GetRobotDict
        {
            get { return _RobotDiceDictionary; }
            set
            {
                if (value.Equals(1) || value.Equals(2) || value.Equals(3) || value.Equals(4) || value.Equals(5)
                    || value.Equals(6))
                {
                    _HumanDiceDictionary = value;
                }
                else
                {
                    value = null;
                }
                //Using get and set to pre-set the values to only have set values in the parameter.
            }
        }
        Dictionary<int, int> GetHumanDict
        {
            get { return _HumanDiceDictionary; }
            set { 
                if (value.Equals(1) || value.Equals(2) || value.Equals(3) || value.Equals(4) || value.Equals(5)
                    || value.Equals(6))
                {
                    _HumanDiceDictionary = value;
                }
                else
                {
                    value = null;
                }
                //Using get and set to pre-set the values to only have set values in the parameter.
            }
        }
        public string RandomGameDice()
        {
            Die Dice = new Die();
            Player playerturn = new Player();
            int[] UserResult = new int[5];
            int[] RobotResult = new int[5];
            //int[] ReRollDIce = new int[5];
            //Declaring array variables of fixed size
            try
            {
                Console.WriteLine("Press r key to continue rolling dice!");
                var userChoice = Console.ReadLine();
                userChoice.ToLower();
                if (userChoice.Equals("r"))
                {
                    //If the user enters the key "r", the game will initiate and 
                    while (_RobotScore < 50 || _UserScore < 50)
                    {
                        Dice.diceGame(UserResult, RobotResult);
                        foreach (int i in UserResult)
                        {
                            //populates the dictionary from the UserResults
                            GetHumanDict[i]++;
                        }
                        foreach (int i in RobotResult)
                        {
                            //populates the robot dictionary from the RobotResults
                            GetRobotDict[i]++;
                        }
                        //printing user and robot dictionary in a for loop, to show each number key and how many times that was rolled per turn.
                        Console.WriteLine("Below is player dice printed for the user roll");
                        foreach (var i in GetHumanDict)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Below is robot dice rolled printed from the dictionary.");
                        foreach (var i in GetRobotDict)
                        {
                            Console.WriteLine(i);
                        }
                        for (int i = 1; i < 7; i++)
                        {

                            if (GetHumanDict[i].Equals(3))
                            {
                                _UserScore = _UserScore + 3;
                                //if the dict contains 3 of same values, increment score by 3
                            }
                            else if (GetHumanDict[i].Equals(4))
                            {
                                _UserScore = _UserScore + 6;
                                //if the dict contains 4 of same values, increment score by 6
                            }
                            else if (GetHumanDict[i].Equals(5))
                            {
                                _UserScore = _UserScore + 12;
                                //if the dict contains 4 of same values, increment score by 12
                            }
                            else if (GetHumanDict[i].Equals(2) && GetHumanDict[i] != 3)
                            {
                                Console.WriteLine("Two of a kind has appeared for You!");
                            }

                            if (GetRobotDict[i].Equals(3))
                            {
                                _RobotScore = _RobotScore + 3;
                                //if the dict contains 3 of same values, increment score by 3
                            }
                            else if (GetRobotDict[i].Equals(4))
                            {
                                _RobotScore = _RobotScore + 6;
                                //if the dict contains 4 of same values, increment score by 6
                            }
                            else if (GetRobotDict[i].Equals(5))
                            {
                                _RobotScore = _RobotScore + 12;
                                //if the dict contains 5 of same values, increment score by 12
                            }
                            else if(GetRobotDict[i].Equals(2) && GetRobotDict[i] != 3)
                            {
                                Console.WriteLine("two of a kind appeared for Robot!");
                            }
                        }
                        Console.WriteLine("User points are: " + _UserScore);
                        Console.WriteLine("The robots points are: " + _RobotScore);
                        if (_UserScore >= 50 & _RobotScore < 50)
                        {
                            Console.WriteLine("User has beaten robot!");
                            Console.WriteLine("Please press any key to exit the game!");
                            System.Environment.Exit(0);
                            //if users score is greater than 50 or equal to it, and robot score is lower, then user wins
                            break;
                        }
                        else if (_RobotScore >= 50 & _UserScore < 50)
                        {
                            Console.WriteLine("robot has beaten the User!");
                            Console.WriteLine("Please press any key to exit the game!");
                            System.Environment.Exit(0);
                            //if robot score is greater than or equal to 50 and user score is less than 50, then the robot score wins.
                            break;
                        }
                        else if (_UserScore == 50 && _RobotScore == 50)
                        {
                            Console.WriteLine("Draw! Both User and Robot have hit the score limit");
                            Console.WriteLine("Please press any key to exit the game!");
                            System.Environment.Exit(0);
                            //If both scores from use and robot equal 50, then it is a draw and the game ends.
                            break;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            GetHumanDict[1] = 0;
                            GetHumanDict[2] = 0;
                            GetHumanDict[3] = 0;
                            GetHumanDict[4] = 0;
                            GetHumanDict[5] = 0;
                            GetHumanDict[6] = 0;
                            //reset all the dictionary keys value containing a number reset to 0 after each turn for next roll -
                            //for the user.
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            GetRobotDict[1] = 0;
                            GetRobotDict[2] = 0;
                            GetRobotDict[3] = 0;
                            GetRobotDict[4] = 0;
                            GetRobotDict[5] = 0;
                            GetRobotDict[6] = 0;
                            //reset all the dictionary keys value containing a number reset to 0 after each turn for next roll-
                            //for the robot.
                        }
                        break;
                        //ends the loop and goes again until one of the score condition has been met.
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Incorrect input occured, please re-enter input");
            }
            //catches any errors and displays a message.
            return null;
        }
    }
}
