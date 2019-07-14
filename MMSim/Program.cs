using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchMadness
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize counting variables for tuning weight parameters.
            double dukewins = 0;
            double michiganstwins = 0;
            double lsuwins = 0;
            double virginiatechwins = 0;
            double mississippistwins = 0;
            double marylandwins = 0;
            double louisvillewins = 0;
            double vcuwins = 0;
            double ucfwins = 0;
            double minnesotawins = 0;
            double belmontwins = 0;
            double libertywins = 0;
            double saintlouiswins = 0;
            double yalewins = 0;
            double bradleywins = 0;
            double northdakotastwins = 0;

            double scoringOffenseWeight = 0.01;      // weight for scoring offense.
            double scoringDefenseWeight = 0.01;      // weight for scoring defense.
            double assistsPerGameWeight = 0.5;      // weight for assists per game.
            double reboundsPerGameWeight = 0.01;     // weight for rebounds per game.
            double seedWeight = 0.01;                // weight for seed.
            Random randomnum = new Random();        // create random object to draw random numbers from.

            //Region of 16 teams.
            Team duke = new Team("Duke", 82.7, 67.8, 15.9, 41.2, 1);                        // create team
            Team michiganst = new Team("Michigan St", 77.9, 65.1, 18.4, 40.6, 2);           // create team
            Team lsu = new Team("LSU", 80.4, 73.1, 12.9, 38.7, 3);                          // create team
            Team virginiatech = new Team("Virgina Tech", 73.5, 62.1, 15.2, 32.6, 4);        // create team
            Team mississippist = new Team("Mississippi St", 77.3, 70.4, 14.3, 35.7, 5);     // create team
            Team maryland = new Team("Maryland", 71.4, 65.5, 13.1, 39.3, 6);                // create team
            Team louisville = new Team("Louisville", 74.6, 68.4, 13.5, 38.1, 7);            // create team
            Team vcu = new Team("VCU", 71.0, 61.9, 13.6, 36.7, 8);                          // create team
            Team ucf = new Team("UCF", 72.3, 64.5, 13.3, 36.8, 9);                          // create team
            Team minnesota = new Team("Minnesota", 70.6, 69.4, 14.5, 36.5, 10);             // create team
            Team belmont = new Team("Belmont", 86.9, 73.9, 19.5, 38.6, 11);                 // create team
            Team liberty = new Team("Liberty", 73.7, 61.4, 14.8, 32.6, 12);                 // create team
            Team saintlouis = new Team("Saint Louis", 67.0, 64.1, 12.8, 39.7, 13);          // create team
            Team yale = new Team("Yale", 80.3, 73.0, 17.0, 38.9, 14);                       // create team
            Team bradley = new Team("Bradley", 66.5, 65.3, 12.1, 34.1, 15);                 // create team
            Team northdakotast = new Team("North Dakota St", 73.0, 72.6, 11.5, 31.5, 16);   // create team



            for (int i = 0; i < 10000; i++) // Simulate 10000 tourneys
            {

                Team champ1 = PlayGame(duke, northdakotast, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ2 = PlayGame(vcu, ucf, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ3 = PlayGame(mississippist, liberty, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ4 = PlayGame(virginiatech, saintlouis, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ5 = PlayGame(maryland, belmont, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ6 = PlayGame(lsu, yale, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ7 = PlayGame(louisville, minnesota, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ8 = PlayGame(michiganst, bradley, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ9 = PlayGame(champ1, champ2, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ10 = PlayGame(champ3, champ4, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ11 = PlayGame(champ5, champ6, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ12 = PlayGame(champ7, champ8, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ13 = PlayGame(champ9, champ10, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ14 = PlayGame(champ11, champ12, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner
                Team champ15 = PlayGame(champ13, champ14, scoringOffenseWeight, scoringDefenseWeight,
                    assistsPerGameWeight, reboundsPerGameWeight, seedWeight, randomnum); ;  // play the game and return a winner

                double winseed = champ15.seed;  // Get the seed of the winner, and count it for tuning purposes.
                switch (winseed)
                {
                    case 1:
                        dukewins++;
                        break;
                    case 2:
                        michiganstwins++;
                        break;
                    case 3:
                        lsuwins++;
                        break;
                    case 4:
                        virginiatechwins++;
                        break;
                    case 5:
                        mississippistwins++;
                        break;
                    case 6:
                        marylandwins++;
                        break;
                    case 7:
                        louisvillewins++;
                        break;
                    case 8:
                        vcuwins++;
                        break;
                    case 9:
                        ucfwins++;
                        break;
                    case 10:
                        minnesotawins++;
                        break;
                    case 11:
                        belmontwins++;
                        break;
                    case 12:
                        libertywins++;
                        break;
                    case 13:
                        saintlouiswins++;
                        break;
                    case 14:
                        yalewins++;
                        break;
                    case 15:
                        bradleywins++;
                        break;
                    case 16:
                        northdakotastwins++;
                        break;
                }

            }

            // Read of the number of times a team is the champion in the simulation of 10000 tourneys.
            Console.WriteLine(dukewins + " Duke wins");
            Console.WriteLine(michiganstwins + " Michigan St wins");
            Console.WriteLine(lsuwins + " LSU wins");
            Console.WriteLine(virginiatechwins + " Virginia Tech wins");
            Console.WriteLine(mississippistwins + " Mississippi St wins");
            Console.WriteLine(marylandwins + " Maryland wins");
            Console.WriteLine(louisvillewins + " Louisville wins");
            Console.WriteLine(vcuwins + " VCU wins");
            Console.WriteLine(ucfwins + " UCF wins");
            Console.WriteLine(minnesotawins + " Minnesota wins");
            Console.WriteLine(belmontwins + " Belmont wins");
            Console.WriteLine(libertywins + " Liberty wins");
            Console.WriteLine(saintlouiswins + " Saint Louis wins");
            Console.WriteLine(yalewins + " Yale wins");
            Console.WriteLine(bradleywins + " Bradley wins");
            Console.WriteLine(northdakotastwins + " North Dakota St wins");

            Console.ReadLine();     // Wait and allow user to read.
        }

        static Team PlayGame(Team team1, Team team2, double sOweight, double sDweight, double aPGweight, double rPGweight, double seedWeight, Random randomNum)
        {
            // Generate random numbers between 0 and 1.
            double n1 = randomNum.NextDouble();
            double n2 = randomNum.NextDouble();
            double n3 = randomNum.NextDouble();
            double n4 = randomNum.NextDouble();
            double n5 = randomNum.NextDouble();
            double n6 = randomNum.NextDouble();
            double n7 = randomNum.NextDouble();
            double n8 = randomNum.NextDouble();
            double n9 = randomNum.NextDouble();
            double n10 = randomNum.NextDouble();

            //THIS IS THE MEAT AND POTATOS RIGHT HERE!

            // High = Good (ADD THESE)
            double mSO = Math.Max(team1.scoringOffense, team2.scoringOffense);
            double mAssists = Math.Max(team1.assistsPerGame, team2.assistsPerGame);
            double mRebs = Math.Max(team1.reboundsPerGame, team2.reboundsPerGame);
            // High = Bad (SUBTRACT THESE)
            double mSeed = Math.Max(team1.seed, team2.seed);
            double mSD = Math.Max(team1.scoringDefense, team2.scoringDefense);

            double vals1 = n1 * (sOweight * team1.scoringOffense / mSO)
                + n2 * (aPGweight * team1.assistsPerGame / mAssists)
                + n3 * (rPGweight * team1.reboundsPerGame / mRebs)
                - n5 * (seedWeight * (team1.seed - 1) / (mSeed - 1))
                - n4 * (sDweight * team1.scoringDefense / mSD);    // Generate team 1 value.

            double vals2 = n6 * (sOweight * team2.scoringOffense / mSO)
                + n7 * (aPGweight * team2.assistsPerGame / mAssists)
                + n8 * (rPGweight * team2.reboundsPerGame / mRebs)
                - n10 * (seedWeight * (team2.seed - 1) / (mSeed - 1))
                - n9 * (sDweight * team2.scoringDefense / mSD);    // Generate team 2 value.

            if (vals1 >= vals2)  // team 1 wins!
            {
                Team winner = team1;
                return winner;
            }
            else
            {
                Team winner = team2;    // team 2 wins!
                return winner;
            }
        }
    }
}