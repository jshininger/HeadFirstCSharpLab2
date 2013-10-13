using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) 
            : base(game, location)
        {
            used = false;
            base.radius = 1;
            base.damage = 10;
        }
        public override string Name { get { return "Red Potion"; } }
        private bool used;
        public bool Used
        {
            get { return used; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(damage, random);
            used = true;
        }
    }
}
