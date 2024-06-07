using System;

namespace WhoIsBigger.Domain
{
    public class Dice
    {
        public Round DiceRound;
        public int Result;

        public Dice(Round round)
        {
            DiceRound = round;
        }

        public void MakeRoll()
        {
            int roll1 = RollDie();
            int roll2 = RollDie();
            int roll3 = RollDie();

            int max1 = Math.Max(roll1, Math.Max(roll2, roll3));

            roll1 = RollDie();
            roll2 = RollDie();

            int max2 = Math.Max(roll1, roll2);

            int max3 = RollDie();

            Result = max1 + max2 + max3;
        }

        private int RollDie()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            return random.Next(1, 7); 
        }
    }
}
