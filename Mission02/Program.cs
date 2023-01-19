using System;
using System.Collections.Generic;

namespace Mission02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DiceGame dg = new DiceGame();

            Console.WriteLine("Welcome to the dice throwing simulator! \r\n\nHow many rolls would you like to simulate? ");

            string sGames = Console.ReadLine();
            int nGames = Convert.ToInt32(sGames);


            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\nTotal number of rolls =  " + sGames +".");

            dg.Game(nGames);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
