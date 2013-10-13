using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        public string EquippedWeapon { get { return equippedWeapon.Name; } }
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<String> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
            if (HitPoints < 0)
                HitPoints = 0;
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            Weapon weapon = game.WeaponInRoom;
            if (!weapon.PickedUp)
            {
                if (Nearby(weapon.Location, 1))
                {
                    weapon.PickUpWeapon();
                    inventory.Add(weapon);
                    if (inventory.Count == 1)
                        Equip(weapon.Name);
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    if (inventory.Count > 0)
                        equippedWeapon = inventory[0];
                    else
                        equippedWeapon = null;
                }
            }
        }
    }
}
