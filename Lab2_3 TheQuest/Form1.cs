using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_3_TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(74, 55, 453 - picPlayer.Width, 191 - picPlayer.Height));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            picPlayer.Location = game.PlayerLocation;
            playerHPLabel.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    picBat.Location = enemy.Location;
                    batHPLabel.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    picGhost.Location = enemy.Location;
                    ghostHPLabel.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    picGhoul.Location = enemy.Location;
                    ghoulHPLabel.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat == false)
            {
                picBat.Visible = false;
                batLabel.Text = "";
                batHPLabel.Text = "";
            }
            else
            {
                picBat.Visible = true;
                batLabel.Text = "Bat";
            }
            if (showGhost == false)
            {
                picGhost.Visible = false;
                ghostLabel.Text = "";
                ghostHPLabel.Text = "";
            }
            else
            {
                picGhost.Visible = true;
                ghostLabel.Text = "Ghost";
            }
            if (showGhoul == false)
            {
                picGhoul.Visible = false;
                ghoulLabel.Text = "";
                ghoulHPLabel.Text = "";
            }
            else
            {
                picGhoul.Visible = true;
                ghoulLabel.Text = "Ghoul";
            }

            picSword.Visible = false;
            picBow.Visible = false;
            picRedPotion.Visible = false;
            picBluePotion.Visible = false;
            picMace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = picSword; break;
                case "Bow":
                    weaponControl = picBow; break;
                case "Mace":
                    weaponControl = picMace; break;
                case "Blue Potion":
                    weaponControl = picBluePotion; break;
                case "Red Potion":
                    weaponControl = picRedPotion; break;
                default: break;
            }
            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Sword"))
                inv_picSword.Visible = true;
            else
                inv_picSword.Visible = false;
            if (game.CheckPlayerInventory("Bow"))
                inv_picBow.Visible = true;
            else
                inv_picBow.Visible = false;
            if (game.CheckPlayerInventory("Mace"))
                inv_picMace.Visible = true;
            else
                inv_picMace.Visible = false;
            if (game.CheckPlayerInventory("Blue Potion"))
                inv_picBluePotion.Visible = true;
            else
                inv_picBluePotion.Visible = false;
            if (game.CheckPlayerInventory("Red Potion"))
                inv_picRedPotion.Visible = true;
            else
                inv_picRedPotion.Visible = false;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            // todo: graphics flash a bit as moving
            // todo: when enemies or player on top of one another, transparency not fully working
            if (game.PlayerWeapons.Count() > 0)
                showEquipped();

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                if (game.Level == 8)
                    gameOver();
                else
                    UpdateCharacters();
            }
        }

        private void gameOver()
        {
            MessageBox.Show("Game Over");
            Application.Exit();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void inv_picSword_Click(object sender, EventArgs e)
        {
            string weapon = "Sword";
            if (game.CheckPlayerInventory(weapon))
            {
                game.Equip(weapon);
                showEquipped();
            }
        }

        private void inv_picBow_Click(object sender, EventArgs e)
        {
            string weapon = "Bow";
            if (game.CheckPlayerInventory(weapon))
            {
                game.Equip(weapon);
                showEquipped();
            }
        }

        private void inv_picMace_Click(object sender, EventArgs e)
        {
            string weapon = "Mace";
            if (game.CheckPlayerInventory(weapon))
            {
                game.Equip(weapon);
                showEquipped();
            }
        }

        private void inv_picBluePotion_Click(object sender, EventArgs e)
        {
            string weapon = "Blue Potion";
            if (game.CheckPlayerInventory(weapon))
            {
                game.Equip(weapon);
                showEquipped();
            }
        }

        private void inv_picRedPotion_Click(object sender, EventArgs e)
        {
            string weapon = "Red Potion";
            if (game.CheckPlayerInventory(weapon))
            {
                game.Equip(weapon);
                showEquipped();
            }
        }
        
        private void showEquipped()
        {
            bool isPotion = false;
            switch(game.GetPlayerEquippedWeapon())
            {
                case "Sword":
                    inv_picSword.BorderStyle = BorderStyle.FixedSingle;
                    inv_picBow.BorderStyle = BorderStyle.None;
                    inv_picMace.BorderStyle = BorderStyle.None;
                    inv_picBluePotion.BorderStyle = BorderStyle.None;
                    inv_picRedPotion.BorderStyle = BorderStyle.None;
                    break;
                case "Bow":
                    inv_picSword.BorderStyle = BorderStyle.None;
                    inv_picBow.BorderStyle = BorderStyle.FixedSingle;
                    inv_picMace.BorderStyle = BorderStyle.None;
                    inv_picBluePotion.BorderStyle = BorderStyle.None;
                    inv_picRedPotion.BorderStyle = BorderStyle.None;
                    break;
                case "Mace":
                    inv_picSword.BorderStyle = BorderStyle.None;
                    inv_picBow.BorderStyle = BorderStyle.None;
                    inv_picMace.BorderStyle = BorderStyle.FixedSingle;
                    inv_picBluePotion.BorderStyle = BorderStyle.None;
                    inv_picRedPotion.BorderStyle = BorderStyle.None;
                    break;
                case "Blue Potion":
                    inv_picSword.BorderStyle = BorderStyle.None;
                    inv_picBow.BorderStyle = BorderStyle.None;
                    inv_picMace.BorderStyle = BorderStyle.None;
                    inv_picBluePotion.BorderStyle = BorderStyle.FixedSingle;
                    inv_picRedPotion.BorderStyle = BorderStyle.None;
                    isPotion = true;
                    break;
                case "Red Potion":
                    inv_picSword.BorderStyle = BorderStyle.None;
                    inv_picBow.BorderStyle = BorderStyle.None;
                    inv_picMace.BorderStyle = BorderStyle.None;
                    inv_picBluePotion.BorderStyle = BorderStyle.None;
                    inv_picRedPotion.BorderStyle = BorderStyle.FixedSingle;
                    isPotion = true;
                    break;
                default: break;
            }

            if (isPotion)
            {
                attackGroup.Text = "Drink";
                attackUp.AutoSize = true;
                attackUp.Text = "Drink";
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
            }
            else
            {
                attackGroup.Text = "Attack";
                attackUp.AutoSize = false;
                attackUp.Size = new System.Drawing.Size(19, 21);
                attackUp.Text = "↑";
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
            }
        }
    }
}
