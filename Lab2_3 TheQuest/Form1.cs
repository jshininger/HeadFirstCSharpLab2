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
        private int ticks;

        // Constructor - Ensure the game area is centered on the user's screen.
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        // Update the player and enemies in the game area.  Check for a game over or level complete
        // condition.
        public void UpdateCharacters()
        {
            picPlayer.Location = game.PlayerLocation;
            picPlayer.Visible = true;
            playerHPLabel.Text = game.PlayerHitPoints.ToString();

            int enemiesShown = updateEnemies();

            updateWeapons();

            if (game.PlayerHitPoints <= 0)
            {
                gameOver();
            }
            else if (enemiesShown < 1)
            {
                if (game.Action)
                {
                    enemyTimer.Enabled = false;
                    ticks = 0;
                }
                MessageBox.Show("You have defeated the enemies on this level.\r\n\r\n" +
                    "Click OK to continue.", "Level Complete");
                game.NewLevel(random);
                if (!game.Victory)
                {
                    UpdateCharacters();
                }
                else
                    gameOver();
            }
            else
            {
                if (game.Action)
                    enemyTimer.Enabled = true;
            }
        }

        // Update enemies in the game area.
        private int updateEnemies()
        {
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

            return enemiesShown;
        }

        // Update weapons in the game area and player inventory.  If the player has any weapons,
        // ensure the equipped weapon is shown as such.
        private void updateWeapons()
        {
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

            if (game.PlayerWeapons.Count() > 0)
                showEquipped(game.GetPlayerEquippedWeapon());
        }

        // When the game ends, display the appropriate message to the player and give them the
        // opportunity to start a new game or quit.
        private void gameOver()
        {
            enemyTimer.Enabled = false;
            if (!game.Victory)
            {
                MessageBox.Show("You Died");
                gameStatusLabel.Text = "Game Over";
                gameStatusLabel.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                gameStatusLabel.Text = "Victory!!!";
                gameStatusLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
            }

            foreach (Control myControl in this.Controls)
            {
                if (myControl is PictureBox)
                    myControl.Visible = false;
            }
            if (game.Action)
                pauseButton.Visible = false;
            else
            {
                moveGroup.Visible = false;
                attackGroup.Visible = false;
            }

            gameStatusLabel.Visible = true;
            newGameButton.Visible = true;
            quitButton.Visible = true;
        }

        // Start a new game.  Takes a parameter determining whether the game is an action game or not.
        // If an action game, enable the enemy timer and the pause button, otherwise enable the move
        // and attack buttons for a turn-based game.
        private void newGame(bool action)
        {
            startAction.Visible = false;
            startTurn.Visible = false;
            gameStatusLabel.Visible = false;
            newGameButton.Visible = false;
            quitButton.Visible = false;

            game = new Game(new Rectangle(74, 55, 453 - picPlayer.Width, 191 - picPlayer.Height), action);
            game.NewLevel(random);
            UpdateCharacters();

            if (game.Action)
            {
                moveGroup.Visible = false;
                attackGroup.Visible = false;
                pauseButton.Visible = true;
                ticks = 0;
                enemyTimer.Enabled = true;
            }
            else
            {
                enemyTimer.Enabled = false;
                pauseButton.Visible = false;
                moveGroup.Visible = true;
                attackGroup.Visible = true;
            }
        }

        // Move Up during a turn-based game.
        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        // Move right during a turn-based game.
        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        // Move down during a turn-based game.
        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        // Move left during a turn-based game.
        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        // Attack up during a turn-based game.
        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        // Attack right during a turn-based game.
        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
        
        // Attack down during a turn-based game.
        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        // Attack left during a turn-based game.
        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        // If the user clicks in the form and they're playing an action game, the game attacks with
        // the overloaded Attack method that takes a Point.
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!paused() && game.Action)
            {
                game.Attack(new Point(e.X, e.Y), random);
                UpdateCharacters();
            }
        }

        // Method to handle the scenario in an action game where the user clicked directly on an
        // enemy to attack it
        private void attackCursorPoint()
        {
            Point pointOfAttack = new Point(Form1.MousePosition.X - this.Location.X,
                Form1.MousePosition.Y - this.Location.Y);
            game.Attack(pointOfAttack, random);
            UpdateCharacters();
        }

        // If the enemy is clicked on during an action game, attack it.
        private void picGhost_MouseClick(object sender, MouseEventArgs e)
        {
            if (!paused() && game.Action)
                attackCursorPoint();
        }

        // If the enemy is clicked on during an action game, attack it.
        private void picBat_MouseClick(object sender, MouseEventArgs e)
        {
            if (!paused() && game.Action)
                attackCursorPoint();
        }

        // If the enemy is clicked on during an action game, attack it.
        private void picGhoul_MouseClick(object sender, MouseEventArgs e)
        {
            if (!paused() && game.Action)
                attackCursorPoint();
        }

        // Equip the Sword.
        private void inv_picSword_Click(object sender, EventArgs e)
        {
            showEquipped("Sword");
        }

        // Equip the Bow.
        private void inv_picBow_Click(object sender, EventArgs e)
        {
            showEquipped("Bow");
        }

        // Equip the Mace.
        private void inv_picMace_Click(object sender, EventArgs e)
        {
            showEquipped("Mace");
        }

        // Equip the Blue potion.  If in an action game, immediately drink it.
        private void inv_picBluePotion_Click(object sender, EventArgs e)
        {
            string weapon = "Blue Potion";
            bool equipped = showEquipped(weapon);
            if (game.Action && equipped)
            {
                game.Attack(Direction.Up, random);
                UpdateCharacters();
            }
        }

        // Equip the Red potion.  If in an action game, immediately drink it.
        private void inv_picRedPotion_Click(object sender, EventArgs e)
        {
            string weapon = "Red Potion";
            bool equipped = showEquipped(weapon);
            if (game.Action && equipped)
            {
                game.Attack(Direction.Up, random);
                UpdateCharacters();
            }
        }
        
        // Change the BorderStyle around the equipped weapon to FixedSingle.  Takes a string
        // parameter that can specify a weapon to equip.
        private bool showEquipped(string weapon)
        {
            bool isPotion = false;
            bool equipped = false;
            if (game.CheckPlayerInventory(weapon))
            {
                game.Equip(weapon);
                equipped = true;
                switch (weapon)
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

                if (!game.Action)
                {
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
            return equipped;
        }

        // A simple function to determine if the game is paused.  Created to improve code
        // readability.
        private bool paused()
        {
            return gameStatusLabel.Visible;
        }

        // Allows the user to pause the game during an action game.
        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "Pause")
            {
                pauseButton.Text = "Resume";
                gameStatusLabel.Text = "Game Paused";
                gameStatusLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
                gameStatusLabel.Visible = true;
                enemyTimer.Enabled = false;
            }
            else
            {
                pauseButton.Text = "Pause";
                gameStatusLabel.Visible = false;
                enemyTimer.Enabled = true;
            }
        }

        // During an action game, handle the user using W-A-S-D to move.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!paused() && game.Action)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        moveUp_Click(sender, e);
                        break;
                    case Keys.D:
                        moveRight_Click(sender, e);
                        break;
                    case Keys.S:
                        moveDown_Click(sender, e);
                        break;
                    case Keys.A:
                        moveLeft_Click(sender, e);
                        break;
                    default: break;
                }
            }
        }

        // When the "Quit" button is presented on the game over screen, allows the user to quit.
        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult quitResult = MessageBox.Show(this, "Are you sure you want to quit?", 
                "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quitResult == DialogResult.Yes)
                Application.Exit();
        }

        // When the "New Game" button is presented on the game over screen, allows the user to
        // start a new game.
        private void newGameButton_Click(object sender, EventArgs e)
        {
            DialogResult newGameResult = MessageBox.Show(this, "Start a new game?",
                "New Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (newGameResult == DialogResult.Yes)
            {
                gameStatusLabel.Text = "New Game";
                gameStatusLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
                newGameButton.Visible = false;
                quitButton.Visible = false;
                startAction.Visible = true;
                startTurn.Visible = true;
            }
        }

        // On each tick of the enemy timer, check the speed of the enemies in the game.  If it
        // is time to move them, do so.
        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            foreach (Enemy enemy in game.Enemies)
            {
                if (ticks % enemy.Speed == 0)
                    game.Move(enemy, random);
            }
            UpdateCharacters();
        }

        // When starting a new game, allow the user to start a turn-based game.
        private void startTurn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the buttons on the right side of the game scroll to move and attack." +
                "\r\n\r\nUse the mouse to select items and weapons from the game scroll's inventory." +
                "\r\n\r\nIf a potion is selected, the attack buttons will change to show a \"Drink\" button." +
                "\r\n\r\nKeyboard movements and mouse attacks will be disabled in turn-based play.", 
                "Instructions");
            newGame(false);
        }

        // When starting a new game, allow the user to start an action game.
        private void startAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tUp: W\r\nLeft: A\t\tRight: D\r\n\tDown: S\r\n\r\n" +
                "Click the left mouse button in the game in the direction you wish to attack." +
                "\r\n\r\nAlso use the mouse to select items or pause the game from the game scroll." +
                "\r\n\r\nIf a potion is selected, the player will automatically drink it." ,
                "Instructions");
            newGame(true);
        }
    }
}
