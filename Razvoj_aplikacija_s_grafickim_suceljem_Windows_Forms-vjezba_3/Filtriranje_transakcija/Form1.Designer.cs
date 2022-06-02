namespace Filtriranje_transakcija
{
    partial class FormPopisTransakcija
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
            this.radioBtnSve = new System.Windows.Forms.RadioButton();
            this.radioBtnIsplate = new System.Windows.Forms.RadioButton();
            this.radioBtnUplate = new System.Windows.Forms.RadioButton();
            this.comboBRacun = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.dataGridTransakcije = new System.Windows.Forms.DataGridView();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBRacun);
            this.groupBox1.Controls.Add(this.radioBtnUplate);
            this.groupBox1.Controls.Add(this.radioBtnIsplate);
            this.groupBox1.Controls.Add(this.radioBtnSve);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip transakcije: ";
            // 
            // radioBtnSve
            // 
            this.radioBtnSve.AutoSize = true;
            this.radioBtnSve.Location = new System.Drawing.Point(106, 100);
            this.radioBtnSve.Name = "radioBtnSve";
            this.radioBtnSve.Size = new System.Drawing.Size(44, 17);
            this.radioBtnSve.TabIndex = 2;
            this.radioBtnSve.TabStop = true;
            this.radioBtnSve.Text = "Sve";
            this.radioBtnSve.UseVisualStyleBackColor = true;
            // 
            // radioBtnIsplate
            // 
            this.radioBtnIsplate.AutoSize = true;
            this.radioBtnIsplate.Location = new System.Drawing.Point(156, 100);
            this.radioBtnIsplate.Name = "radioBtnIsplate";
            this.radioBtnIsplate.Size = new System.Drawing.Size(56, 17);
            this.radioBtnIsplate.TabIndex = 3;
            this.radioBtnIsplate.TabStop = true;
            this.radioBtnIsplate.Text = "Isplate";
            this.radioBtnIsplate.UseVisualStyleBackColor = true;
            // 
            // radioBtnUplate
            // 
            this.radioBtnUplate.AutoSize = true;
            this.radioBtnUplate.Location = new System.Drawing.Point(218, 100);
            this.radioBtnUplate.Name = "radioBtnUplate";
            this.radioBtnUplate.Size = new System.Drawing.Size(56, 17);
            this.radioBtnUplate.TabIndex = 4;
            this.radioBtnUplate.TabStop = true;
            this.radioBtnUplate.Text = "Uplate";
            this.radioBtnUplate.UseVisualStyleBackColor = true;
            // 
            // comboBRacun
            // 
            this.comboBRacun.FormattingEnabled = true;
            this.comboBRacun.Location = new System.Drawing.Point(106, 42);
            this.comboBRacun.Name = "comboBRacun";
            this.comboBRacun.Size = new System.Drawing.Size(134, 21);
            this.comboBRacun.TabIndex = 5;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(317, 50);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(95, 65);
            this.btnFiltriraj.TabIndex = 1;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(418, 50);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(91, 65);
            this.btnOcisti.TabIndex = 2;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // dataGridTransakcije
            // 
            this.dataGridTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransakcije.Location = new System.Drawing.Point(20, 175);
            this.dataGridTransakcije.Name = "dataGridTransakcije";
            this.dataGridTransakcije.Size = new System.Drawing.Size(489, 150);
            this.dataGridTransakcije.TabIndex = 3;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(414, 331);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(95, 43);
            this.btnDetalji.TabIndex = 4;
            this.btnDetalji.Text = "Detalji računa";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // FormPopisTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 378);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dataGridTransakcije);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPopisTransakcija";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.FormPopisTransakcija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransakcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBRacun;
        private System.Windows.Forms.RadioButton radioBtnUplate;
        private System.Windows.Forms.RadioButton radioBtnIsplate;
        private System.Windows.Forms.RadioButton radioBtnSve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.DataGridView dataGridTransakcije;
        private System.Windows.Forms.Button btnDetalji;
    }
}

