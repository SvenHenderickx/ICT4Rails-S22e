namespace RemiseHavestraat
{
    partial class ReparatieForm
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
            this.btnReparatieLijstOpvragen = new System.Windows.Forms.Button();
            this.dtpEindR = new System.Windows.Forms.DateTimePicker();
            this.btnAftekenenReparatie = new System.Windows.Forms.Button();
            this.lblDatumEind = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMedewerker = new System.Windows.Forms.ComboBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnTijdsindicatie = new System.Windows.Forms.Button();
            this.lbMedewerkers = new System.Windows.Forms.ListBox();
            this.lbReparatie = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReparatieLijstOpvragen
            // 
            this.btnReparatieLijstOpvragen.Location = new System.Drawing.Point(958, 289);
            this.btnReparatieLijstOpvragen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReparatieLijstOpvragen.Name = "btnReparatieLijstOpvragen";
            this.btnReparatieLijstOpvragen.Size = new System.Drawing.Size(183, 54);
            this.btnReparatieLijstOpvragen.TabIndex = 6;
            this.btnReparatieLijstOpvragen.Text = "Reparatielijst opvragen";
            this.btnReparatieLijstOpvragen.UseVisualStyleBackColor = true;
            this.btnReparatieLijstOpvragen.Click += new System.EventHandler(this.btnReparatieLijstOpvragen_Click);
            // 
            // dtpEindR
            // 
            this.dtpEindR.Location = new System.Drawing.Point(1169, 156);
            this.dtpEindR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEindR.Name = "dtpEindR";
            this.dtpEindR.Size = new System.Drawing.Size(180, 26);
            this.dtpEindR.TabIndex = 26;
            // 
            // btnAftekenenReparatie
            // 
            this.btnAftekenenReparatie.Location = new System.Drawing.Point(958, 353);
            this.btnAftekenenReparatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAftekenenReparatie.Name = "btnAftekenenReparatie";
            this.btnAftekenenReparatie.Size = new System.Drawing.Size(183, 54);
            this.btnAftekenenReparatie.TabIndex = 7;
            this.btnAftekenenReparatie.Text = "Aftekenen";
            this.btnAftekenenReparatie.UseVisualStyleBackColor = true;
            this.btnAftekenenReparatie.Click += new System.EventHandler(this.btnAftekenenReparatie_Click);
            // 
            // lblDatumEind
            // 
            this.lblDatumEind.AutoSize = true;
            this.lblDatumEind.Location = new System.Drawing.Point(1355, 162);
            this.lblDatumEind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumEind.Name = "lblDatumEind";
            this.lblDatumEind.Size = new System.Drawing.Size(57, 20);
            this.lblDatumEind.TabIndex = 27;
            this.lblDatumEind.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1355, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Medewerker";
            // 
            // cbMedewerker
            // 
            this.cbMedewerker.FormattingEnabled = true;
            this.cbMedewerker.Location = new System.Drawing.Point(1169, 69);
            this.cbMedewerker.Name = "cbMedewerker";
            this.cbMedewerker.Size = new System.Drawing.Size(180, 28);
            this.cbMedewerker.TabIndex = 44;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(968, 55);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(183, 54);
            this.btnVoegToe.TabIndex = 43;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            // 
            // btnTijdsindicatie
            // 
            this.btnTijdsindicatie.Location = new System.Drawing.Point(968, 145);
            this.btnTijdsindicatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTijdsindicatie.Name = "btnTijdsindicatie";
            this.btnTijdsindicatie.Size = new System.Drawing.Size(183, 54);
            this.btnTijdsindicatie.TabIndex = 42;
            this.btnTijdsindicatie.Text = "Tijdsindicatie geven";
            this.btnTijdsindicatie.UseVisualStyleBackColor = true;
            // 
            // lbMedewerkers
            // 
            this.lbMedewerkers.FormattingEnabled = true;
            this.lbMedewerkers.ItemHeight = 20;
            this.lbMedewerkers.Location = new System.Drawing.Point(731, 55);
            this.lbMedewerkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMedewerkers.Name = "lbMedewerkers";
            this.lbMedewerkers.Size = new System.Drawing.Size(219, 424);
            this.lbMedewerkers.TabIndex = 21;
            // 
            // lbReparatie
            // 
            this.lbReparatie.FormattingEnabled = true;
            this.lbReparatie.ItemHeight = 20;
            this.lbReparatie.Location = new System.Drawing.Point(25, 55);
            this.lbReparatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbReparatie.Name = "lbReparatie";
            this.lbReparatie.Size = new System.Drawing.Size(684, 424);
            this.lbReparatie.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reparaties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Medewerkers";
            // 
            // ReparatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 504);
            this.Controls.Add(this.lblDatumEind);
            this.Controls.Add(this.btnTijdsindicatie);
            this.Controls.Add(this.dtpEindR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMedewerker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lbReparatie);
            this.Controls.Add(this.btnReparatieLijstOpvragen);
            this.Controls.Add(this.lbMedewerkers);
            this.Controls.Add(this.btnAftekenenReparatie);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReparatieForm";
            this.Text = "ReparatieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnReparatieLijstOpvragen;
        private System.Windows.Forms.DateTimePicker dtpEindR;
        private System.Windows.Forms.Button btnAftekenenReparatie;
        private System.Windows.Forms.Label lblDatumEind;
        private System.Windows.Forms.ListBox lbMedewerkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedewerker;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnTijdsindicatie;
        private System.Windows.Forms.ListBox lbReparatie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}