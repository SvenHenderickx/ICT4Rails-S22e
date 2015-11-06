namespace RemiseHavestraat
{
    partial class SpoorInfoForm
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
            this.lbTramlijst = new System.Windows.Forms.ListBox();
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.lblSpoornummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTramlijst
            // 
            this.lbTramlijst.FormattingEnabled = true;
            this.lbTramlijst.Location = new System.Drawing.Point(12, 55);
            this.lbTramlijst.Name = "lbTramlijst";
            this.lbTramlijst.Size = new System.Drawing.Size(243, 173);
            this.lbTramlijst.TabIndex = 0;
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(13, 29);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(100, 20);
            this.tbSpoornummer.TabIndex = 1;
            this.tbSpoornummer.TextChanged += new System.EventHandler(this.tbSpoornummer_TextChanged);
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(13, 13);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(72, 13);
            this.lblSpoornummer.TabIndex = 2;
            this.lblSpoornummer.Text = "Spoornummer";
            // 
            // SpoorInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 243);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.lbTramlijst);
            this.Name = "SpoorInfoForm";
            this.Text = "Spoorinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTramlijst;
        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.Label lblSpoornummer;
    }
}