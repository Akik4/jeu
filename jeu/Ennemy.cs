using jeu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu
{
    internal class Ennemy : Form
    {
        private PictureBox enemya = new PictureBox();
        private Label enemyHP = new Label();
        private PictureBox coin = new PictureBox();

        public Control Spawn(PictureBox Player)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            enemya.BackColor = Color.Transparent;
            enemya.Image = (Image)resources.GetObject("enemy1.Image");
            enemya.Location = new Point(Player.Location.X, Player.Location.Y);
            enemya.Margin = new Padding(2);
            enemya.Name = "enemy1";
            enemya.Size = new Size(53, 52);
            enemya.TabIndex = 1;
            enemya.TabStop = false;

            return enemya;
        }
        public Control Hp()
        {
            enemyHP.AutoSize = true;
            enemyHP.BackColor = Color.Transparent;
            enemyHP.ForeColor = SystemColors.ActiveCaptionText;
            enemyHP.Location = new Point(56, 185);
            enemyHP.Margin = new Padding(2, 0, 2, 0);
            enemyHP.Name = "enemyHP1";
            enemyHP.Size = new Size(25, 15);
            enemyHP.TabIndex = 2;
            enemyHP.Text = "100";

            return enemyHP;

        }

        public Control DropCoin(int x, int y)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            coin.BackColor = Color.Transparent;
            coin.Image = (Image)resources.GetObject("pictureBox1.Image");
            coin.Location = new Point(x, y);
            coin.Margin = new Padding(2);
            coin.Name = "piece";
            coin.Size = new Size(21, 19);
            coin.TabIndex = 3;
            coin.TabStop = false;
            coin.Visible = true;

            return coin;
        }
    }
}