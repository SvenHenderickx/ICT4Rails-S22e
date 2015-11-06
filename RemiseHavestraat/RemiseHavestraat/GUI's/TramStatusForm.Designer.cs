namespace RemiseHavestraat
{
    partial class TramStatusForm
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
            this.cbbTramStatus = new System.Windows.Forms.ComboBox();
            this.lblTramnummer = new System.Windows.Forms.Label();
            this.tbTramnummer = new System.Windows.Forms.TextBox();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbTramStatus
            // 
            this.cbbTramStatus.FormattingEnabled = true;
            this.cbbTramStatus.Items.AddRange(new object[] {
            "Defect",
            "Schoonmaak",
            "Dienst",
            "Remise"});
            this.cbbTramStatus.Location = new System.Drawing.Point(12, 12);
            this.cbbTramStatus.Name = "cbbTramStatus";
            this.cbbTramStatus.Size = new System.Drawing.Size(162, 21);
            this.cbbTramStatus.TabIndex = 0;
            this.cbbTramStatus.Text = "Voer status tram in";
            // 
            // lblTramnummer
            // 
            this.lblTramnummer.AutoSize = true;
            this.lblTramnummer.Location = new System.Drawing.Point(13, 53);
            this.lblTramnummer.Name = "lblTramnummer";
            this.lblTramnummer.Size = new System.Drawing.Size(68, 13);
            this.lblTramnummer.TabIndex = 1;
            this.lblTramnummer.Text = "Tramnummer";
            // 
            // tbTramnummer
            // 
            this.tbTramnummer.Location = new System.Drawing.Point(13, 70);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(64, 20);
            this.tbTramnummer.TabIndex = 2;
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(13, 119);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(75, 23);
            this.btnBevestig.TabIndex = 3;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(99, 119);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 4;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // TramStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 154);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.tbTramnummer);
            this.Controls.Add(this.lblTramnummer);
            this.Controls.Add(this.cbbTramStatus);
            this.Name = "TramStatusForm";
            this.Text = "Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTramStatus;
        private System.Windows.Forms.Label lblTramnummer;
        private System.Windows.Forms.TextBox tbTramnummer;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Button btnTerug;
    }
}