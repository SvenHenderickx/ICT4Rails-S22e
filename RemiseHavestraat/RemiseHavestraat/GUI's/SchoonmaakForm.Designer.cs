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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMedewerker = new System.Windows.Forms.ComboBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnSchoonmaakLijstOpvragen = new System.Windows.Forms.Button();
            this.btnTijdsindicatie = new System.Windows.Forms.Button();
            this.lblDatumEind = new System.Windows.Forms.Label();
            this.btnAftekenen = new System.Windows.Forms.Button();
            this.dtpEindR = new System.Windows.Forms.DateTimePicker();
            this.lbMedewerkers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSchoonmaak
            // 
            this.lbSchoonmaak.FormattingEnabled = true;
            this.lbSchoonmaak.ItemHeight = 20;
            this.lbSchoonmaak.Location = new System.Drawing.Point(13, 78);
            this.lbSchoonmaak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSchoonmaak.Name = "lbSchoonmaak";
            this.lbSchoonmaak.Size = new System.Drawing.Size(729, 464);
            this.lbSchoonmaak.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1383, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Medewerker";
            // 
            // cbMedewerker
            // 
            this.cbMedewerker.FormattingEnabled = true;
            this.cbMedewerker.Location = new System.Drawing.Point(1197, 78);
            this.cbMedewerker.Name = "cbMedewerker";
            this.cbMedewerker.Size = new System.Drawing.Size(180, 28);
            this.cbMedewerker.TabIndex = 44;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(1007, 78);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(183, 54);
            this.btnVoegToe.TabIndex = 43;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            // 
            // btnSchoonmaakLijstOpvragen
            // 
            this.btnSchoonmaakLijstOpvragen.Location = new System.Drawing.Point(1007, 248);
            this.btnSchoonmaakLijstOpvragen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSchoonmaakLijstOpvragen.Name = "btnSchoonmaakLijstOpvragen";
            this.btnSchoonmaakLijstOpvragen.Size = new System.Drawing.Size(183, 54);
            this.btnSchoonmaakLijstOpvragen.TabIndex = 6;
            this.btnSchoonmaakLijstOpvragen.Text = "Schoonmaaklijst opvragen";
            this.btnSchoonmaakLijstOpvragen.UseVisualStyleBackColor = true;
            this.btnSchoonmaakLijstOpvragen.Click += new System.EventHandler(this.btnSchoonmaakLijstOpvragen_Click);
            // 
            // btnTijdsindicatie
            // 
            this.btnTijdsindicatie.Location = new System.Drawing.Point(1007, 153);
            this.btnTijdsindicatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTijdsindicatie.Name = "btnTijdsindicatie";
            this.btnTijdsindicatie.Size = new System.Drawing.Size(183, 54);
            this.btnTijdsindicatie.TabIndex = 42;
            this.btnTijdsindicatie.Text = "Tijdsindicatie geven";
            this.btnTijdsindicatie.UseVisualStyleBackColor = true;
            // 
            // lblDatumEind
            // 
            this.lblDatumEind.AutoSize = true;
            this.lblDatumEind.Location = new System.Drawing.Point(1392, 165);
            this.lblDatumEind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumEind.Name = "lblDatumEind";
            this.lblDatumEind.Size = new System.Drawing.Size(99, 20);
            this.lblDatumEind.TabIndex = 27;
            this.lblDatumEind.Text = "Tijdsindicatie";
            // 
            // btnAftekenen
            // 
            this.btnAftekenen.Location = new System.Drawing.Point(1007, 332);
            this.btnAftekenen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAftekenen.Name = "btnAftekenen";
            this.btnAftekenen.Size = new System.Drawing.Size(183, 54);
            this.btnAftekenen.TabIndex = 7;
            this.btnAftekenen.Text = "Aftekenen";
            this.btnAftekenen.UseVisualStyleBackColor = true;
            this.btnAftekenen.Click += new System.EventHandler(this.btnAftekenen_Click);
            // 
            // dtpEindR
            // 
            this.dtpEindR.Location = new System.Drawing.Point(1198, 165);
            this.dtpEindR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEindR.Name = "dtpEindR";
            this.dtpEindR.Size = new System.Drawing.Size(180, 26);
            this.dtpEindR.TabIndex = 26;
            // 
            // lbMedewerkers
            // 
            this.lbMedewerkers.FormattingEnabled = true;
            this.lbMedewerkers.ItemHeight = 20;
            this.lbMedewerkers.Location = new System.Drawing.Point(779, 78);
            this.lbMedewerkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMedewerkers.Name = "lbMedewerkers";
            this.lbMedewerkers.Size = new System.Drawing.Size(220, 464);
            this.lbMedewerkers.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Schoonmaken";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Medewerkers";
            // 
            // SchoonmaakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSchoonmaakLijstOpvragen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEindR);
            this.Controls.Add(this.lbSchoonmaak);
            this.Controls.Add(this.cbMedewerker);
            this.Controls.Add(this.lbMedewerkers);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.btnTijdsindicatie);
            this.Controls.Add(this.lblDatumEind);
            this.Controls.Add(this.btnAftekenen);
            this.Name = "SchoonmaakForm";
            this.Text = "SchoonmaakForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSchoonmaak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedewerker;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnSchoonmaakLijstOpvragen;
        private System.Windows.Forms.Button btnTijdsindicatie;
        private System.Windows.Forms.Label lblDatumEind;
        private System.Windows.Forms.Button btnAftekenen;
        private System.Windows.Forms.DateTimePicker dtpEindR;
        private System.Windows.Forms.ListBox lbMedewerkers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}