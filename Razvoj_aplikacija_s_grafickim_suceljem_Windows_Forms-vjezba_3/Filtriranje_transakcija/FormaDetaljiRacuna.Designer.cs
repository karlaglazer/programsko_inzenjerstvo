namespace Filtriranje_transakcija
{
    partial class FormaDetaljiRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.txtVlasnik = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni promet:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(97, 51);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(100, 20);
            this.txtIBAN.TabIndex = 4;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(97, 159);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 5;
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(97, 133);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(100, 20);
            this.txtStanje.TabIndex = 6;
            // 
            // txtVlasnik
            // 
            this.txtVlasnik.Location = new System.Drawing.Point(97, 77);
            this.txtVlasnik.Name = "txtVlasnik";
            this.txtVlasnik.Size = new System.Drawing.Size(100, 20);
            this.txtVlasnik.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(140, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormaDetaljiRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 258);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtVlasnik);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaDetaljiRacuna";
            this.Text = "Detalji racuna";
            this.Load += new System.EventHandler(this.FormaDetaljiRacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.TextBox txtVlasnik;
        private System.Windows.Forms.Button btnClose;
    }
}