namespace Lab2_3_TheQuest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picBat = new System.Windows.Forms.PictureBox();
            this.picGhoul = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picBow = new System.Windows.Forms.PictureBox();
            this.picRedPotion = new System.Windows.Forms.PictureBox();
            this.picBluePotion = new System.Windows.Forms.PictureBox();
            this.picMace = new System.Windows.Forms.PictureBox();
            this.inv_picSword = new System.Windows.Forms.PictureBox();
            this.inv_picBow = new System.Windows.Forms.PictureBox();
            this.inv_picMace = new System.Windows.Forms.PictureBox();
            this.inv_picBluePotion = new System.Windows.Forms.PictureBox();
            this.inv_picRedPotion = new System.Windows.Forms.PictureBox();
            this.moveGroup = new System.Windows.Forms.GroupBox();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.attackGroup = new System.Windows.Forms.GroupBox();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.batHPLabel = new System.Windows.Forms.Label();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.ghostHPLabel = new System.Windows.Forms.Label();
            this.ghoulLabel = new System.Windows.Forms.Label();
            this.ghoulHPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picRedPotion)).BeginInit();
            this.moveGroup.SuspendLayout();
            this.attackGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer.Image")));
            this.picPlayer.Location = new System.Drawing.Point(102, 78);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 30);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picSword
            // 
            this.picSword.BackColor = System.Drawing.Color.Transparent;
            this.picSword.Image = ((System.Drawing.Image)(resources.GetObject("picSword.Image")));
            this.picSword.Location = new System.Drawing.Point(138, 78);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(30, 30);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 1;
            this.picSword.TabStop = false;
            this.picSword.Visible = false;
            // 
            // picBat
            // 
            this.picBat.BackColor = System.Drawing.Color.Transparent;
            this.picBat.Image = ((System.Drawing.Image)(resources.GetObject("picBat.Image")));
            this.picBat.Location = new System.Drawing.Point(174, 78);
            this.picBat.Name = "picBat";
            this.picBat.Size = new System.Drawing.Size(30, 30);
            this.picBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBat.TabIndex = 2;
            this.picBat.TabStop = false;
            this.picBat.Visible = false;
            // 
            // picGhoul
            // 
            this.picGhoul.BackColor = System.Drawing.Color.Transparent;
            this.picGhoul.Image = ((System.Drawing.Image)(resources.GetObject("picGhoul.Image")));
            this.picGhoul.Location = new System.Drawing.Point(210, 78);
            this.picGhoul.Name = "picGhoul";
            this.picGhoul.Size = new System.Drawing.Size(30, 30);
            this.picGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhoul.TabIndex = 3;
            this.picGhoul.TabStop = false;
            this.picGhoul.Visible = false;
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Transparent;
            this.picGhost.Image = ((System.Drawing.Image)(resources.GetObject("picGhost.Image")));
            this.picGhost.Location = new System.Drawing.Point(246, 78);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(30, 30);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 4;
            this.picGhost.TabStop = false;
            this.picGhost.Visible = false;
            // 
            // picBow
            // 
            this.picBow.BackColor = System.Drawing.Color.Transparent;
            this.picBow.Image = ((System.Drawing.Image)(resources.GetObject("picBow.Image")));
            this.picBow.Location = new System.Drawing.Point(282, 78);
            this.picBow.Name = "picBow";
            this.picBow.Size = new System.Drawing.Size(30, 30);
            this.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBow.TabIndex = 5;
            this.picBow.TabStop = false;
            this.picBow.Visible = false;
            // 
            // picRedPotion
            // 
            this.picRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.picRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("picRedPotion.Image")));
            this.picRedPotion.Location = new System.Drawing.Point(318, 78);
            this.picRedPotion.Name = "picRedPotion";
            this.picRedPotion.Size = new System.Drawing.Size(30, 30);
            this.picRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPotion.TabIndex = 6;
            this.picRedPotion.TabStop = false;
            this.picRedPotion.Visible = false;
            // 
            // picBluePotion
            // 
            this.picBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.picBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("picBluePotion.Image")));
            this.picBluePotion.Location = new System.Drawing.Point(354, 78);
            this.picBluePotion.Name = "picBluePotion";
            this.picBluePotion.Size = new System.Drawing.Size(30, 30);
            this.picBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBluePotion.TabIndex = 7;
            this.picBluePotion.TabStop = false;
            this.picBluePotion.Visible = false;
            // 
            // picMace
            // 
            this.picMace.BackColor = System.Drawing.Color.Transparent;
            this.picMace.Image = ((System.Drawing.Image)(resources.GetObject("picMace.Image")));
            this.picMace.Location = new System.Drawing.Point(390, 78);
            this.picMace.Name = "picMace";
            this.picMace.Size = new System.Drawing.Size(30, 30);
            this.picMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMace.TabIndex = 8;
            this.picMace.TabStop = false;
            this.picMace.Visible = false;
            // 
            // inv_picSword
            // 
            this.inv_picSword.BackColor = System.Drawing.Color.Transparent;
            this.inv_picSword.Image = ((System.Drawing.Image)(resources.GetObject("inv_picSword.Image")));
            this.inv_picSword.Location = new System.Drawing.Point(70, 319);
            this.inv_picSword.Name = "inv_picSword";
            this.inv_picSword.Size = new System.Drawing.Size(50, 50);
            this.inv_picSword.TabIndex = 9;
            this.inv_picSword.TabStop = false;
            this.inv_picSword.Visible = false;
            this.inv_picSword.Click += new System.EventHandler(this.inv_picSword_Click);
            // 
            // inv_picBow
            // 
            this.inv_picBow.BackColor = System.Drawing.Color.Transparent;
            this.inv_picBow.Image = ((System.Drawing.Image)(resources.GetObject("inv_picBow.Image")));
            this.inv_picBow.Location = new System.Drawing.Point(126, 319);
            this.inv_picBow.Name = "inv_picBow";
            this.inv_picBow.Size = new System.Drawing.Size(50, 50);
            this.inv_picBow.TabIndex = 10;
            this.inv_picBow.TabStop = false;
            this.inv_picBow.Visible = false;
            this.inv_picBow.Click += new System.EventHandler(this.inv_picBow_Click);
            // 
            // inv_picMace
            // 
            this.inv_picMace.BackColor = System.Drawing.Color.Transparent;
            this.inv_picMace.Image = ((System.Drawing.Image)(resources.GetObject("inv_picMace.Image")));
            this.inv_picMace.Location = new System.Drawing.Point(182, 319);
            this.inv_picMace.Name = "inv_picMace";
            this.inv_picMace.Size = new System.Drawing.Size(50, 50);
            this.inv_picMace.TabIndex = 11;
            this.inv_picMace.TabStop = false;
            this.inv_picMace.Visible = false;
            this.inv_picMace.Click += new System.EventHandler(this.inv_picMace_Click);
            // 
            // inv_picBluePotion
            // 
            this.inv_picBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inv_picBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("inv_picBluePotion.Image")));
            this.inv_picBluePotion.Location = new System.Drawing.Point(238, 319);
            this.inv_picBluePotion.Name = "inv_picBluePotion";
            this.inv_picBluePotion.Size = new System.Drawing.Size(50, 50);
            this.inv_picBluePotion.TabIndex = 12;
            this.inv_picBluePotion.TabStop = false;
            this.inv_picBluePotion.Visible = false;
            this.inv_picBluePotion.Click += new System.EventHandler(this.inv_picBluePotion_Click);
            // 
            // inv_picRedPotion
            // 
            this.inv_picRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inv_picRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("inv_picRedPotion.Image")));
            this.inv_picRedPotion.Location = new System.Drawing.Point(294, 319);
            this.inv_picRedPotion.Name = "inv_picRedPotion";
            this.inv_picRedPotion.Size = new System.Drawing.Size(50, 50);
            this.inv_picRedPotion.TabIndex = 13;
            this.inv_picRedPotion.TabStop = false;
            this.inv_picRedPotion.Visible = false;
            this.inv_picRedPotion.Click += new System.EventHandler(this.inv_picRedPotion_Click);
            // 
            // moveGroup
            // 
            this.moveGroup.BackColor = System.Drawing.Color.Transparent;
            this.moveGroup.Controls.Add(this.moveDown);
            this.moveGroup.Controls.Add(this.moveRight);
            this.moveGroup.Controls.Add(this.moveUp);
            this.moveGroup.Controls.Add(this.moveLeft);
            this.moveGroup.Location = new System.Drawing.Point(350, 311);
            this.moveGroup.Name = "moveGroup";
            this.moveGroup.Size = new System.Drawing.Size(95, 71);
            this.moveGroup.TabIndex = 14;
            this.moveGroup.TabStop = false;
            this.moveGroup.Text = "Move";
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(41, 46);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(19, 21);
            this.moveDown.TabIndex = 4;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(66, 36);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(19, 21);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(41, 14);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(19, 21);
            this.moveUp.TabIndex = 2;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(16, 36);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(19, 21);
            this.moveLeft.TabIndex = 1;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // attackGroup
            // 
            this.attackGroup.BackColor = System.Drawing.Color.Transparent;
            this.attackGroup.Controls.Add(this.attackDown);
            this.attackGroup.Controls.Add(this.attackRight);
            this.attackGroup.Controls.Add(this.attackUp);
            this.attackGroup.Controls.Add(this.attackLeft);
            this.attackGroup.Location = new System.Drawing.Point(451, 312);
            this.attackGroup.Name = "attackGroup";
            this.attackGroup.Size = new System.Drawing.Size(95, 70);
            this.attackGroup.TabIndex = 15;
            this.attackGroup.TabStop = false;
            this.attackGroup.Text = "Attack";
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(41, 45);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(19, 21);
            this.attackDown.TabIndex = 4;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(66, 35);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(19, 21);
            this.attackRight.TabIndex = 3;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(41, 13);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(19, 21);
            this.attackUp.TabIndex = 2;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(16, 35);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(19, 21);
            this.attackLeft.TabIndex = 1;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.playerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerHPLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.batHPLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghostHPLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHPLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(354, 245);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 54);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(3, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.AutoSize = true;
            this.playerHPLabel.Location = new System.Drawing.Point(63, 0);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(77, 13);
            this.playerHPLabel.TabIndex = 1;
            this.playerHPLabel.Text = "playerHitPoints";
            // 
            // batLabel
            // 
            this.batLabel.AutoSize = true;
            this.batLabel.Location = new System.Drawing.Point(3, 13);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(23, 13);
            this.batLabel.TabIndex = 2;
            this.batLabel.Text = "Bat";
            // 
            // batHPLabel
            // 
            this.batHPLabel.AutoSize = true;
            this.batHPLabel.Location = new System.Drawing.Point(63, 13);
            this.batHPLabel.Name = "batHPLabel";
            this.batHPLabel.Size = new System.Drawing.Size(64, 13);
            this.batHPLabel.TabIndex = 3;
            this.batHPLabel.Text = "batHitPoints";
            // 
            // ghostLabel
            // 
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.Location = new System.Drawing.Point(3, 26);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(35, 13);
            this.ghostLabel.TabIndex = 4;
            this.ghostLabel.Text = "Ghost";
            // 
            // ghostHPLabel
            // 
            this.ghostHPLabel.AutoSize = true;
            this.ghostHPLabel.Location = new System.Drawing.Point(63, 26);
            this.ghostHPLabel.Name = "ghostHPLabel";
            this.ghostHPLabel.Size = new System.Drawing.Size(75, 13);
            this.ghostHPLabel.TabIndex = 5;
            this.ghostHPLabel.Text = "ghostHitPoints";
            // 
            // ghoulLabel
            // 
            this.ghoulLabel.AutoSize = true;
            this.ghoulLabel.Location = new System.Drawing.Point(3, 39);
            this.ghoulLabel.Name = "ghoulLabel";
            this.ghoulLabel.Size = new System.Drawing.Size(35, 13);
            this.ghoulLabel.TabIndex = 6;
            this.ghoulLabel.Text = "Ghoul";
            // 
            // ghoulHPLabel
            // 
            this.ghoulHPLabel.AutoSize = true;
            this.ghoulHPLabel.Location = new System.Drawing.Point(63, 39);
            this.ghoulHPLabel.Name = "ghoulHPLabel";
            this.ghoulHPLabel.Size = new System.Drawing.Size(75, 13);
            this.ghoulHPLabel.TabIndex = 7;
            this.ghoulHPLabel.Text = "ghoulHitPoints";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picGhoul);
            this.Controls.Add(this.picBat);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attackGroup);
            this.Controls.Add(this.moveGroup);
            this.Controls.Add(this.inv_picRedPotion);
            this.Controls.Add(this.inv_picBluePotion);
            this.Controls.Add(this.inv_picMace);
            this.Controls.Add(this.inv_picBow);
            this.Controls.Add(this.inv_picSword);
            this.Controls.Add(this.picSword);
            this.Controls.Add(this.picBow);
            this.Controls.Add(this.picMace);
            this.Controls.Add(this.picRedPotion);
            this.Controls.Add(this.picBluePotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_picRedPotion)).EndInit();
            this.moveGroup.ResumeLayout(false);
            this.attackGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picBat;
        private System.Windows.Forms.PictureBox picGhoul;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.PictureBox picRedPotion;
        private System.Windows.Forms.PictureBox picBluePotion;
        private System.Windows.Forms.PictureBox picMace;
        private System.Windows.Forms.PictureBox inv_picSword;
        private System.Windows.Forms.PictureBox inv_picBow;
        private System.Windows.Forms.PictureBox inv_picMace;
        private System.Windows.Forms.PictureBox inv_picBluePotion;
        private System.Windows.Forms.PictureBox inv_picRedPotion;
        private System.Windows.Forms.GroupBox moveGroup;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.GroupBox attackGroup;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.Label batHPLabel;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.Label ghostHPLabel;
        private System.Windows.Forms.Label ghoulLabel;
        private System.Windows.Forms.Label ghoulHPLabel;
    }
}

