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
            this.lblTramlijst = new System.Windows.Forms.ListBox();
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.lblSpoornummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTramlijst
            // 
            this.lblTramlijst.FormattingEnabled = true;
            this.lblTramlijst.Location = new System.Drawing.Point(12, 55);
            this.lblTramlijst.Name = "lblTramlijst";
            this.lblTramlijst.Size = new System.Drawing.Size(243, 173);
            this.lblTramlijst.TabIndex = 0;
            this.lblTramlijst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(13, 29);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(100, 20);
            this.tbSpoornummer.TabIndex = 1;
            // 
            // lblSpoornummer
            // 
            this.lblSpoornummer.AutoSize = true;
            this.lblSpoornummer.Location = new System.Drawing.Point(13, 13);
            this.lblSpoornummer.Name = "lblSpoornummer";
            this.lblSpoornummer.Size = new System.Drawing.Size(70, 13);
            this.lblSpoornummer.TabIndex = 2;
            this.lblSpoornummer.Text = "spoornummer";
            // 
            // SpoorInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 243);
            this.Controls.Add(this.lblSpoornummer);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.lblTramlijst);
            this.Name = "SpoorInfoForm";
            this.Text = "info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblTramlijst;
        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.Label lblSpoornummer;
    }
}