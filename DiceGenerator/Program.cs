//Spencer Cable
//Project to simulate dice rolls.

using System;

namespace RandomDiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulation!"); //Welcomes the user
            Console.Write("Enter how many dice rolls you desire: ");
            string text;
            text = Console.ReadLine(); //Receives users text for how many dice rolls
            int numDiceRolls = Convert.ToInt32(text);

            int[] array2 = new int[11]; //This indicates that there will be 6 elements in this array, we just don't know what it is yet. 
            //nulls are bad, and these are all nulls.
            for (int iCount = 0; iCount < array2.Length; iCount++) //Changing each instance of the array to be 0
            {
                array2[iCount] = 0;
            }

            Random r = new Random(); //Creates a new instance of random

            for (int i = 0; i < numDiceRolls; i++)
            {

                int roll = r.Next(1, 7); //first dice roll
                int roll2 = r.Next(1, 7); //second dice roll

                int ultimateRoll = roll + roll2; //combines both dice

                array2[ultimateRoll - 2]++; //add 1 to the number rolled
                //array2[roll] = array2[roll] + 1; //These two lines are the same

            }

            string[] starsArray = new string[11]; //creates new array

            for (int i = 0; i < starsArray.Length; i++) // for loop to set new array with the stars
            {
                int numOfAstrix = (array2[i] * 100) / numDiceRolls; //Creates the percent

                if (numOfAstrix > 0)
                {
                    for (int aCount = 0; aCount < numOfAstrix; aCount++)
                    {
                        starsArray[i] = starsArray[i] + "*"; //the amount of * will per 1% will be added.
                    }
                }
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS"); //output
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls = " + numDiceRolls);

            for (int iCount = 0; iCount < starsArray.Length; iCount++) //Changing each instance of the array to be 0
            {
                Console.WriteLine((iCount + 2) + ": " + starsArray[iCount]); //output
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!"); //finish

        }
    }
}
