namespace Tic_Tac_Toe_WF
{
    partial class Winscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winscreen));
            this.winscreenTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winscreen_again = new System.Windows.Forms.Button();
            this.winscreen_exit = new System.Windows.Forms.Button();
            this.changename_winscreen = new System.Windows.Forms.CheckBox();
            this.reset_stats_winscreen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // winscreenTextbox
            // 
            this.winscreenTextbox.BackColor = System.Drawing.Color.Black;
            this.winscreenTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winscreenTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.winscreenTextbox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winscreenTextbox.Location = new System.Drawing.Point(-6, 0);
            this.winscreenTextbox.Multiline = true;
            this.winscreenTextbox.Name = "winscreenTextbox";
            this.winscreenTextbox.Size = new System.Drawing.Size(474, 34);
            this.winscreenTextbox.TabIndex = 0;
            this.winscreenTextbox.TabStop = false;
            this.winscreenTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Tic_Tac_Toe_WF.Properties.Resources.winner;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 481);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // winscreen_again
            // 
            this.winscreen_again.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.winscreen_again.FlatAppearance.BorderSize = 0;
            this.winscreen_again.Location = new System.Drawing.Point(12, 444);
            this.winscreen_again.Name = "winscreen_again";
            this.winscreen_again.Size = new System.Drawing.Size(75, 23);
            this.winscreen_again.TabIndex = 1;
            this.winscreen_again.Text = "Play again";
            this.winscreen_again.UseVisualStyleBackColor = true;
            this.winscreen_again.Click += new System.EventHandler(this.winscreen_again_Click);
            // 
            // winscreen_exit
            // 
            this.winscreen_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.winscreen_exit.Location = new System.Drawing.Point(380, 444);
            this.winscreen_exit.Name = "winscreen_exit";
            this.winscreen_exit.Size = new System.Drawing.Size(75, 23);
            this.winscreen_exit.TabIndex = 2;
            this.winscreen_exit.Text = "Exit";
            this.winscreen_exit.UseVisualStyleBackColor = true;
            this.winscreen_exit.Click += new System.EventHandler(this.winscreen_exit_Click);
            // 
            // changename_winscreen
            // 
            this.changename_winscreen.AutoSize = true;
            this.changename_winscreen.BackColor = System.Drawing.Color.Black;
            this.changename_winscreen.ForeColor = System.Drawing.Color.White;
            this.changename_winscreen.Location = new System.Drawing.Point(12, 386);
            this.changename_winscreen.Name = "changename_winscreen";
            this.changename_winscreen.Size = new System.Drawing.Size(126, 17);
            this.changename_winscreen.TabIndex = 3;
            this.changename_winscreen.Text = "Change Playernames";
            this.changename_winscreen.UseVisualStyleBackColor = false;
            // 
            // reset_stats_winscreen
            // 
            this.reset_stats_winscreen.AutoSize = true;
            this.reset_stats_winscreen.BackColor = System.Drawing.Color.Black;
            this.reset_stats_winscreen.ForeColor = System.Drawing.Color.White;
            this.reset_stats_winscreen.Location = new System.Drawing.Point(12, 409);
            this.reset_stats_winscreen.Name = "reset_stats_winscreen";
            this.reset_stats_winscreen.Size = new System.Drawing.Size(81, 17);
            this.reset_stats_winscreen.TabIndex = 4;
            this.reset_stats_winscreen.Text = "Reset Stats";
            this.reset_stats_winscreen.UseVisualStyleBackColor = false;
            // 
            // Winscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 479);
            this.Controls.Add(this.reset_stats_winscreen);
            this.Controls.Add(this.changename_winscreen);
            this.Controls.Add(this.winscreen_exit);
            this.Controls.Add(this.winscreen_again);
            this.Controls.Add(this.winscreenTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Winscreen";
            this.Text = "Ultimate Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox winscreenTextbox;
        private System.Windows.Forms.Button winscreen_again;
        private System.Windows.Forms.Button winscreen_exit;
        private System.Windows.Forms.CheckBox changename_winscreen;
        private System.Windows.Forms.CheckBox reset_stats_winscreen;
    }
}