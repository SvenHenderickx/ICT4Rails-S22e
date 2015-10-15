namespace UI_forms
{
    partial class TramPlaatsenForm
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
            this.lblTramnummer = new System.Windows.Forms.Label();
            this.lblSpoornummer = new System.Windows.Forms.Label();
            this.lblSegmentnummer = new System.Windows.Forms.Label();
            this.tbTramnummer = new System.Windows.Forms.TextBox();
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.tbSegmentnummer = new System.Windows.Forms.TextBox();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTramnummer
            // 
            this.lblTramnummer.AutoSize = true;
            this.lblTramnummer.Location = new System.Drawing.Point(9, 44);
            this.lblTramnummer.Name = "lblTramnummer";
            this.lblTramnummer.Size = new System.Drawing.Size(68, 13);
            this.lblTramnummer.TabIndex = 0;
            this.lblTramnummer.Text = "Tramnummer";
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(94, 43);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(72, 13);
            this.lblSpoornummer.TabIndex = 1;
            this.lblSpoornummer.Text = "Spoornummer";
            // 
            // lblSegmentnummer
            // 
            this.lblSegmentnummer.AutoSize = true;
            this.lblSegmentnummer.Location = new System.Drawing.Point(185, 43);
            this.lblSegmentnummer.Name = "lblSegmentnummer";
            this.lblSegmentnummer.Size = new System.Drawing.Size(86, 13);
            this.lblSegmentnummer.TabIndex = 2;
            this.lblSegmentnummer.Text = "Segmentnummer";
            // 
            // tbTramnummer
            // 
            this.tbTramnummer.Location = new System.Drawing.Point(12, 60);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(56, 20);
            this.tbTramnummer.TabIndex = 3;
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(97, 60);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(69, 20);
            this.tbSpoornummer.TabIndex = 4;
            // 
            // tbSegmentnummer
            // 
            this.tbSegmentnummer.Location = new System.Drawing.Point(197, 59);
            this.tbSegmentnummer.Name = "tbSegmentnummer";
            this.tbSegmentnummer.Size = new System.Drawing.Size(58, 20);
            this.tbSegmentnummer.TabIndex = 5;
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(22, 120);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(75, 23);
            this.btnBevestig.TabIndex = 6;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(180, 120);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // TramPlaatsenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.tbSegmentnummer);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.tbTramnummer);
            this.Controls.Add(this.lblSegmentnummer);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.lblTramnummer);
            this.Name = "TramPlaatsenForm";
            this.Text = "Plaatsen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTramnummer;
        private System.Windows.Forms.Label lblSpoornummer;
        private System.Windows.Forms.Label lblSegmentnummer;
        private System.Windows.Forms.TextBox tbTramnummer;
        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.TextBox tbSegmentnummer;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Button btnTerug;
    }
}