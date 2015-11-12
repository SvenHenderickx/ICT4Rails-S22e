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
            this.cbbTramStatus.Location = new System.Drawing.Point(18, 18);
            this.cbbTramStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTramStatus.Name = "cbbTramStatus";
            this.cbbTramStatus.Size = new System.Drawing.Size(241, 28);
            this.cbbTramStatus.TabIndex = 0;
            this.cbbTramStatus.Text = "Voer status tram in";
            // 
            // lblTramnummer
            // 
            this.lblTramnummer.AutoSize = true;
            this.lblTramnummer.Location = new System.Drawing.Point(20, 82);
            this.lblTramnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramnummer.Name = "lblTramnummer";
            this.lblTramnummer.Size = new System.Drawing.Size(103, 20);
            this.lblTramnummer.TabIndex = 1;
            this.lblTramnummer.Text = "Tramnummer";
            // 
            // tbTramnummer
            // 
            this.tbTramnummer.Location = new System.Drawing.Point(20, 108);
            this.tbTramnummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(94, 26);
            this.tbTramnummer.TabIndex = 2;
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(20, 183);
            this.btnBevestig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(112, 35);
            this.btnBevestig.TabIndex = 3;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(148, 183);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(112, 35);
            this.btnTerug.TabIndex = 4;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // TramStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 237);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.tbTramnummer);
            this.Controls.Add(this.lblTramnummer);
            this.Controls.Add(this.cbbTramStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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