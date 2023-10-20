namespace GamePlane
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
            components = new System.ComponentModel.Container();
            Fon1 = new PictureBox();
            Plane = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Fon2 = new PictureBox();
            Plane2 = new PictureBox();
            Plane3 = new PictureBox();
            GameOver = new Label();
            NweGame = new Button();
            vint = new PictureBox();
            kvvint = new Button();
            kvplane = new Button();
            kvjet = new Button();
            jet = new PictureBox();
            jet2 = new PictureBox();
            planeP = new PictureBox();
            vint2 = new PictureBox();
            ВыбериС = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timertext = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Fon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plane).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plane2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plane3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planeP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vint2).BeginInit();
            SuspendLayout();
            // 
            // Fon1
            // 
            Fon1.BackgroundImage = Properties.Resources.Небо;
            Fon1.Image = Properties.Resources.Небо;
            Fon1.Location = new Point(0, 0);
            Fon1.Name = "Fon1";
            Fon1.Size = new Size(1114, 800);
            Fon1.TabIndex = 0;
            Fon1.TabStop = false;
            // 
            // Plane
            // 
            Plane.BackColor = Color.FromArgb(117, 213, 233);
            Plane.Image = Properties.Resources.План;
            Plane.Location = new Point(514, 502);
            Plane.Name = "Plane";
            Plane.Size = new Size(120, 120);
            Plane.SizeMode = PictureBoxSizeMode.StretchImage;
            Plane.TabIndex = 1;
            Plane.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Fon2
            // 
            Fon2.BackgroundImage = Properties.Resources.Небо;
            Fon2.Location = new Point(0, -800);
            Fon2.Name = "Fon2";
            Fon2.Size = new Size(1114, 800);
            Fon2.TabIndex = 2;
            Fon2.TabStop = false;
            // 
            // Plane2
            // 
            Plane2.Image = Properties.Resources.План21;
            Plane2.Location = new Point(297, -150);
            Plane2.Name = "Plane2";
            Plane2.Size = new Size(120, 120);
            Plane2.SizeMode = PictureBoxSizeMode.StretchImage;
            Plane2.TabIndex = 3;
            Plane2.TabStop = false;
            // 
            // Plane3
            // 
            Plane3.Image = Properties.Resources.План21;
            Plane3.Location = new Point(723, -435);
            Plane3.Name = "Plane3";
            Plane3.Size = new Size(120, 120);
            Plane3.SizeMode = PictureBoxSizeMode.StretchImage;
            Plane3.TabIndex = 4;
            Plane3.TabStop = false;
            // 
            // GameOver
            // 
            GameOver.AutoSize = true;
            GameOver.BackColor = Color.FromArgb(117, 213, 233);
            GameOver.Font = new Font("Impact", 72F, FontStyle.Bold, GraphicsUnit.Point);
            GameOver.ForeColor = Color.Red;
            GameOver.Location = new Point(270, 142);
            GameOver.Name = "GameOver";
            GameOver.Size = new Size(594, 145);
            GameOver.TabIndex = 5;
            GameOver.Text = "Game Over";
            GameOver.Visible = false;
            // 
            // NweGame
            // 
            NweGame.BackColor = Color.MintCream;
            NweGame.FlatStyle = FlatStyle.Popup;
            NweGame.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NweGame.ForeColor = Color.Red;
            NweGame.Location = new Point(446, 431);
            NweGame.Name = "NweGame";
            NweGame.Size = new Size(252, 53);
            NweGame.TabIndex = 6;
            NweGame.Text = "New Game";
            NweGame.UseVisualStyleBackColor = true;
            NweGame.Visible = false;
            NweGame.Click += NweGame_Click;
            // 
            // vint
            // 
            vint.BackColor = Color.FromArgb(117, 213, 233);
            vint.Image = Properties.Resources.Винт;
            vint.Location = new Point(514, 502);
            vint.Name = "vint";
            vint.Size = new Size(120, 120);
            vint.SizeMode = PictureBoxSizeMode.StretchImage;
            vint.TabIndex = 7;
            vint.TabStop = false;
            vint.Visible = false;
            // 
            // kvvint
            // 
            kvvint.BackColor = Color.Red;
            kvvint.FlatStyle = FlatStyle.Flat;
            kvvint.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            kvvint.ForeColor = SystemColors.Control;
            kvvint.Location = new Point(284, 432);
            kvvint.Name = "kvvint";
            kvvint.Size = new Size(120, 50);
            kvvint.TabIndex = 8;
            kvvint.Text = "VINT";
            kvvint.UseVisualStyleBackColor = false;
            kvvint.Click += kvvint_Click;
            // 
            // kvplane
            // 
            kvplane.BackColor = Color.Red;
            kvplane.FlatStyle = FlatStyle.Flat;
            kvplane.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            kvplane.ForeColor = SystemColors.Control;
            kvplane.Location = new Point(514, 432);
            kvplane.Name = "kvplane";
            kvplane.Size = new Size(120, 50);
            kvplane.TabIndex = 9;
            kvplane.Text = "PLANE";
            kvplane.UseVisualStyleBackColor = false;
            kvplane.Click += kvvint_Click;
            // 
            // kvjet
            // 
            kvjet.BackColor = Color.Red;
            kvjet.FlatStyle = FlatStyle.Flat;
            kvjet.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            kvjet.ForeColor = SystemColors.Control;
            kvjet.Location = new Point(721, 431);
            kvjet.Name = "kvjet";
            kvjet.Size = new Size(120, 50);
            kvjet.TabIndex = 10;
            kvjet.Text = "JET";
            kvjet.UseVisualStyleBackColor = false;
            kvjet.Click += kvvint_Click;
            // 
            // jet
            // 
            jet.BackColor = Color.FromArgb(117, 213, 233);
            jet.Image = Properties.Resources.Самолет_;
            jet.Location = new Point(514, 502);
            jet.Name = "jet";
            jet.Size = new Size(120, 120);
            jet.SizeMode = PictureBoxSizeMode.StretchImage;
            jet.TabIndex = 11;
            jet.TabStop = false;
            jet.Visible = false;
            // 
            // jet2
            // 
            jet2.BackColor = Color.FromArgb(117, 213, 233);
            jet2.Image = Properties.Resources.Самолет_;
            jet2.Location = new Point(721, 290);
            jet2.Name = "jet2";
            jet2.Size = new Size(120, 120);
            jet2.SizeMode = PictureBoxSizeMode.StretchImage;
            jet2.TabIndex = 12;
            jet2.TabStop = false;
            // 
            // planeP
            // 
            planeP.BackColor = Color.FromArgb(117, 213, 233);
            planeP.Image = Properties.Resources.План;
            planeP.Location = new Point(514, 290);
            planeP.Name = "planeP";
            planeP.Size = new Size(120, 120);
            planeP.SizeMode = PictureBoxSizeMode.StretchImage;
            planeP.TabIndex = 13;
            planeP.TabStop = false;
            // 
            // vint2
            // 
            vint2.BackColor = Color.FromArgb(117, 213, 233);
            vint2.Image = Properties.Resources.Винт;
            vint2.Location = new Point(284, 290);
            vint2.Name = "vint2";
            vint2.Size = new Size(120, 120);
            vint2.SizeMode = PictureBoxSizeMode.StretchImage;
            vint2.TabIndex = 14;
            vint2.TabStop = false;
            // 
            // ВыбериС
            // 
            ВыбериС.AutoSize = true;
            ВыбериС.BackColor = Color.FromArgb(117, 213, 233);
            ВыбериС.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            ВыбериС.ForeColor = Color.Red;
            ВыбериС.Location = new Point(419, 225);
            ВыбериС.Name = "ВыбериС";
            ВыбериС.Size = new Size(293, 45);
            ВыбериС.TabIndex = 15;
            ВыбериС.Text = "Выбери Самолет";
            ВыбериС.Visible = false;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timertext
            // 
            timertext.AutoSize = true;
            timertext.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            timertext.ForeColor = Color.Red;
            timertext.Location = new Point(35, 31);
            timertext.Name = "timertext";
            timertext.Size = new Size(36, 42);
            timertext.TabIndex = 16;
            timertext.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(35, 83);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 17;
            label1.Text = " Рекорд: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 800);
            Controls.Add(label1);
            Controls.Add(timertext);
            Controls.Add(ВыбериС);
            Controls.Add(vint2);
            Controls.Add(planeP);
            Controls.Add(jet2);
            Controls.Add(jet);
            Controls.Add(kvjet);
            Controls.Add(kvplane);
            Controls.Add(kvvint);
            Controls.Add(vint);
            Controls.Add(NweGame);
            Controls.Add(GameOver);
            Controls.Add(Plane3);
            Controls.Add(Plane2);
            Controls.Add(Plane);
            Controls.Add(Fon2);
            Controls.Add(Fon1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)Fon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plane).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plane2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plane3).EndInit();
            ((System.ComponentModel.ISupportInitialize)vint).EndInit();
            ((System.ComponentModel.ISupportInitialize)jet).EndInit();
            ((System.ComponentModel.ISupportInitialize)jet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)planeP).EndInit();
            ((System.ComponentModel.ISupportInitialize)vint2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Fon1;
        private PictureBox Plane;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Fon2;
        private PictureBox Plane2;
        private PictureBox Plane3;
        private Label GameOver;
        private Button NewGame;
        private Button NweGame;
        private PictureBox vint;
        private Button kvvint;
        private Button kvplane;
        private Button kvjet;
        private PictureBox jet;
        private PictureBox jet2;
        private PictureBox planeP;
        private PictureBox vint2;
        private Label ВыбериС;
        private System.Windows.Forms.Timer timer2;
        private Label timertext;
        private Label label1;
    }
}