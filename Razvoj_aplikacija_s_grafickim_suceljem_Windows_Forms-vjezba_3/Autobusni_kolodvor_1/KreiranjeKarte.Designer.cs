namespace Autobusni_kolodvor1
{
    partial class KreiranjeKarte
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
            this.groupAutobusnaLinija = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPolaziste = new System.Windows.Forms.TextBox();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.txtUdaljenost = new System.Windows.Forms.TextBox();
            this.txtPrijevoznik = new System.Windows.Forms.TextBox();
            this.btnOdaberiLiniju = new System.Windows.Forms.Button();
            this.groupVrsta = new System.Windows.Forms.GroupBox();
            this.rBtnRegularna = new System.Windows.Forms.RadioButton();
            this.rBtnStudentska = new System.Windows.Forms.RadioButton();
            this.groupOstalo = new System.Windows.Forms.GroupBox();
            this.cBoxPovratna = new System.Windows.Forms.CheckBox();
            this.cBoxPrtljaga = new System.Windows.Forms.CheckBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojKarte = new System.Windows.Forms.TextBox();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.groupAutobusnaLinija.SuspendLayout();
            this.groupVrsta.SuspendLayout();
            this.groupOstalo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAutobusnaLinija
            // 
            this.groupAutobusnaLinija.Controls.Add(this.btnOdaberiLiniju);
            this.groupAutobusnaLinija.Controls.Add(this.txtPrijevoznik);
            this.groupAutobusnaLinija.Controls.Add(this.txtUdaljenost);
            this.groupAutobusnaLinija.Controls.Add(this.txtOdrediste);
            this.groupAutobusnaLinija.Controls.Add(this.label3);
            this.groupAutobusnaLinija.Controls.Add(this.txtPolaziste);
            this.groupAutobusnaLinija.Controls.Add(this.label4);
            this.groupAutobusnaLinija.Controls.Add(this.label2);
            this.groupAutobusnaLinija.Controls.Add(this.label1);
            this.groupAutobusnaLinija.Location = new System.Drawing.Point(12, 12);
            this.groupAutobusnaLinija.Name = "groupAutobusnaLinija";
            this.groupAutobusnaLinija.Size = new System.Drawing.Size(339, 154);
            this.groupAutobusnaLinija.TabIndex = 0;
            this.groupAutobusnaLinija.TabStop = false;
            this.groupAutobusnaLinija.Text = "Autobusna linija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Udaljenost (km):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autoprijevoznik: ";
            // 
            // txtPolaziste
            // 
            this.txtPolaziste.Location = new System.Drawing.Point(95, 23);
            this.txtPolaziste.Name = "txtPolaziste";
            this.txtPolaziste.Size = new System.Drawing.Size(107, 20);
            this.txtPolaziste.TabIndex = 4;
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(95, 55);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(107, 20);
            this.txtOdrediste.TabIndex = 5;
            // 
            // txtUdaljenost
            // 
            this.txtUdaljenost.Location = new System.Drawing.Point(95, 86);
            this.txtUdaljenost.Name = "txtUdaljenost";
            this.txtUdaljenost.Size = new System.Drawing.Size(65, 20);
            this.txtUdaljenost.TabIndex = 6;
            // 
            // txtPrijevoznik
            // 
            this.txtPrijevoznik.Location = new System.Drawing.Point(95, 120);
            this.txtPrijevoznik.Name = "txtPrijevoznik";
            this.txtPrijevoznik.Size = new System.Drawing.Size(107, 20);
            this.txtPrijevoznik.TabIndex = 7;
            // 
            // btnOdaberiLiniju
            // 
            this.btnOdaberiLiniju.Location = new System.Drawing.Point(218, 23);
            this.btnOdaberiLiniju.Name = "btnOdaberiLiniju";
            this.btnOdaberiLiniju.Size = new System.Drawing.Size(103, 51);
            this.btnOdaberiLiniju.TabIndex = 8;
            this.btnOdaberiLiniju.Text = "Odaberite liniju";
            this.btnOdaberiLiniju.UseVisualStyleBackColor = true;
            this.btnOdaberiLiniju.Click += new System.EventHandler(this.btnOdaberiLiniju_Click);
            // 
            // groupVrsta
            // 
            this.groupVrsta.Controls.Add(this.rBtnStudentska);
            this.groupVrsta.Controls.Add(this.rBtnRegularna);
            this.groupVrsta.Location = new System.Drawing.Point(12, 172);
            this.groupVrsta.Name = "groupVrsta";
            this.groupVrsta.Size = new System.Drawing.Size(273, 73);
            this.groupVrsta.TabIndex = 1;
            this.groupVrsta.TabStop = false;
            this.groupVrsta.Text = "Vrsta karte";
            // 
            // rBtnRegularna
            // 
            this.rBtnRegularna.AutoSize = true;
            this.rBtnRegularna.Location = new System.Drawing.Point(19, 33);
            this.rBtnRegularna.Name = "rBtnRegularna";
            this.rBtnRegularna.Size = new System.Drawing.Size(101, 17);
            this.rBtnRegularna.TabIndex = 0;
            this.rBtnRegularna.TabStop = true;
            this.rBtnRegularna.Text = "Regularna karta";
            this.rBtnRegularna.UseVisualStyleBackColor = true;
            // 
            // rBtnStudentska
            // 
            this.rBtnStudentska.AutoSize = true;
            this.rBtnStudentska.Location = new System.Drawing.Point(128, 34);
            this.rBtnStudentska.Name = "rBtnStudentska";
            this.rBtnStudentska.Size = new System.Drawing.Size(106, 17);
            this.rBtnStudentska.TabIndex = 1;
            this.rBtnStudentska.TabStop = true;
            this.rBtnStudentska.Text = "Studentska karta";
            this.rBtnStudentska.UseVisualStyleBackColor = true;
            // 
            // groupOstalo
            // 
            this.groupOstalo.Controls.Add(this.cBoxPrtljaga);
            this.groupOstalo.Controls.Add(this.cBoxPovratna);
            this.groupOstalo.Location = new System.Drawing.Point(12, 251);
            this.groupOstalo.Name = "groupOstalo";
            this.groupOstalo.Size = new System.Drawing.Size(273, 73);
            this.groupOstalo.TabIndex = 2;
            this.groupOstalo.TabStop = false;
            this.groupOstalo.Text = "Ostale opcije";
            // 
            // cBoxPovratna
            // 
            this.cBoxPovratna.AutoSize = true;
            this.cBoxPovratna.Location = new System.Drawing.Point(18, 28);
            this.cBoxPovratna.Name = "cBoxPovratna";
            this.cBoxPovratna.Size = new System.Drawing.Size(102, 17);
            this.cBoxPovratna.TabIndex = 0;
            this.cBoxPovratna.Text = "Povratna karta?";
            this.cBoxPovratna.UseVisualStyleBackColor = true;
            // 
            // cBoxPrtljaga
            // 
            this.cBoxPrtljaga.AutoSize = true;
            this.cBoxPrtljaga.Location = new System.Drawing.Point(147, 28);
            this.cBoxPrtljaga.Name = "cBoxPrtljaga";
            this.cBoxPrtljaga.Size = new System.Drawing.Size(67, 17);
            this.cBoxPrtljaga.TabIndex = 1;
            this.cBoxPrtljaga.Text = "Prtljaga?";
            this.cBoxPrtljaga.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(12, 330);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(93, 53);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "Kreiraj kartu";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj karte: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cijena karte: ";
            // 
            // txtBrojKarte
            // 
            this.txtBrojKarte.Location = new System.Drawing.Point(71, 408);
            this.txtBrojKarte.Name = "txtBrojKarte";
            this.txtBrojKarte.Size = new System.Drawing.Size(83, 20);
            this.txtBrojKarte.TabIndex = 6;
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(242, 408);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.Size = new System.Drawing.Size(76, 20);
            this.txtCijenaKarte.TabIndex = 7;
            // 
            // KreiranjeKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 474);
            this.Controls.Add(this.txtCijenaKarte);
            this.Controls.Add(this.txtBrojKarte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.groupOstalo);
            this.Controls.Add(this.groupVrsta);
            this.Controls.Add(this.groupAutobusnaLinija);
            this.Name = "KreiranjeKarte";
            this.Text = "Kreiranje karte";
            this.groupAutobusnaLinija.ResumeLayout(false);
            this.groupAutobusnaLinija.PerformLayout();
            this.groupVrsta.ResumeLayout(false);
            this.groupVrsta.PerformLayout();
            this.groupOstalo.ResumeLayout(false);
            this.groupOstalo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAutobusnaLinija;
        private System.Windows.Forms.Button btnOdaberiLiniju;
        private System.Windows.Forms.TextBox txtPrijevoznik;
        private System.Windows.Forms.TextBox txtUdaljenost;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPolaziste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupVrsta;
        private System.Windows.Forms.RadioButton rBtnStudentska;
        private System.Windows.Forms.RadioButton rBtnRegularna;
        private System.Windows.Forms.GroupBox groupOstalo;
        private System.Windows.Forms.CheckBox cBoxPrtljaga;
        private System.Windows.Forms.CheckBox cBoxPovratna;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojKarte;
        private System.Windows.Forms.TextBox txtCijenaKarte;
    }
}

