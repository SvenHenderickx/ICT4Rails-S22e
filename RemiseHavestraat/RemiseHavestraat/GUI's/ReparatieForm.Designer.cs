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
            this.btnTakenToevoegenReparatie = new System.Windows.Forms.Button();
            this.btnAftekenenReparatie = new System.Windows.Forms.Button();
            this.btnReparatieLijstOpvragen = new System.Windows.Forms.Button();
            this.lbReparatie = new System.Windows.Forms.ListBox();
            this.gbTaak = new System.Windows.Forms.GroupBox();
            this.tbMedewerker5 = new System.Windows.Forms.TextBox();
            this.tbMedewerker4 = new System.Windows.Forms.TextBox();
            this.tbMedewerker3 = new System.Windows.Forms.TextBox();
            this.tbMedewerker2 = new System.Windows.Forms.TextBox();
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
            this.tbMedewerker1 = new System.Windows.Forms.TextBox();
            this.lblPrioriteit3 = new System.Windows.Forms.Label();
            this.lblPrioriteit2 = new System.Windows.Forms.Label();
            this.lblPrioriteit1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTaak.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTakenToevoegenReparatie
            // 
            this.btnTakenToevoegenReparatie.Location = new System.Drawing.Point(141, 277);
            this.btnTakenToevoegenReparatie.Name = "btnTakenToevoegenReparatie";
            this.btnTakenToevoegenReparatie.Size = new System.Drawing.Size(122, 35);
            this.btnTakenToevoegenReparatie.TabIndex = 9;
            this.btnTakenToevoegenReparatie.Text = "Taken toevoegen";
            this.btnTakenToevoegenReparatie.UseVisualStyleBackColor = true;
            this.btnTakenToevoegenReparatie.Click += new System.EventHandler(this.btnTakenToevoegenReparatie_Click);
            // 
            // btnAftekenenReparatie
            // 
            this.btnAftekenenReparatie.Location = new System.Drawing.Point(141, 233);
            this.btnAftekenenReparatie.Name = "btnAftekenenReparatie";
            this.btnAftekenenReparatie.Size = new System.Drawing.Size(122, 35);
            this.btnAftekenenReparatie.TabIndex = 7;
            this.btnAftekenenReparatie.Text = "Aftekenen";
            this.btnAftekenenReparatie.UseVisualStyleBackColor = true;
            this.btnAftekenenReparatie.Click += new System.EventHandler(this.btnAftekenenReparatie_Click);
            // 
            // btnReparatieLijstOpvragen
            // 
            this.btnReparatieLijstOpvragen.Location = new System.Drawing.Point(141, 187);
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
            this.gbTaak.Controls.Add(this.label5);
            this.gbTaak.Controls.Add(this.label6);
            this.gbTaak.Controls.Add(this.lblPrioriteit3);
            this.gbTaak.Controls.Add(this.lblPrioriteit2);
            this.gbTaak.Controls.Add(this.lblPrioriteit1);
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
            this.gbTaak.Controls.Add(this.tbMedewerker1);
            this.gbTaak.Location = new System.Drawing.Point(332, 12);
            this.gbTaak.Name = "gbTaak";
            this.gbTaak.Size = new System.Drawing.Size(272, 320);
            this.gbTaak.TabIndex = 20;
            this.gbTaak.TabStop = false;
            this.gbTaak.Text = "Reparatie";
            // 
            // tbMedewerker5
            // 
            this.tbMedewerker5.Location = new System.Drawing.Point(9, 292);
            this.tbMedewerker5.Name = "tbMedewerker5";
            this.tbMedewerker5.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker5.TabIndex = 31;
            // 
            // tbMedewerker4
            // 
            this.tbMedewerker4.Location = new System.Drawing.Point(9, 266);
            this.tbMedewerker4.Name = "tbMedewerker4";
            this.tbMedewerker4.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker4.TabIndex = 30;
            // 
            // tbMedewerker3
            // 
            this.tbMedewerker3.Location = new System.Drawing.Point(9, 240);
            this.tbMedewerker3.Name = "tbMedewerker3";
            this.tbMedewerker3.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker3.TabIndex = 29;
            // 
            // tbMedewerker2
            // 
            this.tbMedewerker2.Location = new System.Drawing.Point(9, 214);
            this.tbMedewerker2.Name = "tbMedewerker2";
            this.tbMedewerker2.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker2.TabIndex = 28;
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
            // dtpEindR
            // 
            this.dtpEindR.Location = new System.Drawing.Point(139, 80);
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
            this.lblType.Location = new System.Drawing.Point(138, 105);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Type:";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(139, 121);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(33, 20);
            this.tbType.TabIndex = 22;
            // 
            // lblPrioriteit
            // 
            this.lblPrioriteit.AutoSize = true;
            this.lblPrioriteit.Location = new System.Drawing.Point(10, 105);
            this.lblPrioriteit.Name = "lblPrioriteit";
            this.lblPrioriteit.Size = new System.Drawing.Size(47, 13);
            this.lblPrioriteit.TabIndex = 21;
            this.lblPrioriteit.Text = "Prioriteit:";
            // 
            // tbPrioriteit
            // 
            this.tbPrioriteit.Location = new System.Drawing.Point(9, 121);
            this.tbPrioriteit.Name = "tbPrioriteit";
            this.tbPrioriteit.Size = new System.Drawing.Size(48, 20);
            this.tbPrioriteit.TabIndex = 20;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(9, 80);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(122, 20);
            this.tbBeschrijving.TabIndex = 19;
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
            this.lblMedewerkers.Location = new System.Drawing.Point(10, 171);
            this.lblMedewerkers.Name = "lblMedewerkers";
            this.lblMedewerkers.Size = new System.Drawing.Size(74, 13);
            this.lblMedewerkers.TabIndex = 14;
            this.lblMedewerkers.Text = "Medewerkers:";
            // 
            // tbMedewerker1
            // 
            this.tbMedewerker1.Location = new System.Drawing.Point(9, 187);
            this.tbMedewerker1.Name = "tbMedewerker1";
            this.tbMedewerker1.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerker1.TabIndex = 15;
            // 
            // lblPrioriteit3
            // 
            this.lblPrioriteit3.AutoSize = true;
            this.lblPrioriteit3.Location = new System.Drawing.Point(63, 143);
            this.lblPrioriteit3.Name = "lblPrioriteit3";
            this.lblPrioriteit3.Size = new System.Drawing.Size(45, 13);
            this.lblPrioriteit3.TabIndex = 37;
            this.lblPrioriteit3.Text = "3: Hoog";
            // 
            // lblPrioriteit2
            // 
            this.lblPrioriteit2.AutoSize = true;
            this.lblPrioriteit2.Location = new System.Drawing.Point(63, 124);
            this.lblPrioriteit2.Name = "lblPrioriteit2";
            this.lblPrioriteit2.Size = new System.Drawing.Size(43, 13);
            this.lblPrioriteit2.TabIndex = 36;
            this.lblPrioriteit2.Text = "2: Laag";
            // 
            // lblPrioriteit1
            // 
            this.lblPrioriteit1.AutoSize = true;
            this.lblPrioriteit1.Location = new System.Drawing.Point(63, 105);
            this.lblPrioriteit1.Name = "lblPrioriteit1";
            this.lblPrioriteit1.Size = new System.Drawing.Size(78, 13);
            this.lblPrioriteit1.TabIndex = 35;
            this.lblPrioriteit1.Text = "1: Onbelangrijk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "2: Groot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "1: Klein";
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
        private System.Windows.Forms.TextBox tbMedewerker1;
        private System.Windows.Forms.TextBox tbMedewerker5;
        private System.Windows.Forms.TextBox tbMedewerker4;
        private System.Windows.Forms.TextBox tbMedewerker3;
        private System.Windows.Forms.TextBox tbMedewerker2;
        private System.Windows.Forms.Label lblPrioriteit3;
        private System.Windows.Forms.Label lblPrioriteit2;
        private System.Windows.Forms.Label lblPrioriteit1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}