using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return Nearby(location, locationToCheck, distance);
        }

        public bool Nearby(Point locationA, Point locationB, int distance)
        {
            if (Math.Abs(locationA.X - locationB.X) < distance &&
                Math.Abs(locationA.Y - locationB.Y) < distance)
                return true;
            else
                return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            return Move(direction, location, boundaries);
        }

        public Point Move(Direction direction, Point pointToMove, Rectangle boundaries)
        {
            Point newLocation = pointToMove;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
