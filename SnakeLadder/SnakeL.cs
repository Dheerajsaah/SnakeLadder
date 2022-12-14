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
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WIN_POSITION = 100;
       Random random = new Random();
        public int DiceRoll() 
        {
            int diceCount = random.Next(1, 7);
            return diceCount;
        }
        public void Play()
        {
            while (PlayerPosition < 100)
            {
                int Option = random.Next(0, 3);
                switch (Option)
                {
                    case NO_PLAY:
                        PlayerPosition += 0;
                        break;
                    case LADDER:
                        PlayerPosition += DiceRoll();
                        break;
                    case SNAKE:
                        PlayerPosition -= DiceRoll();
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                }
            }
            if (PlayerPosition == WIN_POSITION)
            {
                Console.WriteLine(PlayerPosition);
            }
        }
    }
}
