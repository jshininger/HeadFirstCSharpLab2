using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        {
            // Make the ghost slower than the bat and ghoul, but not much slower as
            // it already stands still 2/3 of the time anyway.
            Speed = 5;
        }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(3) == 0)
                {
                    // 1 in 3 chance of moving towards the player
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                // 2 in 3 chance of staying still
                if (NearPlayer())
                {
                    game.HitPlayer(3, random);
                }
            }
        }
    }
}
