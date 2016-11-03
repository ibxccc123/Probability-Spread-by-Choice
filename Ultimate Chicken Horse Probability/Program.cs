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
            //mapNumbers is an array where the index represents the map and its value is the probability of the map being chosen 
            int playerOneChoice = 0, playerTwoChoice = 0, playerThreeChoice = 0, playerFourChoice = 0;
            int[] playerChoices = new int[] { playerOneChoice, playerTwoChoice, playerThreeChoice, playerFourChoice };
            List<int> listOfPossibleMaps = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ", choose a map from 0 to 9.");  //(i+1) for Player 0 to be Player 1, Player 1 to be Player 2, etc.
                playerChoices[i] = int.Parse(Console.ReadLine());
                mapNumbers[playerChoices[i]] += 25; //Each player's choice is worth 25% of the total probability
                //TODO: make it so that if there is a different number of players than 4, then the coding does not need to be overwritten heavily
                //This also involves having this function take in an argument for the number of players, or an argument for the array of players 
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
            int randomNumber = rnd.Next(0, 99);
            Console.WriteLine(randomNumber);

            double probFloor = 0; //Stop when this reaches the maximum percentage(100)
            int counter = 0; //The incrementing index for listOfPossibleMaps, which is the index for mapNumbers
            int pickedMap = 0;  //Uninitialized variable for the map that is picked randomly
            while (probFloor != 100)
            { //While(true) should work, as the else condition should be fulfilled before counter reaches an index out of range  
                if ((randomNumber > (probFloor + mapNumbers[listOfPossibleMaps[counter]] - 1)) || //The decrement by 1 is there because RNG goes from 0-99, not 1-100
                    (randomNumber < probFloor))
                { //The random number is not in the given range for the map's probability
                    counter++;
                    probFloor += mapNumbers[listOfPossibleMaps[counter]];
                    continue;
                }
                else
                { //The random number is between probFloor+mapNumbers[...] and probFloor, and is therefore within the current map's probability
                    pickedMap = counter;
                    break;
                }
            }

            Console.WriteLine("The selected map is: Map " + listOfPossibleMaps[pickedMap] + ".  The random number was " + randomNumber);



            Console.ReadLine();
        }
    }
}
