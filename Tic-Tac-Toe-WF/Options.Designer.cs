namespace Tic_Tac_Toe_WF
{
    partial class Options
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
            this.enable_music = new System.Windows.Forms.CheckBox();
            this.enable_sound = new System.Windows.Forms.CheckBox();
            this.enable_darkmode = new System.Windows.Forms.CheckBox();
            this.delete_files = new System.Windows.Forms.CheckBox();
            this.warning_text = new System.Windows.Forms.TextBox();
            this.apply_options = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.nope = new System.Windows.Forms.Label();
            this.download_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enable_music
            // 
            this.enable_music.AutoSize = true;
            this.enable_music.BackColor = System.Drawing.Color.White;
            this.enable_music.ForeColor = System.Drawing.Color.Black;
            this.enable_music.Location = new System.Drawing.Point(112, 80);
            this.enable_music.Name = "enable_music";
            this.enable_music.Size = new System.Drawing.Size(90, 17);
            this.enable_music.TabIndex = 0;
            this.enable_music.Text = "Enable Music";
            this.enable_music.UseVisualStyleBackColor = false;
            // 
            // enable_sound
            // 
            this.enable_sound.AutoSize = true;
            this.enable_sound.Location = new System.Drawing.Point(112, 113);
            this.enable_sound.Name = "enable_sound";
            this.enable_sound.Size = new System.Drawing.Size(98, 17);
            this.enable_sound.TabIndex = 2;
            this.enable_sound.Text = "Enable Sounds";
            this.enable_sound.UseVisualStyleBackColor = true;
            // 
            // enable_darkmode
            // 
            this.enable_darkmode.AutoSize = true;
            this.enable_darkmode.Checked = global::Tic_Tac_Toe_WF.Properties.Settings.Default.darkmode_checked;
            this.enable_darkmode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tic_Tac_Toe_WF.Properties.Settings.Default, "darkmode_checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enable_darkmode.Location = new System.Drawing.Point(112, 150);
            this.enable_darkmode.Name = "enable_darkmode";
            this.enable_darkmode.Size = new System.Drawing.Size(115, 17);
            this.enable_darkmode.TabIndex = 3;
            this.enable_darkmode.Text = "Enable Dark Mode";
            this.enable_darkmode.UseVisualStyleBackColor = true;
            // 
            // delete_files
            // 
            this.delete_files.AutoSize = true;
            this.delete_files.Location = new System.Drawing.Point(12, 150);
            this.delete_files.Name = "delete_files";
            this.delete_files.Size = new System.Drawing.Size(81, 17);
            this.delete_files.TabIndex = 8;
            this.delete_files.Text = "Delete Files";
            this.delete_files.UseVisualStyleBackColor = true;
            this.delete_files.Visible = false;
            // 
            // warning_text
            // 
            this.warning_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warning_text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warning_text.Location = new System.Drawing.Point(-1, 12);
            this.warning_text.Multiline = true;
            this.warning_text.Name = "warning_text";
            this.warning_text.Size = new System.Drawing.Size(315, 62);
            this.warning_text.TabIndex = 5;
            this.warning_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // apply_options
            // 
            this.apply_options.Location = new System.Drawing.Point(208, 253);
            this.apply_options.Name = "apply_options";
            this.apply_options.Size = new System.Drawing.Size(75, 23);
            this.apply_options.TabIndex = 1;
            this.apply_options.Text = "Apply";
            this.apply_options.UseVisualStyleBackColor = true;
            this.apply_options.Click += new System.EventHandler(this.apply_options_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(21, 253);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // nope
            // 
            this.nope.AutoSize = true;
            this.nope.ForeColor = System.Drawing.Color.Red;
            this.nope.Location = new System.Drawing.Point(96, 12);
            this.nope.Name = "nope";
            this.nope.Size = new System.Drawing.Size(99, 13);
            this.nope.TabIndex = 0;
            this.nope.Text = "You cannot do this!";
            this.nope.Visible = false;
            // 
            // download_info
            // 
            this.download_info.BackColor = System.Drawing.SystemColors.Window;
            this.download_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.download_info.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_info.Location = new System.Drawing.Point(12, 186);
            this.download_info.Multiline = true;
            this.download_info.Name = "download_info";
            this.download_info.ReadOnly = true;
            this.download_info.Size = new System.Drawing.Size(288, 61);
            this.download_info.TabIndex = 0;
            this.download_info.TabStop = false;
            this.download_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.download_info.Visible = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 289);
            this.ControlBox = false;
            this.Controls.Add(this.download_info);
            this.Controls.Add(this.nope);
            this.Controls.Add(this.delete_files);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.warning_text);
            this.Controls.Add(this.enable_darkmode);
            this.Controls.Add(this.enable_sound);
            this.Controls.Add(this.apply_options);
            this.Controls.Add(this.enable_music);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox enable_music;
        public System.Windows.Forms.CheckBox enable_sound;
        public System.Windows.Forms.CheckBox enable_darkmode;
        private System.Windows.Forms.CheckBox delete_files;
        private System.Windows.Forms.TextBox warning_text;
        public System.Windows.Forms.Button apply_options;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label nope;
        private System.Windows.Forms.TextBox download_info;
    }
}