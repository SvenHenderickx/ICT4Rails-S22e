namespace UI_forms
{
    partial class TramVerwijderenForm
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.tbTramnummer = new System.Windows.Forms.TextBox();
            this.lblTramnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(161, 91);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(12, 91);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(75, 23);
            this.btnBevestig.TabIndex = 1;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            // 
            // tbTramnummer
            // 
            this.tbTramnummer.Location = new System.Drawing.Point(12, 48);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(100, 20);
            this.tbTramnummer.TabIndex = 2;
            // 
            // lblTramnummer
            // 
            this.lblTramnummer.AutoSize = true;
            this.lblTramnummer.Location = new System.Drawing.Point(12, 32);
            this.lblTramnummer.Name = "lblTramnummer";
            this.lblTramnummer.Size = new System.Drawing.Size(64, 13);
            this.lblTramnummer.TabIndex = 3;
            this.lblTramnummer.Text = "tramnummer";
            // 
            // TramVerwijderenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 126);
            this.Controls.Add(this.lblTramnummer);
            this.Controls.Add(this.tbTramnummer);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.btnTerug);
            this.Name = "TramVerwijderenForm";
            this.Text = "Verwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.TextBox tbTramnummer;
        private System.Windows.Forms.Label lblTramnummer;
    }
}