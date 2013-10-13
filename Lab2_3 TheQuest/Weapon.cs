using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        protected int radius;
        protected int damage;

        public Weapon(Game game, Point location)
            : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }
        
        public abstract string Name { get; }
        
        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
