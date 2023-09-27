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

        public void inventoryTab()
        {
            if (!pictureBox2.Visible && !pictureBox1.Visible && !label1.Visible)
            {
                pictureBox2.Visible = true;
                pictureBox2.Enabled = true;
                pictureBox3.Visible = true;
                pictureBox3.Enabled = true;
                pictureBox4.Visible = true;
                pictureBox4.Enabled = true;
                pictureBox5.Visible = true;
                pictureBox5.Enabled = true;
                pictureBox6.Visible = true;
                pictureBox6.Enabled = true;
                pictureBox7.Visible = true;
                pictureBox7.Enabled = true;
                pictureBox8.Visible = true;
                pictureBox8.Enabled = true;
                pictureBox9.Visible = true;
                pictureBox9.Enabled = true;
                pictureBox10.Visible = true;
                pictureBox10.Enabled = true;
                pictureBox11.Visible = true;
                pictureBox11.Enabled = true;

                timer1.Stop();
                return;
            }
            else
            {
                timer1.Start();
                pictureBox2.Visible = false;
                pictureBox2.Enabled = false;
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox4.Enabled = false;
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                pictureBox6.Visible = false;
                pictureBox6.Enabled = false;
                pictureBox7.Visible = false;
                pictureBox7.Enabled = false;
                pictureBox8.Visible = false;
                pictureBox8.Enabled = false;
                pictureBox9.Visible = false;
                pictureBox9.Enabled = false;
                pictureBox10.Visible = false;
                pictureBox10.Enabled = false;
                pictureBox11.Visible = false;
                pictureBox11.Enabled = false;
            }
        }
        public void fonctionEchap()
        {
            if (!label1.Visible && !pictureBox2.Visible && !pictureBox1.Visible)
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
        public void shop()
        {
            if (pictureBox1.Visible && !pictureBox2.Visible && !label1.Visible)
            {
                timer1.Start();
                button4.Visible = false;
                button4.Enabled = false;
                button3.Visible = false;
                button3.Enabled = false;
                button6.Visible = false;
                button6.Enabled = false;
                button5.Visible = false;
                button5.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;

                return;
            }

            button4.Visible = true;
            button4.Enabled = true;
            button3.Visible = true;
            button3.Enabled = true;
            button6.Visible = true;
            button6.Enabled = true;
            button5.Visible = true;
            button5.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            timer1.Stop();

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
            if (e.KeyCode == Keys.P)
            {
                shop();
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
            if (e.KeyCode == Keys.I)
            {
                inventoryTab();
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

        private void button1_Click(object sender, EventArgs e)
        {
            fonctionEchap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button4.Visible = false;
            button4.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            button5.Visible = false;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;

            return;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}