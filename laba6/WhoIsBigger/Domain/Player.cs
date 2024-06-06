using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsBigger.Domain
{
    public class Player
    {
        public readonly string Name;
        public int Score = 0;
        public List<Dice> Dices = new List<Dice>();

        public Player(string name)
        {
            Name = name;
        }
    }
}
