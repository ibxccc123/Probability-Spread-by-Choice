using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A simple probability program to simulate the chances of a map being picked
//from ten choices by four players.  Each player represents a 25% chance for 
//the map to be picked.

namespace Ultimate_Chicken_Horse_Probability
{
    class Program
    {
        static void Main(string[] args)
        {
            double mapA = 0, mapB = 0, mapC = 0, mapD = 0, mapE = 0, mapF = 0, mapG = 0, mapH = 0, mapI = 0, mapJ = 0;  //Local variables must be initialized before used
            double[] mapNumbers = new double[] { mapA, mapB, mapC, mapD, mapE, mapF, mapG, mapH, mapI, mapJ };  //Must be double type for calculating probability
            int playerOneChoice = 0, playerTwoChoice = 0, playerThreeChoice = 0, playerFourChoice = 0;
            int[] playerChoices = new int[] { playerOneChoice, playerTwoChoice, playerThreeChoice, playerFourChoice };
            List<int> listOfPossibleMaps = new List<int>();
            for (int i = 0; i < 4; i++){
                Console.WriteLine("Player " + (i + 1) + ", choose a map from 0 to 9.");  //(i+1) for Player 0 to be Player 1, Player 1 to be Player 2, etc.
                playerChoices[i] = int.Parse(Console.ReadLine());
                mapNumbers[playerChoices[i]] += 25; //Each player's choice is worth 25% of the total probability
            }
            for (int i = 0; i < 10; i++)
            {
                if (mapNumbers[i] > 0)
                {
                    listOfPossibleMaps.Add(i);
                }
            }



                //Output testing
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Value of Player Choice " + (i + 1) + ":" + playerChoices[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of Map " + i + ":" + mapNumbers[i]);
            }

            //Random number generation
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            Console.WriteLine(randomNumber);



            Console.ReadLine();
        }
    }
}
