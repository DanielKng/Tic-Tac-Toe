namespace Tic_Tac_Toe_WF
{
    partial class Changelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
            this.changelog_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changelog_box
            // 
            this.changelog_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changelog_box.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.changelog_box.Location = new System.Drawing.Point(-1, -1);
            this.changelog_box.Multiline = true;
            this.changelog_box.Name = "changelog_box";
            this.changelog_box.ReadOnly = true;
            this.changelog_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.changelog_box.Size = new System.Drawing.Size(859, 599);
            this.changelog_box.TabIndex = 0;
            this.changelog_box.TabStop = false;
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 596);
            this.Controls.Add(this.changelog_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Changelog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox changelog_box;
    }
}