namespace Računi_i_transakcije
{
    partial class FormTransakcije
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.txtVlasnik = new System.Windows.Forms.TextBox();
            this.dataGridViewRacunTransak = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnSve = new System.Windows.Forms.RadioButton();
            this.radioBtnIsplate = new System.Windows.Forms.RadioButton();
            this.radioBtnUplate = new System.Windows.Forms.RadioButton();
            this.btnPrimjeni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacunTransak)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVlasnik);
            this.groupBox1.Controls.Add(this.txtStanje);
            this.groupBox1.Controls.Add(this.txtIBAN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o računu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stanje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vlasnik:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(58, 30);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(100, 20);
            this.txtIBAN.TabIndex = 3;
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(58, 55);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(100, 20);
            this.txtStanje.TabIndex = 4;
            // 
            // txtVlasnik
            // 
            this.txtVlasnik.Location = new System.Drawing.Point(58, 83);
            this.txtVlasnik.Name = "txtVlasnik";
            this.txtVlasnik.Size = new System.Drawing.Size(100, 20);
            this.txtVlasnik.TabIndex = 5;
            // 
            // dataGridViewRacunTransak
            // 
            this.dataGridViewRacunTransak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacunTransak.Location = new System.Drawing.Point(22, 163);
            this.dataGridViewRacunTransak.Name = "dataGridViewRacunTransak";
            this.dataGridViewRacunTransak.Size = new System.Drawing.Size(399, 150);
            this.dataGridViewRacunTransak.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnUplate);
            this.groupBox2.Controls.Add(this.radioBtnIsplate);
            this.groupBox2.Controls.Add(this.radioBtnSve);
            this.groupBox2.Location = new System.Drawing.Point(22, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter prikaza";
            // 
            // radioBtnSve
            // 
            this.radioBtnSve.AutoSize = true;
            this.radioBtnSve.Location = new System.Drawing.Point(9, 19);
            this.radioBtnSve.Name = "radioBtnSve";
            this.radioBtnSve.Size = new System.Drawing.Size(76, 17);
            this.radioBtnSve.TabIndex = 0;
            this.radioBtnSve.TabStop = true;
            this.radioBtnSve.Text = "Prikaži sve";
            this.radioBtnSve.UseVisualStyleBackColor = true;
            // 
            // radioBtnIsplate
            // 
            this.radioBtnIsplate.AutoSize = true;
            this.radioBtnIsplate.Location = new System.Drawing.Point(104, 19);
            this.radioBtnIsplate.Name = "radioBtnIsplate";
            this.radioBtnIsplate.Size = new System.Drawing.Size(89, 17);
            this.radioBtnIsplate.TabIndex = 1;
            this.radioBtnIsplate.TabStop = true;
            this.radioBtnIsplate.Text = "Prikaži isplate";
            this.radioBtnIsplate.UseVisualStyleBackColor = true;
            // 
            // radioBtnUplate
            // 
            this.radioBtnUplate.AutoSize = true;
            this.radioBtnUplate.Location = new System.Drawing.Point(199, 19);
            this.radioBtnUplate.Name = "radioBtnUplate";
            this.radioBtnUplate.Size = new System.Drawing.Size(88, 17);
            this.radioBtnUplate.TabIndex = 2;
            this.radioBtnUplate.TabStop = true;
            this.radioBtnUplate.Text = "Prikaži uplate";
            this.radioBtnUplate.UseVisualStyleBackColor = true;
            // 
            // btnPrimjeni
            // 
            this.btnPrimjeni.Location = new System.Drawing.Point(346, 341);
            this.btnPrimjeni.Name = "btnPrimjeni";
            this.btnPrimjeni.Size = new System.Drawing.Size(75, 23);
            this.btnPrimjeni.TabIndex = 3;
            this.btnPrimjeni.Text = "Primjeni";
            this.btnPrimjeni.UseVisualStyleBackColor = true;
            this.btnPrimjeni.Click += new System.EventHandler(this.btnPrimjeni_Click);
            // 
            // FormTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 395);
            this.Controls.Add(this.btnPrimjeni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewRacunTransak);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransakcije";
            this.Text = "FormTransakcije";
            this.Load += new System.EventHandler(this.FormTransakcije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacunTransak)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVlasnik;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.DataGridView dataGridViewRacunTransak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnUplate;
        private System.Windows.Forms.RadioButton radioBtnIsplate;
        private System.Windows.Forms.RadioButton radioBtnSve;
        private System.Windows.Forms.Button btnPrimjeni;
    }
}