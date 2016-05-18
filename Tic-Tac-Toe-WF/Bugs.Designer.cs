namespace Tic_Tac_Toe_WF
{
    partial class Bugs
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
            this.bugs_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bugs_text
            // 
            this.bugs_text.BackColor = System.Drawing.SystemColors.Control;
            this.bugs_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bugs_text.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.bugs_text.Location = new System.Drawing.Point(-1, -1);
            this.bugs_text.Multiline = true;
            this.bugs_text.Name = "bugs_text";
            this.bugs_text.ReadOnly = true;
            this.bugs_text.Size = new System.Drawing.Size(559, 264);
            this.bugs_text.TabIndex = 0;
            this.bugs_text.TabStop = false;
            // 
            // Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.bugs_text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bugs";
            this.ShowIcon = false;
            this.Text = "Bugs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox bugs_text;
    }
}