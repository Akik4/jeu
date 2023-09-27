using jeu.Properties;
using System.ComponentModel.Design.Serialization;
using System.Resources;

namespace jeu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        Boolean zKey, dKey, qKey, sKey;
        List<PictureBox> enemy = new List<PictureBox> { };
        List<Label> enemyHP = new List<Label> { };
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        public void fonctionEchap()
        {
            if (!label1.Visible)
            {
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                label1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                timer1.Stop();
                return;
            }
            timer1.Start();
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                zKey = true;
            }
            if (e.KeyCode == Keys.D)
            {
                dKey = true;
            }
            if (e.KeyCode == Keys.Q)
            {
                qKey = true;
            }
            if (e.KeyCode == Keys.S)
            {
                sKey = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                fonctionEchap();
            }
            if (e.KeyCode == Keys.L)
            {
                Control y = new Ennemy().Spawn(Player);
                enemy.Add((PictureBox)y);
                Controls.Add(y);

            }
            if (e.KeyCode == Keys.R)
            {
                enemy.ForEach(l =>
                {
                    l.Visible = false;
                });
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                zKey = false;
            }
            if (e.KeyCode == Keys.D)
            {
                dKey = false;
            }
            if (e.KeyCode == Keys.Q)
            {
                qKey = false;
            }
            if (e.KeyCode == Keys.S)
            {
                sKey = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = (20); // 10 secs
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            playerMove();

            enemyBrain(enemy1);
            if (enemy.Count > 0)
            {
                enemy.ForEach(l =>
                {
                    enemyBrain(l);
                });

            }


        }

        private void playerMove()
        {
            int y = 0;
            int x = 0;
            int velocity = 20;
            if (zKey)
            {
                y += -velocity;
            }
            if (qKey)
            {
                x += -velocity;
            }
            if (dKey)
            {
                x += velocity;
            }
            if (sKey)
            {
                y += velocity;
            }

            Player.Location = new Point(Player.Location.X + x, Player.Location.Y + y);
        }

        private void enemyBrain(PictureBox enemy1)
        {
            //Attaque
            double d = Math.Sqrt(Math.Pow(Player.Location.X - enemy1.Location.X, 2) + Math.Pow(Player.Location.Y - enemy1.Location.Y, 2));
            if (Math.Abs(d) < 100)
            {
                enemyHP1.Text = (Int32.Parse(enemyHP1.Text) - 5).ToString();
            }
            //mort
            if (Int32.Parse(enemyHP1.Text) <= 0)
            {
                enemyHP1.Visible = false;
                enemy1.Visible = false;
                piece.Visible = true;
                piece.Location = new Point(enemy1.Location.X, enemy1.Location.Y);
            }
            else
            //Déplacement enemy
            {

                int dx = Player.Location.X - enemy1.Location.X;
                int dy = Player.Location.Y - enemy1.Location.Y;
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

                enemy1.Location = new Point(enemy1.Location.X + speedX, enemy1.Location.Y + speedY);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
    }
}