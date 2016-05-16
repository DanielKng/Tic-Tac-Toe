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
            this.changelog_browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // changelog_browser
            // 
            this.changelog_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changelog_browser.Location = new System.Drawing.Point(0, 0);
            this.changelog_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.changelog_browser.Name = "changelog_browser";
            this.changelog_browser.Size = new System.Drawing.Size(687, 732);
            this.changelog_browser.TabIndex = 0;
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 732);
            this.Controls.Add(this.changelog_browser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Changelog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser changelog_browser;
    }
}