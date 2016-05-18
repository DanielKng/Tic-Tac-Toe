namespace Tic_Tac_Toe_WF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changelog = new System.Windows.Forms.Button();
            this.enable_playernames = new System.Windows.Forms.CheckBox();
            this.options = new System.Windows.Forms.Button();
            this.bugs_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(220, 170);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Credits
            // 
            this.Credits.Location = new System.Drawing.Point(12, 247);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(75, 23);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = true;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(397, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Build: 1.33.7-release";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(220, 276);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // changelog
            // 
            this.changelog.Location = new System.Drawing.Point(12, 276);
            this.changelog.Name = "changelog";
            this.changelog.Size = new System.Drawing.Size(75, 23);
            this.changelog.TabIndex = 5;
            this.changelog.Text = "Changelog";
            this.changelog.UseVisualStyleBackColor = true;
            this.changelog.Click += new System.EventHandler(this.changelog_Click);
            // 
            // enable_playernames
            // 
            this.enable_playernames.AutoSize = true;
            this.enable_playernames.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_playernames.Location = new System.Drawing.Point(301, 172);
            this.enable_playernames.Name = "enable_playernames";
            this.enable_playernames.Size = new System.Drawing.Size(137, 21);
            this.enable_playernames.TabIndex = 6;
            this.enable_playernames.Text = "Enable Playernames";
            this.enable_playernames.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(220, 222);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(75, 23);
            this.options.TabIndex = 8;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // bugs_button
            // 
            this.bugs_button.Location = new System.Drawing.Point(12, 218);
            this.bugs_button.Name = "bugs_button";
            this.bugs_button.Size = new System.Drawing.Size(75, 23);
            this.bugs_button.TabIndex = 9;
            this.bugs_button.Text = "Bugs";
            this.bugs_button.UseVisualStyleBackColor = true;
            this.bugs_button.Click += new System.EventHandler(this.bugs_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.bugs_button);
            this.Controls.Add(this.options);
            this.Controls.Add(this.enable_playernames);
            this.Controls.Add(this.changelog);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Tic-Tac-Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Credits;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button changelog;
        private System.Windows.Forms.Button options;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.CheckBox enable_playernames;
        private System.Windows.Forms.Button bugs_button;
    }
}

