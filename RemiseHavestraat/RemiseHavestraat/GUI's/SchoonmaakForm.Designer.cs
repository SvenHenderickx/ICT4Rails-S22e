namespace RemiseHavestraat.GUI_s
{
    partial class SchoonmaakForm
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
            this.lbSchoonmaak = new System.Windows.Forms.ListBox();
            this.btnSchoonmaakLijstOpvragen = new System.Windows.Forms.Button();
            this.btnAftekenen = new System.Windows.Forms.Button();
            this.btnTakenToevoegen = new System.Windows.Forms.Button();
            this.lblTramNummerSchoonmaak = new System.Windows.Forms.Label();
            this.tbTreinNummerSchoonmaak = new System.Windows.Forms.TextBox();
            this.lblMedewerkersS = new System.Windows.Forms.Label();
            this.tbMedewerkerS = new System.Windows.Forms.TextBox();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.gbTaak = new System.Windows.Forms.GroupBox();
            this.lblDatumEind = new System.Windows.Forms.Label();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.lblDatumBegin = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblPrioriteit = new System.Windows.Forms.Label();
            this.tbPrioriteitS = new System.Windows.Forms.TextBox();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.gbTaak.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSchoonmaak
            // 
            this.lbSchoonmaak.FormattingEnabled = true;
            this.lbSchoonmaak.Location = new System.Drawing.Point(12, 16);
            this.lbSchoonmaak.Name = "lbSchoonmaak";
            this.lbSchoonmaak.Size = new System.Drawing.Size(313, 316);
            this.lbSchoonmaak.TabIndex = 0;
            // 
            // btnSchoonmaakLijstOpvragen
            // 
            this.btnSchoonmaakLijstOpvragen.Location = new System.Drawing.Point(141, 245);
            this.btnSchoonmaakLijstOpvragen.Name = "btnSchoonmaakLijstOpvragen";
            this.btnSchoonmaakLijstOpvragen.Size = new System.Drawing.Size(122, 35);
            this.btnSchoonmaakLijstOpvragen.TabIndex = 1;
            this.btnSchoonmaakLijstOpvragen.Text = "Schoonmaaklijst opvragen";
            this.btnSchoonmaakLijstOpvragen.UseVisualStyleBackColor = true;
            this.btnSchoonmaakLijstOpvragen.Click += new System.EventHandler(this.btnSchoonmaakLijstOpvragen_Click);
            // 
            // btnAftekenen
            // 
            this.btnAftekenen.Location = new System.Drawing.Point(141, 287);
            this.btnAftekenen.Name = "btnAftekenen";
            this.btnAftekenen.Size = new System.Drawing.Size(122, 35);
            this.btnAftekenen.TabIndex = 2;
            this.btnAftekenen.Text = "Aftekenen";
            this.btnAftekenen.UseVisualStyleBackColor = true;
            this.btnAftekenen.Click += new System.EventHandler(this.btnAftekenen_Click);
            // 
            // btnTakenToevoegen
            // 
            this.btnTakenToevoegen.Location = new System.Drawing.Point(6, 287);
            this.btnTakenToevoegen.Name = "btnTakenToevoegen";
            this.btnTakenToevoegen.Size = new System.Drawing.Size(122, 35);
            this.btnTakenToevoegen.TabIndex = 4;
            this.btnTakenToevoegen.Text = "Taak toevoegen";
            this.btnTakenToevoegen.UseVisualStyleBackColor = true;
            this.btnTakenToevoegen.Click += new System.EventHandler(this.btnTakenToevoegen_Click);
            // 
            // lblTramNummerSchoonmaak
            // 
            this.lblTramNummerSchoonmaak.AutoSize = true;
            this.lblTramNummerSchoonmaak.Location = new System.Drawing.Point(6, 23);
            this.lblTramNummerSchoonmaak.Name = "lblTramNummerSchoonmaak";
            this.lblTramNummerSchoonmaak.Size = new System.Drawing.Size(71, 13);
            this.lblTramNummerSchoonmaak.TabIndex = 13;
            this.lblTramNummerSchoonmaak.Tag = "";
            this.lblTramNummerSchoonmaak.Text = "Tramnummer:";
            // 
            // tbTreinNummerSchoonmaak
            // 
            this.tbTreinNummerSchoonmaak.Location = new System.Drawing.Point(9, 39);
            this.tbTreinNummerSchoonmaak.Name = "tbTreinNummerSchoonmaak";
            this.tbTreinNummerSchoonmaak.Size = new System.Drawing.Size(122, 20);
            this.tbTreinNummerSchoonmaak.TabIndex = 12;
            // 
            // lblMedewerkersS
            // 
            this.lblMedewerkersS.AutoSize = true;
            this.lblMedewerkersS.Location = new System.Drawing.Point(6, 77);
            this.lblMedewerkersS.Name = "lblMedewerkersS";
            this.lblMedewerkersS.Size = new System.Drawing.Size(69, 13);
            this.lblMedewerkersS.TabIndex = 14;
            this.lblMedewerkersS.Text = "Medewerker:";
            // 
            // tbMedewerkerS
            // 
            this.tbMedewerkerS.Location = new System.Drawing.Point(9, 93);
            this.tbMedewerkerS.Name = "tbMedewerkerS";
            this.tbMedewerkerS.Size = new System.Drawing.Size(122, 20);
            this.tbMedewerkerS.TabIndex = 15;
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
            // gbTaak
            // 
            this.gbTaak.Controls.Add(this.lblDatumEind);
            this.gbTaak.Controls.Add(this.btnAftekenen);
            this.gbTaak.Controls.Add(this.dtpEind);
            this.gbTaak.Controls.Add(this.btnSchoonmaakLijstOpvragen);
            this.gbTaak.Controls.Add(this.lblDatumBegin);
            this.gbTaak.Controls.Add(this.dtpBegin);
            this.gbTaak.Controls.Add(this.lblType);
            this.gbTaak.Controls.Add(this.tbType);
            this.gbTaak.Controls.Add(this.lblPrioriteit);
            this.gbTaak.Controls.Add(this.tbPrioriteitS);
            this.gbTaak.Controls.Add(this.tbBeschrijving);
            this.gbTaak.Controls.Add(this.btnTakenToevoegen);
            this.gbTaak.Controls.Add(this.lblBeschrijving);
            this.gbTaak.Controls.Add(this.lblTramNummerSchoonmaak);
            this.gbTaak.Controls.Add(this.tbTreinNummerSchoonmaak);
            this.gbTaak.Controls.Add(this.lblMedewerkersS);
            this.gbTaak.Controls.Add(this.tbMedewerkerS);
            this.gbTaak.Location = new System.Drawing.Point(332, 12);
            this.gbTaak.Name = "gbTaak";
            this.gbTaak.Size = new System.Drawing.Size(272, 331);
            this.gbTaak.TabIndex = 19;
            this.gbTaak.TabStop = false;
            this.gbTaak.Text = "Schoonmaak";
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
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(139, 91);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(121, 20);
            this.dtpEind.TabIndex = 26;
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
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(139, 39);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(121, 20);
            this.dtpBegin.TabIndex = 24;
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
            // tbPrioriteitS
            // 
            this.tbPrioriteitS.Location = new System.Drawing.Point(9, 245);
            this.tbPrioriteitS.Name = "tbPrioriteitS";
            this.tbPrioriteitS.Size = new System.Drawing.Size(122, 20);
            this.tbPrioriteitS.TabIndex = 20;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(9, 195);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(122, 20);
            this.tbBeschrijving.TabIndex = 19;
            // 
            // SchoonmaakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 346);
            this.Controls.Add(this.gbTaak);
            this.Controls.Add(this.lbSchoonmaak);
            this.Name = "SchoonmaakForm";
            this.Text = "SchoonmaakForm";
            this.gbTaak.ResumeLayout(false);
            this.gbTaak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSchoonmaak;
        private System.Windows.Forms.Button btnSchoonmaakLijstOpvragen;
        private System.Windows.Forms.Button btnAftekenen;
        private System.Windows.Forms.Button btnTakenToevoegen;
        private System.Windows.Forms.Label lblTramNummerSchoonmaak;
        private System.Windows.Forms.TextBox tbTreinNummerSchoonmaak;
        private System.Windows.Forms.Label lblMedewerkersS;
        private System.Windows.Forms.TextBox tbMedewerkerS;
        private System.Windows.Forms.Label lblBeschrijving;
        private System.Windows.Forms.GroupBox gbTaak;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lblPrioriteit;
        private System.Windows.Forms.TextBox tbPrioriteitS;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label lblDatumEind;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.Label lblDatumBegin;
    }
}