using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02
{
    public class DiceGame
    {
        public void Game(int numRolls)
        {
            //create array for each total amount (2-12)
            Random rnd = new Random();
            int[] total = new int[11];

            //Loop to generate score
            for (int i = 0; i < numRolls; i++)
            {
                //generate random number 1-6 for both dice
                //tally counts for each digit within array
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int score = (dice1 + dice2);
                total[score - 2] += 1;
                score = 0;
            }


            //use loop to generate star amount for each total.
            for(int i = 0; i < total.Length; i++)
            {
                //turn into percentage
                float starAmount = ((total[i] / (float)numRolls) * 100);
                string output = "";
                for (int x = 0; x < starAmount; x++)
                {
                    output += "*";
                }

                //output stars as string
                Console.WriteLine((i + 2) + ": " + output);
            }
        }
    }
}
