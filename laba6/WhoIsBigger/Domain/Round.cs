using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsBigger.Domain
{
    public class Round
    {
        public readonly int RoundNumber;

        public Round(int number)
        {
            RoundNumber = number;
        }

        public static int GetNextRoundCount(Game game)
        {
            Round last = game.Rounds[0];

            foreach (Round round in game.Rounds)
                if (round.RoundNumber > last.RoundNumber)
                    last = round;

            return last.RoundNumber - game.CurrentRound.RoundNumber;
        }
    }
}
