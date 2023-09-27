using System;
using System.Collections.Generic;
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
        public static void Move(PictureBox Player, PictureBox enemya)
        {
            int dx = Player.Location.X - enemya.Location.X;
            int dy = Player.Location.Y - enemya.Location.Y;
            int speedX = 0;
            int speedY = 0;

            if (dx > 0)
            {
                speedX = 3;
            }
            else
            {
                speedX = -3;
            }
            if (dy > 0)
            {
                speedY = 3;
            }
            else
            {
                speedY = -3;
            }

            enemya.Location = new Point(enemya.Location.X + speedX, enemya.Location.Y + speedY);
        }

        internal static void Move(PictureBox player, object first)
        {
            throw new NotImplementedException();
        }

        internal static void Move(PictureBox player, Func<Control> first)
        {
            throw new NotImplementedException();
        }
    }
}
