namespace Tic_Tac_Toe_WF
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.New_Game = new System.Windows.Forms.Button();
            this.Exit_Game = new System.Windows.Forms.Button();
            this.change_names = new System.Windows.Forms.CheckBox();
            this.player_turn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.A1.Location = new System.Drawing.Point(12, 148);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.A2.Location = new System.Drawing.Point(219, 148);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.A3.Location = new System.Drawing.Point(423, 148);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.B3.Location = new System.Drawing.Point(423, 229);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.B2.Location = new System.Drawing.Point(219, 229);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.B1.Location = new System.Drawing.Point(12, 229);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.C3.Location = new System.Drawing.Point(423, 310);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.C2.Location = new System.Drawing.Point(219, 310);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.C1.Location = new System.Drawing.Point(12, 310);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 93);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // New_Game
            // 
            this.New_Game.Location = new System.Drawing.Point(13, 402);
            this.New_Game.Name = "New_Game";
            this.New_Game.Size = new System.Drawing.Size(75, 23);
            this.New_Game.TabIndex = 10;
            this.New_Game.Text = "New Game";
            this.New_Game.UseVisualStyleBackColor = true;
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // Exit_Game
            // 
            this.Exit_Game.Location = new System.Drawing.Point(423, 402);
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(75, 23);
            this.Exit_Game.TabIndex = 11;
            this.Exit_Game.Text = "Exit";
            this.Exit_Game.UseVisualStyleBackColor = true;
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // change_names
            // 
            this.change_names.AutoSize = true;
            this.change_names.Location = new System.Drawing.Point(94, 406);
            this.change_names.Name = "change_names";
            this.change_names.Size = new System.Drawing.Size(126, 17);
            this.change_names.TabIndex = 12;
            this.change_names.Text = "Change Playernames";
            this.change_names.UseVisualStyleBackColor = true;
            // 
            // player_turn
            // 
            this.player_turn.AutoSize = true;
            this.player_turn.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.player_turn.Location = new System.Drawing.Point(191, 109);
            this.player_turn.Name = "player_turn";
            this.player_turn.Size = new System.Drawing.Size(137, 28);
            this.player_turn.TabIndex = 13;
            this.player_turn.Text = "It\'s your turn, X";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 437);
            this.Controls.Add(this.player_turn);
            this.Controls.Add(this.change_names);
            this.Controls.Add(this.Exit_Game);
            this.Controls.Add(this.New_Game);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.A1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Ultimate Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button New_Game;
        private System.Windows.Forms.Button Exit_Game;
        public System.Windows.Forms.CheckBox change_names;
        private System.Windows.Forms.Label player_turn;
    }
}