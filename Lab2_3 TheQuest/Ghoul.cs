using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {
            // The ghoul is faster than the ghost, but slower than the bat.
            Speed = 4;
        }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                int randValue = random.Next(3);
                if (randValue == 0 || randValue == 1)
                {
                    // 2 in 3 chance of moving towards the player
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                // 1 in 3 chance of standing still
                if (NearPlayer())
                {
                    game.HitPlayer(4, random);
                }
            }
        }
    }
}
