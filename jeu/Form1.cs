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
        int damage = 10;
        int range = 100;
        int cooldown = 500;
        int wave = 0;
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
                pictureBox14.Enabled = false;
                pictureBox15.Enabled = false;
                pictureBox16.Enabled = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
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
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
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
            if (e.KeyCode == Keys.I)
            {
                inventoryTab();
            }
            if (e.KeyCode == Keys.M)
            {
                counter.Text = (Int32.Parse(counter.Text) + 1).ToString();
            }
            if (e.KeyCode == Keys.P)
            {
                shop();
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

            if (waveCleared)
            {
                waveCleared = false;

                for (global::System.Int32 i = 0; i < 5; i++)
                {
                    int x = new Random().Next(1920);
                    Control mob = new Ennemy().Spawn(x, 0);
                    Control test = new Ennemy().Hp();
                    enemy.Add((PictureBox)mob);
                    enemyHP.Add((Label)test);
                    Controls.Add(mob);
                    Controls.Add(test);
                }
                wave += 1;
                label2.Text = "Vague : " + wave.ToString();
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
            if (Math.Abs(d) < range)
            {
                if (canAttack)
                {
                    canAttack = false;
                    Player.Image = Resources.player_attack;
                    hp.Text = (Int32.Parse(hp.Text) - damage).ToString();
                    enemy1.Image = Resources.enemy_attacked;
                    Task.Delay(100).ContinueWith(t => { enemy1.Image = Resources.enemy; Player.Image = Resources.player; });
                    Task.Delay(cooldown).ContinueWith(t => { canAttack = true; });
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
                if (enemy.Count <= 0)
                {
                    waveCleared = true;
                    shop();
                }
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
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;

            return;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Cooldown(object sender, EventArgs e)
        {
            if (Int32.Parse(counter.Text) >= 3)
            {
                counter.Text = (Int32.Parse(counter.Text) - 3).ToString();
                cooldown = (int)(cooldown - (cooldown * 0.5));
                shop();
            }
        }
        private void button7_Range(object sender, EventArgs e)
        {
            if (Int32.Parse(counter.Text) >= 3)
            {
                counter.Text = (Int32.Parse(counter.Text) - 3).ToString();
                range = (int)(range + (range * 0.5));
                shop();
            }
        }

        private void button5_Damage(object sender, EventArgs e)
        {
            if (Int32.Parse(counter.Text) >= 3)
            {
                counter.Text = (Int32.Parse(counter.Text) - 3).ToString();
                damage = (int)(damage + (damage * 0.5));
                shop();
            }
        }
    }
}