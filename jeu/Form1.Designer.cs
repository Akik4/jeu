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
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piece).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(351, 150);
            Player.Name = "Player";
            Player.Size = new Size(56, 50);
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(116, 196);
            enemy1.Margin = new Padding(2);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(53, 52);
            enemy1.TabIndex = 1;
            enemy1.TabStop = false;
            // 
            // enemyHP1
            // 
            enemyHP1.AutoSize = true;
            enemyHP1.BackColor = Color.Transparent;
            enemyHP1.ForeColor = SystemColors.ActiveCaptionText;
            enemyHP1.Location = new Point(56, 185);
            enemyHP1.Margin = new Padding(2, 0, 2, 0);
            enemyHP1.Name = "enemyHP1";
            enemyHP1.Size = new Size(25, 15);
            enemyHP1.TabIndex = 2;
            enemyHP1.Text = "100";
            // 
            // piece
            // 
            piece.BackColor = Color.Transparent;
            piece.Image = (Image)resources.GetObject("piece.Image");
            piece.Location = new Point(239, 132);
            piece.Margin = new Padding(2);
            piece.Name = "piece";
            piece.Size = new Size(21, 19);
            piece.TabIndex = 3;
            piece.TabStop = false;
            piece.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(piece);
            Controls.Add(enemyHP1);
            Controls.Add(enemy1);
            Controls.Add(Player);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)piece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        public PictureBox enemy1;
        private Label enemyHP1;
        private PictureBox piece;
    }
}