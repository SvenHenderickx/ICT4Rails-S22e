namespace RemiseHavestraat
{
    partial class SpoorBlokkadeForm
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
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.tbSegmentnummer = new System.Windows.Forms.TextBox();
            this.lblSpoornummer = new System.Windows.Forms.Label();
            this.lblSegmentnummer = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(12, 43);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(67, 20);
            this.tbSpoornummer.TabIndex = 0;
            // 
            // tbSegmentnummer
            // 
            this.tbSegmentnummer.Location = new System.Drawing.Point(109, 43);
            this.tbSegmentnummer.Name = "tbSegmentnummer";
            this.tbSegmentnummer.Size = new System.Drawing.Size(68, 20);
            this.tbSegmentnummer.TabIndex = 1;
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(9, 27);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(70, 13);
            this.lblSpoornummer.TabIndex = 2;
            this.lblSpoornummer.Text = "spoornummer";
            // 
            // lblSegmentnummer
            // 
            this.lblSegmentnummer.AutoSize = true;
            this.lblSegmentnummer.Location = new System.Drawing.Point(98, 27);
            this.lblSegmentnummer.Name = "lblSegmentnummer";
            this.lblSegmentnummer.Size = new System.Drawing.Size(84, 13);
            this.lblSegmentnummer.TabIndex = 3;
            this.lblSegmentnummer.Text = "segmentnummer";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(12, 99);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(107, 99);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 5;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // SpoorBlokkadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 134);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblSegmentnummer);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.tbSegmentnummer);
            this.Controls.Add(this.tbSpoornummer);
            this.Name = "SpoorBlokkadeForm";
            this.Text = "Spoorblokkade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.TextBox tbSegmentnummer;
        private System.Windows.Forms.Label lblSpoornummer;
        private System.Windows.Forms.Label lblSegmentnummer;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnTerug;
    }
}