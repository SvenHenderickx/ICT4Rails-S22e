namespace RemiseHavestraat
{
    partial class SpoorUpdateForm
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
            this.btnBevestig = new System.Windows.Forms.Button();
            this.lblSpoornummer = new System.Windows.Forms.Label();
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(12, 67);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(75, 23);
            this.btnBevestig.TabIndex = 0;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(13, 13);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(72, 13);
            this.lblSpoornummer.TabIndex = 1;
            this.lblSpoornummer.Text = "Spoornummer";
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(13, 30);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(70, 20);
            this.tbSpoornummer.TabIndex = 2;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(124, 67);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // SpoorUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 107);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.btnBevestig);
            this.Name = "SpoorUpdateForm";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Label lblSpoornummer;
        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.Button btnTerug;
    }
}