namespace Rezervacija_sobe
{
    partial class RezervacijskaForma
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
            this.dtpDatumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSlobodneSobe = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum rezervacije:";
            // 
            // dtpDatumRezervacije
            // 
            this.dtpDatumRezervacije.Location = new System.Drawing.Point(25, 59);
            this.dtpDatumRezervacije.Name = "dtpDatumRezervacije";
            this.dtpDatumRezervacije.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRezervacije.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(258, 59);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(163, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi slobodne sobe";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slobodne sobe:";
            // 
            // dgvSlobodneSobe
            // 
            this.dgvSlobodneSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlobodneSobe.Location = new System.Drawing.Point(23, 140);
            this.dgvSlobodneSobe.Name = "dgvSlobodneSobe";
            this.dgvSlobodneSobe.Size = new System.Drawing.Size(407, 256);
            this.dgvSlobodneSobe.TabIndex = 4;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(295, 413);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(134, 24);
            this.btnRezerviraj.TabIndex = 5;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // RezervacijskaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 446);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.dgvSlobodneSobe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dtpDatumRezervacije);
            this.Controls.Add(this.label1);
            this.Name = "RezervacijskaForma";
            this.Text = "Rezervacija sobe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumRezervacije;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSlobodneSobe;
        private System.Windows.Forms.Button btnRezerviraj;
    }
}

