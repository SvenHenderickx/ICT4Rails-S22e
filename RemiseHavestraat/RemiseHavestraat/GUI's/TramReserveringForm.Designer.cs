namespace RemiseHavestraat
{
    partial class TramReserveringForm
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
            this.tbTramnummer = new System.Windows.Forms.TextBox();
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.cbReparatie = new System.Windows.Forms.CheckBox();
            this.lblTramnummer = new System.Windows.Forms.Label();
            this.lblSpoornummer = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.cbSchoonmaak = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbTramnummer
            // 
            this.tbTramnummer.Location = new System.Drawing.Point(18, 62);
            this.tbTramnummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(102, 26);
            this.tbTramnummer.TabIndex = 0;
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(172, 63);
            this.tbSpoornummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(106, 26);
            this.tbSpoornummer.TabIndex = 1;
            // 
            // cbReparatie
            // 
            this.cbReparatie.AutoSize = true;
            this.cbReparatie.Location = new System.Drawing.Point(24, 102);
            this.cbReparatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbReparatie.Name = "cbReparatie";
            this.cbReparatie.Size = new System.Drawing.Size(98, 24);
            this.cbReparatie.TabIndex = 3;
            this.cbReparatie.Text = "reparatie";
            this.cbReparatie.UseVisualStyleBackColor = true;
            // 
            // lblTramnummer
            // 
            this.lblTramnummer.AutoSize = true;
            this.lblTramnummer.Location = new System.Drawing.Point(20, 32);
            this.lblTramnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramnummer.Name = "lblTramnummer";
            this.lblTramnummer.Size = new System.Drawing.Size(103, 20);
            this.lblTramnummer.TabIndex = 4;
            this.lblTramnummer.Text = "Tramnummer";
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(172, 32);
            this.lblSpoornummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(110, 20);
            this.lblSpoornummer.TabIndex = 5;
            this.lblSpoornummer.Text = "Spoornummer";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(18, 188);
            this.btnBevestig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(112, 35);
            this.btnBevestig.TabIndex = 6;
            this.btnBevestig.Text = "bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(168, 188);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(112, 35);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // cbSchoonmaak
            // 
            this.cbSchoonmaak.AutoSize = true;
            this.cbSchoonmaak.Location = new System.Drawing.Point(24, 137);
            this.cbSchoonmaak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSchoonmaak.Name = "cbSchoonmaak";
            this.cbSchoonmaak.Size = new System.Drawing.Size(126, 24);
            this.cbSchoonmaak.TabIndex = 8;
            this.cbSchoonmaak.Text = "schoonmaak";
            this.cbSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // TramReserveringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 242);
            this.Controls.Add(this.cbSchoonmaak);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.lblTramnummer);
            this.Controls.Add(this.cbReparatie);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.tbTramnummer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TramReserveringForm";
            this.Text = "reservering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTramnummer;
        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.CheckBox cbReparatie;
        private System.Windows.Forms.Label lblTramnummer;
        private System.Windows.Forms.Label lblSpoornummer;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.CheckBox cbSchoonmaak;
    }
}