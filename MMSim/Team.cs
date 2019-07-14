using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchMadness
{
    class Team
    {
        public string teamName;
        public double scoringOffense;
        public double scoringDefense;
        public double assistsPerGame;
        public double reboundsPerGame;
        public double seed;

        public Team(string aTeamName, double aScoringOffense, double aScoringDefense,
            double aAssistsPerGame, double aReboundsPerGame, double aSeed)
        {
            teamName = aTeamName;
            scoringOffense = aScoringOffense;
            scoringDefense = aScoringDefense;
            assistsPerGame = aAssistsPerGame;
            reboundsPerGame = aReboundsPerGame;
            seed = aSeed;
        }

    }

}