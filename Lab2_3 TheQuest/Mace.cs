using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        {
            base.radius = 20;
            base.damage = 6;
        }

        public override string Name
        {
            get { return "Mace"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (!DamageEnemy(direction, random))
                        if (!DamageEnemy(Direction.Left, random))
                            if (!DamageEnemy(Direction.Down, random))
                                if (!DamageEnemy(Direction.Right, random)) 
                                    break;
                    break;
                case Direction.Right:
                    if (!DamageEnemy(direction, random))
                        if (!DamageEnemy(Direction.Up, random))
                            if (!DamageEnemy(Direction.Left, random))
                                if (!DamageEnemy(Direction.Down, random))
                                    break;
                    break;
                case Direction.Down:
                    if (!DamageEnemy(direction, random))
                        if (!DamageEnemy(Direction.Right, random))
                            if (!DamageEnemy(Direction.Up, random))
                                if (!DamageEnemy(Direction.Left, random))
                                    break;
                    break;
                case Direction.Left:
                    if (!DamageEnemy(direction, random))
                        if (!DamageEnemy(Direction.Down, random))
                            if (!DamageEnemy(Direction.Right, random))
                                if (!DamageEnemy(Direction.Up, random))
                                    break;
                    break;
                default: break;
            }
        }
    }
}
