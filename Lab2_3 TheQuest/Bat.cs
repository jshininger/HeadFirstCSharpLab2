using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        {
            // The bat is the fastest enemy, though it doesn't do as much damage.
            Speed = 2;
        }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(2) == 0)
                {
                    // 50% chance of moving towards the player
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                }
                else
                {
                    // 50% chance of moving in a random direction
                    location = Move((Direction)random.Next(4), game.Boundaries);
                }
                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
            }
        }
    }
}
