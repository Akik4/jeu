using jeu.Properties;

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
            enemy1 = new PictureBox();
            enemyHP1 = new Label();
            piece = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
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
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(133, 261);
            enemy1.Margin = new Padding(2, 3, 2, 3);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(61, 69);
            enemy1.TabIndex = 1;
            enemy1.TabStop = false;
            // 
            // enemyHP1
            // 
            enemyHP1.AutoSize = true;
            enemyHP1.BackColor = Color.Transparent;
            enemyHP1.ForeColor = SystemColors.ActiveCaptionText;
            enemyHP1.Location = new Point(64, 247);
            enemyHP1.Margin = new Padding(2, 0, 2, 0);
            enemyHP1.Name = "enemyHP1";
            enemyHP1.Size = new Size(33, 20);
            enemyHP1.TabIndex = 2;
            enemyHP1.Text = "100";
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
            button2.Font = new Font("hades", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
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
            label1.Font = new Font("hades", 94.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(245, 12);
            label1.Name = "label1";
            label1.Size = new Size(495, 164);
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
            button1.Font = new Font("hades", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
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
            Controls.Add(enemyHP1);
            Controls.Add(enemy1);
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
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        public PictureBox enemy1;
        private Label enemyHP1;
        private PictureBox piece;
        private Button button2;
        private Label label1;
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
    }
}