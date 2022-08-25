using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeL
    {
       int PlayerPosition = 0;
        public int DiceRoll() 
        {
            Random random = new Random();
            int diceCount=random.Next(1, 7);
            return diceCount;
        }
    }
}
