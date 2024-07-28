namespace PuzzleGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbBuzzle = new System.Windows.Forms.GroupBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new Guna.UI2.WinForms.Guna2Button();
            this.btnPause = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBuzzle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuzzle
            // 
            this.gbBuzzle.Controls.Add(this.pb6);
            this.gbBuzzle.Controls.Add(this.pb7);
            this.gbBuzzle.Controls.Add(this.pb8);
            this.gbBuzzle.Controls.Add(this.pb3);
            this.gbBuzzle.Controls.Add(this.pb4);
            this.gbBuzzle.Controls.Add(this.pb5);
            this.gbBuzzle.Controls.Add(this.pb2);
            this.gbBuzzle.Controls.Add(this.pb1);
            this.gbBuzzle.Controls.Add(this.pb0);
            this.gbBuzzle.Location = new System.Drawing.Point(21, 119);
            this.gbBuzzle.Name = "gbBuzzle";
            this.gbBuzzle.Size = new System.Drawing.Size(570, 515);
            this.gbBuzzle.TabIndex = 1;
            this.gbBuzzle.TabStop = false;
            this.gbBuzzle.Text = "Buzzle Box";
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(6, 345);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(174, 157);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 8;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb6.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(195, 345);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(174, 157);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 7;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb7.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(384, 345);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(174, 157);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 6;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb8.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(6, 182);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(174, 157);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb3.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(195, 182);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(174, 157);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb4.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(384, 182);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(174, 157);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 3;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb5.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(384, 19);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(174, 157);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(195, 19);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(174, 157);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // pb0
            // 
            this.pb0.Location = new System.Drawing.Point(6, 19);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(174, 157);
            this.pb0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb0.TabIndex = 0;
            this.pb0.TabStop = false;
            this.pb0.Click += new System.EventHandler(this._SwitchPictureBox);
            this.pb0.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sound);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Animated = true;
            this.btnShuffle.AutoRoundedCorners = true;
            this.btnShuffle.BorderRadius = 21;
            this.btnShuffle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShuffle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShuffle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShuffle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShuffle.FillColor = System.Drawing.Color.SandyBrown;
            this.btnShuffle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.Yellow;
            this.btnShuffle.Location = new System.Drawing.Point(701, 464);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(180, 45);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.Click += new System.EventHandler(this.guna2Button1_Click);
            this.btnShuffle.MouseClick += new System.Windows.Forms.MouseEventHandler(this._soundbutton);
            // 
            // btnPause
            // 
            this.btnPause.Animated = true;
            this.btnPause.AutoRoundedCorners = true;
            this.btnPause.BorderRadius = 21;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.FillColor = System.Drawing.Color.SandyBrown;
            this.btnPause.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Yellow;
            this.btnPause.Location = new System.Drawing.Point(701, 524);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(180, 45);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.guna2Button2_Click);
            this.btnPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this._soundbutton);
            // 
            // btnQuit
            // 
            this.btnQuit.Animated = true;
            this.btnQuit.AutoRoundedCorners = true;
            this.btnQuit.BorderRadius = 21;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.SandyBrown;
            this.btnQuit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Yellow;
            this.btnQuit.Location = new System.Drawing.Point(701, 589);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(180, 45);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseClick += new System.Windows.Forms.MouseEventHandler(this._soundbutton);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(498, 22);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(419, 82);
            this.lblTimeElapsed.TabIndex = 5;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.Location = new System.Drawing.Point(17, 37);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(233, 60);
            this.lblMovesMade.TabIndex = 7;
            this.lblMovesMade.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuzzleGame.Properties.Resources.WhatsApp_Image_2024_07_27_at_00_12_32_27f71c52__1_;
            this.pictureBox1.Location = new System.Drawing.Point(610, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(929, 674);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.gbBuzzle);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbBuzzle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbBuzzle;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private Guna.UI2.WinForms.Guna2Button btnShuffle;
        private Guna.UI2.WinForms.Guna2Button btnPause;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Timer timer1;
    }
}

