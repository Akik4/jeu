using jeu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        Boolean zKey, dKey, qKey, sKey;
        Boolean waveCleared = true;
        List<PictureBox> enemy = new List<PictureBox> { };
        List<Label> enemyHP = new List<Label> { };
        List<PictureBox> c = new List<PictureBox> { };
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
                Control yHp = new Ennemy().Hp();
                enemy.Add((PictureBox)y);
                enemyHP.Add((Label)yHp);
                Controls.Add(y);
                Controls.Add(yHp);


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
            timer1.Interval = (6);
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            playerMove();

            if (c.Count > 0)
            {
                for (global::System.Int32 i = 0; i < c.Count; i++)
                {
                    takeCoin(c[i]);
                }

            }

            if (enemy.Count > 0)
            {
                for (global::System.Int32 i = 0; i < enemy.Count; i++)
                {
                    enemyBrain(enemy[i], enemyHP[i]);
                }

            }

        }

        private void playerMove()
        {
            int y = 0;
            int x = 0;
            int velocity = 5;
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

        private void takeCoin(PictureBox coin)
        {
            double d = Math.Sqrt(Math.Pow(Player.Location.X - coin.Location.X, 2) + Math.Pow(Player.Location.Y - coin.Location.Y, 2));

            if (Math.Abs(d) < 100)
            {
                c.Remove(coin);
                Controls.Remove(coin);
                counter.Text = (Int32.Parse(counter.Text) + 1).ToString();
            }
        }
        bool canAttack = true;
        List<PictureBox> attacked = new List<PictureBox>();

        private void enemyBrain(PictureBox enemy1, Label hp)
        {
            //Be attacked
            double d = Math.Sqrt(Math.Pow(Player.Location.X - enemy1.Location.X, 2) + Math.Pow(Player.Location.Y - enemy1.Location.Y, 2));
            if (Math.Abs(d) < 100)
            {
                if (canAttack)
                {
                    canAttack = false;
                    Player.Image = Resources.player_attack;
                    hp.Text = (Int32.Parse(hp.Text) - 10).ToString();
                    enemy1.Image = Resources.enemy_attacked;
                    Task.Delay(100).ContinueWith(t => { enemy1.Image = Resources.enemy; Player.Image = Resources.player; });
                    Task.Delay(500).ContinueWith(t => { canAttack = true; });
                }
            }

            if (Math.Abs(d) < 50)
            {
                if (!attacked.Contains(enemy1))
                {
                    attacked.Add(enemy1);
                    Player.Image = Resources.player_damaged;
                    playerHP.Text = (Int32.Parse(playerHP.Text) - 5).ToString();
                    Task.Delay(100).ContinueWith(t => { Player.Image = Resources.player; });
                    Task.Delay(1000).ContinueWith(t => { attacked.Remove(enemy1); });
                }
            }

            if (Int32.Parse(playerHP.Text) <= 0)
            {
                Label label1 = new Label();
                timer1.Stop();
                // 
                // label1
                // 
                label1.AutoSize = false;
                label1.Anchor = AnchorStyles.Top;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Dock = DockStyle.Fill;
                label1.BackColor = Color.Transparent;
                label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
                label1.ForeColor = Color.Red;
                label1.Location = new Point(303, 371);
                label1.Name = "label1";
                label1.Size = new Size(430, 89);
                label1.TabIndex = 7;
                label1.Text = "Game Over";

                Controls.Add(label1);
            }
            //mort
            if (Int32.Parse(hp.Text) <= 0)
            {
                hp.Visible = false;
                enemy1.Visible = false;
                Control coins = new Ennemy().DropCoin(enemy1.Location.X, enemy1.Location.Y);
                c.Add((PictureBox)coins);
                Controls.Add(coins);
                enemy.Remove(enemy1);
                enemyHP.Remove(hp);
                Controls.Remove(enemy1);
                Controls.Remove(hp);
            }
            else
            //Déplacement enemy
            {

                int dx = Player.Location.X - enemy1.Location.X;
                int dy = Player.Location.Y - enemy1.Location.Y;
                int speedX = 0;
                int speedY = 0;
                int velocity = 3;

                if (dx > 0)
                {
                    speedX = velocity;
                }
                else
                {
                    speedX = -velocity;
                }
                if (dy > 0)
                {
                    speedY = velocity;
                }
                else
                {
                    speedY = -velocity;
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