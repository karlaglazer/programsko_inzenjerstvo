﻿namespace Autobusni_kolodvor_2
{
    partial class formKupiKartu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBPrtljaga = new System.Windows.Forms.CheckBox();
            this.checkBPovratna = new System.Windows.Forms.CheckBox();
            this.comboBVrsta = new System.Windows.Forms.ComboBox();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBPrtljaga);
            this.groupBox1.Controls.Add(this.checkBPovratna);
            this.groupBox1.Controls.Add(this.comboBVrsta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije karte:";
            // 
            // checkBPrtljaga
            // 
            this.checkBPrtljaga.AutoSize = true;
            this.checkBPrtljaga.Location = new System.Drawing.Point(97, 110);
            this.checkBPrtljaga.Name = "checkBPrtljaga";
            this.checkBPrtljaga.Size = new System.Drawing.Size(67, 17);
            this.checkBPrtljaga.TabIndex = 4;
            this.checkBPrtljaga.Text = "Prtljaga?";
            this.checkBPrtljaga.UseVisualStyleBackColor = true;
            // 
            // checkBPovratna
            // 
            this.checkBPovratna.AutoSize = true;
            this.checkBPovratna.Location = new System.Drawing.Point(97, 87);
            this.checkBPovratna.Name = "checkBPovratna";
            this.checkBPovratna.Size = new System.Drawing.Size(102, 17);
            this.checkBPovratna.TabIndex = 3;
            this.checkBPovratna.Text = "Povratna karta?";
            this.checkBPovratna.UseVisualStyleBackColor = true;
            // 
            // comboBVrsta
            // 
            this.comboBVrsta.DataSource = this.kartaBindingSource;
            this.comboBVrsta.FormattingEnabled = true;
            this.comboBVrsta.Location = new System.Drawing.Point(97, 33);
            this.comboBVrsta.Name = "comboBVrsta";
            this.comboBVrsta.Size = new System.Drawing.Size(121, 21);
            this.comboBVrsta.TabIndex = 2;
            // 
            // kartaBindingSource
            // 
            this.kartaBindingSource.DataSource = typeof(AutobusniKolodvorLib2.Karta);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodatno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta karte:";
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(208, 165);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 1;
            this.btnIspisi.Text = "Ispisi kartu";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIspis);
            this.groupBox2.Location = new System.Drawing.Point(24, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ispis karte:";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(6, 19);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(246, 159);
            this.txtIspis.TabIndex = 0;
            // 
            // formKupiKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.groupBox1);
            this.Name = "formKupiKartu";
            this.Text = "Kupi kartu";
            this.Load += new System.EventHandler(this.formKupiKartu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBPrtljaga;
        private System.Windows.Forms.CheckBox checkBPovratna;
        private System.Windows.Forms.ComboBox comboBVrsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.BindingSource kartaBindingSource;
    }
}