using jeu.Properties;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace jeu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new PictureBox();
            piece = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            counter = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            playerHP = new Label();
            label2 = new Label();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(401, 200);
            Player.Margin = new Padding(3, 4, 3, 4);
            Player.Name = "Player";
            Player.Size = new Size(64, 67);
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // piece
            // 
            piece.BackColor = Color.Transparent;
            piece.Image = (Image)resources.GetObject("piece.Image");
            piece.Location = new Point(273, 176);
            piece.Margin = new Padding(2, 3, 2, 3);
            piece.Name = "piece";
            piece.Size = new Size(24, 25);
            piece.TabIndex = 3;
            piece.TabStop = false;
            piece.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Image = Resources.IMG_20230926_181814_removebg_preview;
            button2.Location = new Point(313, 347);
            button2.Name = "button2";
            button2.Size = new Size(296, 99);
            button2.TabIndex = 5;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.Font = new Font("Microsoft Sans Serif", 94.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(245, 12);
            label1.Name = "label1";
            label1.Size = new Size(523, 179);
            label1.TabIndex = 6;
            label1.Text = "Pause";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = Resources.IMG_20230926_181814_removebg_preview;
            button1.Location = new Point(313, 243);
            button1.Name = "button1";
            button1.Size = new Size(296, 99);
            button1.TabIndex = 7;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Resources.Shop;
            pictureBox1.Location = new Point(232, 101);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 306);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.BackColor = Color.Transparent;
            counter.Location = new Point(71, 54);
            counter.Margin = new Padding(2, 0, 2, 0);
            counter.Name = "counter";
            counter.Size = new Size(17, 20);
            counter.TabIndex = 4;
            counter.Text = "0";
            counter.Click += label1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Enabled = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(376, 347);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 24);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Enabled = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Resources.exit_button;
            button4.Location = new Point(390, 374);
            button4.Name = "button4";
            button4.Size = new Size(85, 19);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Enabled = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Resources.Buy1;
            button5.Location = new Point(254, 349);
            button5.Name = "button5";
            button5.Size = new Size(116, 24);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Enabled = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(499, 349);
            button6.Name = "button6";
            button6.Size = new Size(110, 24);
            button6.TabIndex = 12;
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(540, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 333);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Enabled = false;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(596, 192);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 75);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(676, 192);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 75);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Enabled = false;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(756, 192);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(72, 75);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.Enabled = false;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(596, 276);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(72, 75);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.Enabled = false;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(676, 276);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(72, 75);
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.Enabled = false;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(756, 276);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(72, 75);
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.None;
            pictureBox9.Enabled = false;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(596, 362);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(72, 75);
            pictureBox9.TabIndex = 20;
            pictureBox9.TabStop = false;
            pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.None;
            pictureBox10.Enabled = false;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(676, 362);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(72, 75);
            pictureBox10.TabIndex = 21;
            pictureBox10.TabStop = false;
            pictureBox10.Visible = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.None;
            pictureBox11.Enabled = false;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(756, 362);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(72, 75);
            pictureBox11.TabIndex = 22;
            pictureBox11.TabStop = false;
            pictureBox11.Visible = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.Image = Resources.Coin;
            pictureBox12.Location = new Point(48, 54);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(18, 19);
            pictureBox12.TabIndex = 23;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Image = Resources.heart;
            pictureBox13.Location = new Point(48, 86);
            pictureBox13.Margin = new Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(18, 19);
            pictureBox13.TabIndex = 24;
            pictureBox13.TabStop = false;
            // 
            // playerHP
            // 
            playerHP.AutoSize = true;
            playerHP.Location = new Point(71, 85);
            playerHP.Margin = new Padding(2, 0, 2, 0);
            playerHP.Name = "playerHP";
            playerHP.Size = new Size(33, 20);
            playerHP.TabIndex = 6;
            playerHP.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 25;
            label2.Text = "Vague : 0";
            // 
            // pictureBox14
            // 
            pictureBox14.Anchor = AnchorStyles.None;
            pictureBox14.BackgroundImage = (Image)resources.GetObject("pictureBox14.BackgroundImage");
            pictureBox14.Enabled = false;
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(401, 148);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(61, 62);
            pictureBox14.TabIndex = 26;
            pictureBox14.TabStop = false;
            pictureBox14.Visible = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Anchor = AnchorStyles.None;
            pictureBox15.BackgroundImage = (Image)resources.GetObject("pictureBox15.BackgroundImage");
            pictureBox15.Enabled = false;
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(273, 148);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(61, 62);
            pictureBox15.TabIndex = 27;
            pictureBox15.TabStop = false;
            pictureBox15.Visible = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Anchor = AnchorStyles.None;
            pictureBox16.BackgroundImage = (Image)resources.GetObject("pictureBox16.BackgroundImage");
            pictureBox16.Enabled = false;
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(529, 148);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(61, 62);
            pictureBox16.TabIndex = 28;
            pictureBox16.TabStop = false;
            pictureBox16.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(125, 75, 71);
            label3.Enabled = false;
            label3.Font = new Font("hades", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(278, 220);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 29;
            label3.Text = "Damage Up";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(125, 75, 71);
            label4.Enabled = false;
            label4.Font = new Font("hades", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(413, 220);
            label4.Name = "label4";
            label4.Size = new Size(38, 14);
            label4.TabIndex = 30;
            label4.Text = "AS UP";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(125, 75, 71);
            label5.Enabled = false;
            label5.Font = new Font("hades", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(529, 220);
            label5.Name = "label5";
            label5.Size = new Size(59, 14);
            label5.TabIndex = 31;
            label5.Text = "Range Up";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(152, 101, 80);
            label6.Enabled = false;
            label6.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(263, 276);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 32;
            label6.Text = "5% Damage";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(152, 101, 80);
            label7.Enabled = false;
            label7.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(381, 276);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 33;
            label7.Text = "5% Atk Speed";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(152, 101, 80);
            label8.Enabled = false;
            label8.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(499, 276);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 34;
            label8.Text = "5% Range ";
            label8.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(label2);
            Controls.Add(playerHP);
            Controls.Add(counter);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(piece);
            Controls.Add(Player);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)piece).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        private PictureBox piece;
        private Button button2;
        private Label label1;
        private Label counter;
        private Label playerHP;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private Label label2;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}