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
            // No additional code needed 
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
