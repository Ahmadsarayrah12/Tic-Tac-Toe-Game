namespace Tic_Tac_Toe_Game
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
            pnlXO = new Panel();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnReset = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCurrentPlayer = new Label();
            panel2 = new Panel();
            btnStart = new Button();
            pnlXO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlXO
            // 
            pnlXO.BackColor = Color.Transparent;
            pnlXO.Controls.Add(pictureBox9);
            pnlXO.Controls.Add(pictureBox8);
            pnlXO.Controls.Add(pictureBox7);
            pnlXO.Controls.Add(pictureBox6);
            pnlXO.Controls.Add(pictureBox5);
            pnlXO.Controls.Add(pictureBox4);
            pnlXO.Controls.Add(pictureBox3);
            pnlXO.Controls.Add(pictureBox2);
            pnlXO.Controls.Add(pictureBox1);
            pnlXO.Cursor = Cursors.Hand;
            pnlXO.Location = new Point(226, 174);
            pnlXO.Name = "pnlXO";
            pnlXO.Size = new Size(525, 448);
            pnlXO.TabIndex = 0;
            pnlXO.Visible = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox9.Image = Properties.Resources.X_;
            pictureBox9.Location = new Point(372, 310);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(150, 124);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 7;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "";
            pictureBox9.MouseClick += Player_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox8.Image = Properties.Resources.X_;
            pictureBox8.Location = new Point(198, 310);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(150, 124);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "";
            pictureBox8.MouseClick += Player_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox7.Image = Properties.Resources.X_;
            pictureBox7.Location = new Point(23, 310);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(150, 124);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "";
            pictureBox7.MouseClick += Player_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox6.Image = Properties.Resources.X_;
            pictureBox6.Location = new Point(372, 158);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 124);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "";
            pictureBox6.MouseClick += Player_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox5.Image = Properties.Resources.X_;
            pictureBox5.Location = new Point(198, 158);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 124);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "";
            pictureBox5.MouseClick += Player_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox4.Image = Properties.Resources.X_;
            pictureBox4.Location = new Point(23, 158);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 124);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "";
            pictureBox4.MouseClick += Player_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox3.Image = Properties.Resources.X_;
            pictureBox3.Location = new Point(372, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 124);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "";
            pictureBox3.MouseClick += Player_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox2.Image = Properties.Resources.X_;
            pictureBox2.Location = new Point(198, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "";
            pictureBox2.MouseClick += Player_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(40, 255, 255, 255);
            pictureBox1.Image = Properties.Resources.X_;
            pictureBox1.Location = new Point(23, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            pictureBox1.MouseClick += Player_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SkyBlue;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(356, 680);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(255, 59);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Haettenschweiler", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(79, 77);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 2;
            label1.Text = "Player1 ( X )";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Haettenschweiler", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(79, 122);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 3;
            label2.Text = "Player2 ( O )";
            // 
            // lblCurrentPlayer
            // 
            lblCurrentPlayer.BackColor = Color.Transparent;
            lblCurrentPlayer.Dock = DockStyle.Fill;
            lblCurrentPlayer.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPlayer.ForeColor = Color.White;
            lblCurrentPlayer.Location = new Point(0, 0);
            lblCurrentPlayer.Name = "lblCurrentPlayer";
            lblCurrentPlayer.Size = new Size(390, 46);
            lblCurrentPlayer.TabIndex = 6;
            lblCurrentPlayer.Text = "Current Player: X";
            lblCurrentPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.Controls.Add(lblCurrentPlayer);
            panel2.Location = new Point(311, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 46);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LimeGreen;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(356, 680);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(255, 59);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_uc59mjuc59mjuc59;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 877);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlXO);
            Controls.Add(panel2);
            Controls.Add(btnReset);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Tic-Tac-Toe Game";
            Load += Form1_Load;
            pnlXO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlXO;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStart;
    }
}