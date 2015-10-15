namespace UI_forms
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
            this.tbTramnummer.Location = new System.Drawing.Point(12, 40);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(69, 20);
            this.tbTramnummer.TabIndex = 0;
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(115, 41);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(72, 20);
            this.tbSpoornummer.TabIndex = 1;
            // 
            // cbReparatie
            // 
            this.cbReparatie.AutoSize = true;
            this.cbReparatie.Location = new System.Drawing.Point(16, 66);
            this.cbReparatie.Name = "cbReparatie";
            this.cbReparatie.Size = new System.Drawing.Size(67, 17);
            this.cbReparatie.TabIndex = 3;
            this.cbReparatie.Text = "reparatie";
            this.cbReparatie.UseVisualStyleBackColor = true;
            // 
            // lblTramnummer
            // 
            this.lblTramnummer.AutoSize = true;
            this.lblTramnummer.Location = new System.Drawing.Point(13, 21);
            this.lblTramnummer.Name = "lblTramnummer";
            this.lblTramnummer.Size = new System.Drawing.Size(68, 13);
            this.lblTramnummer.TabIndex = 4;
            this.lblTramnummer.Text = "Tramnummer";
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(115, 21);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(72, 13);
            this.lblSpoornummer.TabIndex = 5;
            this.lblSpoornummer.Text = "Spoornummer";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(12, 122);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(75, 23);
            this.btnBevestig.TabIndex = 6;
            this.btnBevestig.Text = "bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(112, 122);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // cbSchoonmaak
            // 
            this.cbSchoonmaak.AutoSize = true;
            this.cbSchoonmaak.Location = new System.Drawing.Point(16, 89);
            this.cbSchoonmaak.Name = "cbSchoonmaak";
            this.cbSchoonmaak.Size = new System.Drawing.Size(87, 17);
            this.cbSchoonmaak.TabIndex = 8;
            this.cbSchoonmaak.Text = "schoonmaak";
            this.cbSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // TramReserveringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 157);
            this.Controls.Add(this.cbSchoonmaak);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.lblTramnummer);
            this.Controls.Add(this.cbReparatie);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.tbTramnummer);
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