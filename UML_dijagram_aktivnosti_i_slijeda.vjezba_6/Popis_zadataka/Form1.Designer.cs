namespace Popis_zadataka
{
    partial class Form1
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
            this.dgvPopisZadataka = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnStvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZadataka)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisZadataka
            // 
            this.dgvPopisZadataka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZadataka.Location = new System.Drawing.Point(28, 24);
            this.dgvPopisZadataka.Name = "dgvPopisZadataka";
            this.dgvPopisZadataka.Size = new System.Drawing.Size(380, 303);
            this.dgvPopisZadataka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(92, 384);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(92, 343);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // btnStvori
            // 
            this.btnStvori.Location = new System.Drawing.Point(267, 439);
            this.btnStvori.Name = "btnStvori";
            this.btnStvori.Size = new System.Drawing.Size(141, 23);
            this.btnStvori.TabIndex = 5;
            this.btnStvori.Text = "Stvori novi zadatak";
            this.btnStvori.UseVisualStyleBackColor = true;
            this.btnStvori.Click += new System.EventHandler(this.btnStvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 471);
            this.Controls.Add(this.btnStvori);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisZadataka);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZadataka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisZadataka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnStvori;
    }
}

