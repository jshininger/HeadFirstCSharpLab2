using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_3_TheQuest
{
    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public int Level { get { return level; } }
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }
        // Victory property added to determine if the player has won the game.
        public bool Victory { get; private set; }
        // Action property added to determine if the game is an action or turn-based game.
        public bool Action { get; private set; }

        // Constructor - This is overloaded from the original exercise to take a boolean parameter
        // determining whether this is an action game or not.
        public Game(Rectangle boundaries, bool action)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
            Victory = false;
            this.Action = action;
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            if (!Action)
            {
                foreach (Enemy enemy in Enemies)
                    enemy.Move(random);
            }
        }

        // Move a specific enemy.  This overloaded method is used in the action game to move specific
        // enemies based on the enemy timer's ticks relative to the enemy's speed.
        public void Move(Enemy enemy, Random random)
        {
            enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public string GetPlayerEquippedWeapon()
        {
            return player.EquippedWeapon;
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);

            if (!Action)
            {
                foreach (Enemy enemy in Enemies)
                    enemy.Move(random);
            }
        }

        // Overloaded method to take a specific Point to attack during an action game.  Calculations
        // are done on the point to determine if the point is Up, Right, Down, or Left of the player,
        // at which point the original attack method is called with the appropriate Direction parameter.
        public void Attack(Point pointOfAttack, Random random)
        {
            Direction attackDirection;
            double radians = Math.Atan2(pointOfAttack.Y - PlayerLocation.Y, 
                pointOfAttack.X - PlayerLocation.X);
            double angle = radians * (180 / Math.PI);

            if ((angle <= 0 && angle >= -45) || (angle >= 0 && angle <= 45))
                attackDirection = Direction.Right;
            else if (angle > 45 && angle < 135)
                attackDirection = Direction.Down;
            else if ((angle >= 135 && angle <= 180) || (angle >= -179 && angle <= -135))
                attackDirection = Direction.Left;
            else
                attackDirection = Direction.Up;

            Attack(attackDirection, random);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                    };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>() {
                        new Ghost(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Blue Potion"))
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>() {
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Bow"))
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Bow"))
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    else if (!CheckPlayerInventory("Blue Potion"))
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Red Potion"))
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemy>() {
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Mace"))
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>() {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    if (!CheckPlayerInventory("Mace"))
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    else if (!CheckPlayerInventory("Red Potion"))
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 8:
                    Victory = true;
                    break;
                default: break;
            }
        }
    }
}
