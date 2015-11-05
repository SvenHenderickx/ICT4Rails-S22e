namespace RemiseHavestraat.GUI_s
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
            this.btnTakenToevoegenReparatie = new System.Windows.Forms.Button();
            this.btnAftekenenReparatie = new System.Windows.Forms.Button();
            this.btnReparatieLijstOpvragen = new System.Windows.Forms.Button();
            this.lbReparatie = new System.Windows.Forms.ListBox();
            this.gbTaak = new System.Windows.Forms.GroupBox();
            this.lblDatumEind = new System.Windows.Forms.Label();
            this.dtpEindR = new System.Windows.Forms.DateTimePicker();
            this.lblDatumBegin = new System.Windows.Forms.Label();
            this.dtpBeginR = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblPrioriteit = new System.Windows.Forms.Label();
            this.tbPrioriteit = new System.Windows.Forms.TextBox();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.lblTramNummer = new System.Windows.Forms.Label();
            this.tbTreinNummerSchoonmaak = new System.Windows.Forms.TextBox();
            this.lblMedewerkers = new System.Windows.Forms.Label();
            this.tbMedewerker = new System.Windows.Forms.TextBox();
            this.gbTaak.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTakenToevoegenReparatie
            // 
            this.btnTakenToevoegenReparatie.Location = new System.Drawing.Point(6, 287);
            this.btnTakenToevoegenReparatie.Name = "btnTakenToevoegenReparatie";
            this.btnTakenToevoegenReparatie.Size = new System.Drawing.Size(122, 35);
            this.btnTakenToevoegenReparatie.TabIndex = 9;
            this.btnTakenToevoegenReparatie.Text = "Taken toevoegen";
            this.btnTakenToevoegenReparatie.UseVisualStyleBackColor = true;
            this.btnTakenToevoegenReparatie.Click += new System.EventHandler(this.btnTakenToevoegenReparatie_Click);
            // 
            // btnAftekenenReparatie
            // 
            this.btnAftekenenReparatie.Location = new System.Drawing.Point(141, 287);
            this.btnAftekenenReparatie.Name = "btnAftekenenReparatie";
            this.btnAftekenenReparatie.Size = new System.Drawing.Size(122, 35);
            this.btnAftekenenReparatie.TabIndex = 7;
            this.btnAftekenenReparatie.Text = "Aftekenen";
            this.btnAftekenenReparatie.UseVisualStyleBackColor = true;
            this.btnAftekenenReparatie.Click += new System.EventHandler(this.btnAftekenenReparatie_Click);
            // 
            // btnReparatieLijstOpvragen
            // 
            this.btnReparatieLijstOpvragen.Location = new System.Drawing.Point(141, 245);
            this.btnReparatieLijstOpvragen.Name = "btnReparatieLijstOpvragen";
            this.btnReparatieLijstOpvragen.Size = new System.Drawing.Size(122, 35);
            this.btnReparatieLijstOpvragen.TabIndex = 6;
            this.btnReparatieLijstOpvragen.Text = "Reparatielijst opvragen";
            this.btnReparatieLijstOpvragen.UseVisualStyleBackColor = true;
            this.btnReparatieLijstOpvragen.Click += new System.EventHandler(this.btnReparatieLijstOpvragen_Click);
            // 
            // lbReparatie
            // 
            this.lbReparatie.FormattingEnabled = true;
            this.lbReparatie.Location = new System.Drawing.Point(12, 16);
            this.lbReparatie.Name = "lbReparatie";
            this.lbReparatie.Size = new System.Drawing.Size(314, 316);
            this.lbReparatie.TabIndex = 5;
            // 
            // gbTaak
            // 
            this.gbTaak.Controls.Add(this.lblDatumEind);
            this.gbTaak.Controls.Add(this.btnAftekenenReparatie);
            this.gbTaak.Controls.Add(this.dtpEindR);
            this.gbTaak.Controls.Add(this.btnReparatieLijstOpvragen);
            this.gbTaak.Controls.Add(this.lblDatumBegin);
            this.gbTaak.Controls.Add(this.dtpBeginR);
            this.gbTaak.Controls.Add(this.lblType);
            this.gbTaak.Controls.Add(this.tbType);
            this.gbTaak.Controls.Add(this.lblPrioriteit);
            this.gbTaak.Controls.Add(this.btnTakenToevoegenReparatie);
            this.gbTaak.Controls.Add(this.tbPrioriteit);
            this.gbTaak.Controls.Add(this.tbBeschrijving);
            this.gbTaak.Controls.Add(this.lblBeschrijving);
            this.gbTaak.Controls.Add(this.lblTramNummer);
            this.gbTaak.Controls.Add(this.tbTreinNummerSchoonmaak);
            this.gbTaak.Controls.Add(this.lblMedewerkers);
            this.gbTaak.Controls.Add(this.tbMedewerker);
            this.gbTaak.Location = new System.Drawing.Point(332, 12);
            this.gbTaak.Name = "gbTaak";
            this.gbTaak.Size = new System.Drawing.Size(272, 331);
            this.gbTaak.TabIndex = 20;
            this.gbTaak.TabStop = false;
            this.gbTaak.Text = "Reparatie";
            // 
            // lblDatumEind
            // 
            this.lblDatumEind.AutoSize = true;
            this.lblDatumEind.Location = new System.Drawing.Point(138, 75);
            this.lblDatumEind.Name = "lblDatumEind";
            this.lblDatumEind.Size = new System.Drawing.Size(64, 13);
            this.lblDatumEind.TabIndex = 27;
            this.lblDatumEind.Text = "Datum eind:";
            // 
            // dtpEindR
            // 
            this.dtpEindR.Location = new System.Drawing.Point(139, 91);
            this.dtpEindR.Name = "dtpEindR";
            this.dtpEindR.Size = new System.Drawing.Size(121, 20);
            this.dtpEindR.TabIndex = 26;
            // 
            // lblDatumBegin
            // 
            this.lblDatumBegin.AutoSize = true;
            this.lblDatumBegin.Location = new System.Drawing.Point(138, 23);
            this.lblDatumBegin.Name = "lblDatumBegin";
            this.lblDatumBegin.Size = new System.Drawing.Size(70, 13);
            this.lblDatumBegin.TabIndex = 25;
            this.lblDatumBegin.Text = "Datum begin:";
            // 
            // dtpBeginR
            // 
            this.dtpBeginR.Location = new System.Drawing.Point(139, 39);
            this.dtpBeginR.Name = "dtpBeginR";
            this.dtpBeginR.Size = new System.Drawing.Size(121, 20);
            this.dtpBeginR.TabIndex = 24;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 129);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Type:";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(9, 145);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(122, 20);
            this.tbType.TabIndex = 22;
            // 
            // lblPrioriteit
            // 
            this.lblPrioriteit.AutoSize = true;
            this.lblPrioriteit.Location = new System.Drawing.Point(9, 226);
            this.lblPrioriteit.Name = "lblPrioriteit";
            this.lblPrioriteit.Size = new System.Drawing.Size(47, 13);
            this.lblPrioriteit.TabIndex = 21;
            this.lblPrioriteit.Text = "Prioriteit:";
            // 
            // tbPrioriteit
            // 
            this.tbPrioriteit.Location = new System.Drawing.Point(9, 245);
            this.tbPrioriteit.Name = "tbPrioriteit";
            this.tbPrioriteit.Size = new System.Drawing.Size(122, 20);
            this.tbPrioriteit.TabIndex = 20;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(9, 195);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(122, 20);
            this.tbBeschrijving.TabIndex = 19;
            // 
            // lblBeschrijving
            // 
            this.lblBeschrijving.AutoSize = true;
            this.lblBeschrijving.Location = new System.Drawing.Point(10, 179);
            this.lblBeschrijving.Name = "lblBeschrijving";
            this.lblBeschrijving.Size = new System.Drawing.Size(67, 13);
            this.lblBeschrijving.TabIndex = 18;
            this.lblBeschrijving.Text = "Beschrijving:";
            // 
            // lblTramNummer
            // 
            this.lblTramNummer.AutoSize = true;
            this.lblTramNummer.Location = new System.Drawing.Point(6, 23);
            this.lblTramNummer.Name = "lblTramNummer";
            this.lblTramNummer.Size = new System.Drawing.Size(71, 13);
            this.lblTramNummer.TabIndex = 13;
            this.lblTramNummer.Tag = "";
            this.lblTramNummer.Text = "Tramnummer:";
            // 
            // tbTreinNummerSchoonmaak
            // 
            this.tbTreinNummerSchoonmaak.Location = new System.Drawing.Point(9, 39);
            this.tbTreinNummerSchoonmaak.Name = "tbTreinNummerSchoonmaak";
            this.tbTreinNummerSchoonmaak.Size = new System.Drawing.Size(122, 20);
            this.tbTreinNummerSchoonmaak.TabIndex = 12;
            // 
            // lblMedewerkers
            // 
            this.lblMedewerkers.AutoSize = true;
            this.lblMedewerkers.Location = new System.Drawing.Point(6, 77);
            this.lblMedewerkers.Name = "lblMedewerkers";
            this.lblMedewerkers.Size = new System.Drawing.Size(69, 13);
            this.lblMedewerkers.TabIndex = 14;
            this.lblMedewerkers.Text = "Medewerker:";
            // 
            // tbMedewerker
            // 
            this.tbMedewerker.Location = new System.Drawing.Point(9, 93);
            this.tbMedewerker.Name = "tbMedewerker";
            this.tbMedewerker.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker.TabIndex = 15;
            // 
            // ReparatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 346);
            this.Controls.Add(this.gbTaak);
            this.Controls.Add(this.lbReparatie);
            this.Name = "ReparatieForm";
            this.Text = "ReparatieForm";
            this.gbTaak.ResumeLayout(false);
            this.gbTaak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakenToevoegenReparatie;
        private System.Windows.Forms.Button btnAftekenenReparatie;
        private System.Windows.Forms.Button btnReparatieLijstOpvragen;
        private System.Windows.Forms.ListBox lbReparatie;
        private System.Windows.Forms.GroupBox gbTaak;
        private System.Windows.Forms.Label lblDatumEind;
        private System.Windows.Forms.DateTimePicker dtpEindR;
        private System.Windows.Forms.Label lblDatumBegin;
        private System.Windows.Forms.DateTimePicker dtpBeginR;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lblPrioriteit;
        private System.Windows.Forms.TextBox tbPrioriteit;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.Label lblBeschrijving;
        private System.Windows.Forms.Label lblTramNummer;
        private System.Windows.Forms.TextBox tbTreinNummerSchoonmaak;
        private System.Windows.Forms.Label lblMedewerkers;
        private System.Windows.Forms.TextBox tbMedewerker;
    }
}