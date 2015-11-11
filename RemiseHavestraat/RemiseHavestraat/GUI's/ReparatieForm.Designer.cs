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
            this.lbReparatie = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMedewerker1 = new System.Windows.Forms.TextBox();
            this.lblMedewerkers = new System.Windows.Forms.Label();
            this.tbTreinNummerSchoonmaak = new System.Windows.Forms.TextBox();
            this.lblTramNummer = new System.Windows.Forms.Label();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.btnTakenToevoegenReparatie = new System.Windows.Forms.Button();
            this.dtpBeginR = new System.Windows.Forms.DateTimePicker();
            this.lblDatumBegin = new System.Windows.Forms.Label();
            this.btnReparatieLijstOpvragen = new System.Windows.Forms.Button();
            this.dtpEindR = new System.Windows.Forms.DateTimePicker();
            this.btnAftekenenReparatie = new System.Windows.Forms.Button();
            this.lblDatumEind = new System.Windows.Forms.Label();
            this.tbMedewerker2 = new System.Windows.Forms.TextBox();
            this.tbMedewerker3 = new System.Windows.Forms.TextBox();
            this.tbMedewerker4 = new System.Windows.Forms.TextBox();
            this.tbMedewerker5 = new System.Windows.Forms.TextBox();
            this.gbTaak = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNietBelangrijk = new System.Windows.Forms.RadioButton();
            this.rbNormaal = new System.Windows.Forms.RadioButton();
            this.rbSpoed = new System.Windows.Forms.RadioButton();
            this.rbKlein = new System.Windows.Forms.RadioButton();
            this.rbGroot = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbTaak.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbReparatie
            // 
            this.lbReparatie.FormattingEnabled = true;
            this.lbReparatie.Location = new System.Drawing.Point(12, 16);
            this.lbReparatie.Name = "lbReparatie";
            this.lbReparatie.Size = new System.Drawing.Size(314, 394);
            this.lbReparatie.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSpoed);
            this.groupBox1.Controls.Add(this.rbNormaal);
            this.groupBox1.Controls.Add(this.rbNietBelangrijk);
            this.groupBox1.Location = new System.Drawing.Point(9, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 143);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prioriteit";
            // 
            // tbMedewerker1
            // 
            this.tbMedewerker1.Location = new System.Drawing.Point(9, 267);
            this.tbMedewerker1.Name = "tbMedewerker1";
            this.tbMedewerker1.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker1.TabIndex = 15;
            // 
            // lblMedewerkers
            // 
            this.lblMedewerkers.AutoSize = true;
            this.lblMedewerkers.Location = new System.Drawing.Point(10, 251);
            this.lblMedewerkers.Name = "lblMedewerkers";
            this.lblMedewerkers.Size = new System.Drawing.Size(74, 13);
            this.lblMedewerkers.TabIndex = 14;
            this.lblMedewerkers.Text = "Medewerkers:";
            // 
            // tbTreinNummerSchoonmaak
            // 
            this.tbTreinNummerSchoonmaak.Location = new System.Drawing.Point(9, 39);
            this.tbTreinNummerSchoonmaak.Name = "tbTreinNummerSchoonmaak";
            this.tbTreinNummerSchoonmaak.Size = new System.Drawing.Size(122, 20);
            this.tbTreinNummerSchoonmaak.TabIndex = 12;
            // 
            // lblTramNummer
            // 
            this.lblTramNummer.AutoSize = true;
            this.lblTramNummer.Location = new System.Drawing.Point(10, 23);
            this.lblTramNummer.Name = "lblTramNummer";
            this.lblTramNummer.Size = new System.Drawing.Size(71, 13);
            this.lblTramNummer.TabIndex = 13;
            this.lblTramNummer.Tag = "";
            this.lblTramNummer.Text = "Tramnummer:";
            // 
            // lblBeschrijving
            // 
            this.lblBeschrijving.AutoSize = true;
            this.lblBeschrijving.Location = new System.Drawing.Point(10, 64);
            this.lblBeschrijving.Name = "lblBeschrijving";
            this.lblBeschrijving.Size = new System.Drawing.Size(67, 13);
            this.lblBeschrijving.TabIndex = 18;
            this.lblBeschrijving.Text = "Beschrijving:";
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(9, 80);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(122, 20);
            this.tbBeschrijving.TabIndex = 19;
            // 
            // btnTakenToevoegenReparatie
            // 
            this.btnTakenToevoegenReparatie.Location = new System.Drawing.Point(141, 357);
            this.btnTakenToevoegenReparatie.Name = "btnTakenToevoegenReparatie";
            this.btnTakenToevoegenReparatie.Size = new System.Drawing.Size(122, 35);
            this.btnTakenToevoegenReparatie.TabIndex = 9;
            this.btnTakenToevoegenReparatie.Text = "Taken toevoegen";
            this.btnTakenToevoegenReparatie.UseVisualStyleBackColor = true;
            this.btnTakenToevoegenReparatie.Click += new System.EventHandler(this.btnTakenToevoegenReparatie_Click);
            // 
            // dtpBeginR
            // 
            this.dtpBeginR.Location = new System.Drawing.Point(139, 39);
            this.dtpBeginR.Name = "dtpBeginR";
            this.dtpBeginR.Size = new System.Drawing.Size(121, 20);
            this.dtpBeginR.TabIndex = 24;
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
            // btnReparatieLijstOpvragen
            // 
            this.btnReparatieLijstOpvragen.Location = new System.Drawing.Point(141, 267);
            this.btnReparatieLijstOpvragen.Name = "btnReparatieLijstOpvragen";
            this.btnReparatieLijstOpvragen.Size = new System.Drawing.Size(122, 35);
            this.btnReparatieLijstOpvragen.TabIndex = 6;
            this.btnReparatieLijstOpvragen.Text = "Reparatielijst opvragen";
            this.btnReparatieLijstOpvragen.UseVisualStyleBackColor = true;
            this.btnReparatieLijstOpvragen.Click += new System.EventHandler(this.btnReparatieLijstOpvragen_Click);
            // 
            // dtpEindR
            // 
            this.dtpEindR.Location = new System.Drawing.Point(139, 80);
            this.dtpEindR.Name = "dtpEindR";
            this.dtpEindR.Size = new System.Drawing.Size(121, 20);
            this.dtpEindR.TabIndex = 26;
            // 
            // btnAftekenenReparatie
            // 
            this.btnAftekenenReparatie.Location = new System.Drawing.Point(141, 313);
            this.btnAftekenenReparatie.Name = "btnAftekenenReparatie";
            this.btnAftekenenReparatie.Size = new System.Drawing.Size(122, 35);
            this.btnAftekenenReparatie.TabIndex = 7;
            this.btnAftekenenReparatie.Text = "Aftekenen";
            this.btnAftekenenReparatie.UseVisualStyleBackColor = true;
            this.btnAftekenenReparatie.Click += new System.EventHandler(this.btnAftekenenReparatie_Click);
            // 
            // lblDatumEind
            // 
            this.lblDatumEind.AutoSize = true;
            this.lblDatumEind.Location = new System.Drawing.Point(138, 64);
            this.lblDatumEind.Name = "lblDatumEind";
            this.lblDatumEind.Size = new System.Drawing.Size(64, 13);
            this.lblDatumEind.TabIndex = 27;
            this.lblDatumEind.Text = "Datum eind:";
            // 
            // tbMedewerker2
            // 
            this.tbMedewerker2.Location = new System.Drawing.Point(9, 294);
            this.tbMedewerker2.Name = "tbMedewerker2";
            this.tbMedewerker2.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker2.TabIndex = 28;
            // 
            // tbMedewerker3
            // 
            this.tbMedewerker3.Location = new System.Drawing.Point(9, 320);
            this.tbMedewerker3.Name = "tbMedewerker3";
            this.tbMedewerker3.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker3.TabIndex = 29;
            // 
            // tbMedewerker4
            // 
            this.tbMedewerker4.Location = new System.Drawing.Point(9, 346);
            this.tbMedewerker4.Name = "tbMedewerker4";
            this.tbMedewerker4.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker4.TabIndex = 30;
            // 
            // tbMedewerker5
            // 
            this.tbMedewerker5.Location = new System.Drawing.Point(9, 372);
            this.tbMedewerker5.Name = "tbMedewerker5";
            this.tbMedewerker5.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker5.TabIndex = 31;
            // 
            // gbTaak
            // 
            this.gbTaak.Controls.Add(this.groupBox2);
            this.gbTaak.Controls.Add(this.groupBox1);
            this.gbTaak.Controls.Add(this.tbMedewerker5);
            this.gbTaak.Controls.Add(this.tbMedewerker4);
            this.gbTaak.Controls.Add(this.tbMedewerker3);
            this.gbTaak.Controls.Add(this.tbMedewerker2);
            this.gbTaak.Controls.Add(this.lblDatumEind);
            this.gbTaak.Controls.Add(this.btnAftekenenReparatie);
            this.gbTaak.Controls.Add(this.dtpEindR);
            this.gbTaak.Controls.Add(this.btnReparatieLijstOpvragen);
            this.gbTaak.Controls.Add(this.lblDatumBegin);
            this.gbTaak.Controls.Add(this.dtpBeginR);
            this.gbTaak.Controls.Add(this.btnTakenToevoegenReparatie);
            this.gbTaak.Controls.Add(this.tbBeschrijving);
            this.gbTaak.Controls.Add(this.lblBeschrijving);
            this.gbTaak.Controls.Add(this.lblTramNummer);
            this.gbTaak.Controls.Add(this.tbTreinNummerSchoonmaak);
            this.gbTaak.Controls.Add(this.lblMedewerkers);
            this.gbTaak.Controls.Add(this.tbMedewerker1);
            this.gbTaak.Location = new System.Drawing.Point(332, 12);
            this.gbTaak.Name = "gbTaak";
            this.gbTaak.Size = new System.Drawing.Size(272, 398);
            this.gbTaak.TabIndex = 20;
            this.gbTaak.TabStop = false;
            this.gbTaak.Text = "Reparatie";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbGroot);
            this.groupBox2.Controls.Add(this.rbKlein);
            this.groupBox2.Location = new System.Drawing.Point(139, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 142);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soort";
            // 
            // rbNietBelangrijk
            // 
            this.rbNietBelangrijk.AutoSize = true;
            this.rbNietBelangrijk.Location = new System.Drawing.Point(7, 20);
            this.rbNietBelangrijk.Name = "rbNietBelangrijk";
            this.rbNietBelangrijk.Size = new System.Drawing.Size(93, 17);
            this.rbNietBelangrijk.TabIndex = 0;
            this.rbNietBelangrijk.TabStop = true;
            this.rbNietBelangrijk.Text = "Niet Belangrijk";
            this.rbNietBelangrijk.UseVisualStyleBackColor = true;
            // 
            // rbNormaal
            // 
            this.rbNormaal.AutoSize = true;
            this.rbNormaal.Checked = true;
            this.rbNormaal.Location = new System.Drawing.Point(6, 43);
            this.rbNormaal.Name = "rbNormaal";
            this.rbNormaal.Size = new System.Drawing.Size(64, 17);
            this.rbNormaal.TabIndex = 1;
            this.rbNormaal.TabStop = true;
            this.rbNormaal.Text = "Normaal";
            this.rbNormaal.UseVisualStyleBackColor = true;
            // 
            // rbSpoed
            // 
            this.rbSpoed.AutoSize = true;
            this.rbSpoed.Location = new System.Drawing.Point(6, 66);
            this.rbSpoed.Name = "rbSpoed";
            this.rbSpoed.Size = new System.Drawing.Size(56, 17);
            this.rbSpoed.TabIndex = 2;
            this.rbSpoed.TabStop = true;
            this.rbSpoed.Text = "Spoed";
            this.rbSpoed.UseVisualStyleBackColor = true;
            // 
            // rbKlein
            // 
            this.rbKlein.AutoSize = true;
            this.rbKlein.Checked = true;
            this.rbKlein.Location = new System.Drawing.Point(7, 19);
            this.rbKlein.Name = "rbKlein";
            this.rbKlein.Size = new System.Drawing.Size(48, 17);
            this.rbKlein.TabIndex = 0;
            this.rbKlein.TabStop = true;
            this.rbKlein.Text = "Klein";
            this.rbKlein.UseVisualStyleBackColor = true;
            // 
            // rbGroot
            // 
            this.rbGroot.AutoSize = true;
            this.rbGroot.Location = new System.Drawing.Point(7, 42);
            this.rbGroot.Name = "rbGroot";
            this.rbGroot.Size = new System.Drawing.Size(51, 17);
            this.rbGroot.TabIndex = 1;
            this.rbGroot.TabStop = true;
            this.rbGroot.Text = "Groot";
            this.rbGroot.UseVisualStyleBackColor = true;
            // 
            // ReparatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 418);
            this.Controls.Add(this.gbTaak);
            this.Controls.Add(this.lbReparatie);
            this.Name = "ReparatieForm";
            this.Text = "ReparatieForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTaak.ResumeLayout(false);
            this.gbTaak.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbReparatie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSpoed;
        private System.Windows.Forms.RadioButton rbNormaal;
        private System.Windows.Forms.RadioButton rbNietBelangrijk;
        private System.Windows.Forms.TextBox tbMedewerker1;
        private System.Windows.Forms.Label lblMedewerkers;
        private System.Windows.Forms.TextBox tbTreinNummerSchoonmaak;
        private System.Windows.Forms.Label lblTramNummer;
        private System.Windows.Forms.Label lblBeschrijving;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.Button btnTakenToevoegenReparatie;
        private System.Windows.Forms.DateTimePicker dtpBeginR;
        private System.Windows.Forms.Label lblDatumBegin;
        private System.Windows.Forms.Button btnReparatieLijstOpvragen;
        private System.Windows.Forms.DateTimePicker dtpEindR;
        private System.Windows.Forms.Button btnAftekenenReparatie;
        private System.Windows.Forms.Label lblDatumEind;
        private System.Windows.Forms.TextBox tbMedewerker2;
        private System.Windows.Forms.TextBox tbMedewerker3;
        private System.Windows.Forms.TextBox tbMedewerker4;
        private System.Windows.Forms.TextBox tbMedewerker5;
        private System.Windows.Forms.GroupBox gbTaak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbGroot;
        private System.Windows.Forms.RadioButton rbKlein;
    }
}