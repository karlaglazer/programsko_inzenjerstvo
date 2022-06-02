namespace Kucna_knjiznica_2
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
            this.dataGridSve = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnSve = new System.Windows.Forms.RadioButton();
            this.radioBtnTrenutne = new System.Windows.Forms.RadioButton();
            this.radioBtnProsle = new System.Windows.Forms.RadioButton();
            this.btnVrati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSve)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSve
            // 
            this.dataGridSve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSve.Location = new System.Drawing.Point(12, 37);
            this.dataGridSve.Name = "dataGridSve";
            this.dataGridSve.Size = new System.Drawing.Size(669, 150);
            this.dataGridSve.TabIndex = 0;
            this.dataGridSve.SelectionChanged += new System.EventHandler(this.dataGridSve_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaži: ";
            // 
            // radioBtnSve
            // 
            this.radioBtnSve.AutoSize = true;
            this.radioBtnSve.Location = new System.Drawing.Point(62, 19);
            this.radioBtnSve.Name = "radioBtnSve";
            this.radioBtnSve.Size = new System.Drawing.Size(88, 17);
            this.radioBtnSve.TabIndex = 2;
            this.radioBtnSve.TabStop = true;
            this.radioBtnSve.Text = "Sve posudbe";
            this.radioBtnSve.UseVisualStyleBackColor = true;
            this.radioBtnSve.Click += new System.EventHandler(this.radioBtnSve_Click);
            // 
            // radioBtnTrenutne
            // 
            this.radioBtnTrenutne.AutoSize = true;
            this.radioBtnTrenutne.Location = new System.Drawing.Point(153, 19);
            this.radioBtnTrenutne.Name = "radioBtnTrenutne";
            this.radioBtnTrenutne.Size = new System.Drawing.Size(112, 17);
            this.radioBtnTrenutne.TabIndex = 3;
            this.radioBtnTrenutne.TabStop = true;
            this.radioBtnTrenutne.Text = "Trenutne posudbe";
            this.radioBtnTrenutne.UseVisualStyleBackColor = true;
            this.radioBtnTrenutne.Click += new System.EventHandler(this.radioBtnTrenutne_Click);
            // 
            // radioBtnProsle
            // 
            this.radioBtnProsle.AutoSize = true;
            this.radioBtnProsle.Location = new System.Drawing.Point(271, 19);
            this.radioBtnProsle.Name = "radioBtnProsle";
            this.radioBtnProsle.Size = new System.Drawing.Size(98, 17);
            this.radioBtnProsle.TabIndex = 4;
            this.radioBtnProsle.TabStop = true;
            this.radioBtnProsle.Text = "Prošle posudbe";
            this.radioBtnProsle.UseVisualStyleBackColor = true;
            this.radioBtnProsle.Click += new System.EventHandler(this.radioBtnProsle_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(606, 192);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(75, 23);
            this.btnVrati.TabIndex = 5;
            this.btnVrati.Text = "Vrati knjigu";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 227);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.radioBtnProsle);
            this.Controls.Add(this.radioBtnTrenutne);
            this.Controls.Add(this.radioBtnSve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnSve;
        private System.Windows.Forms.RadioButton radioBtnTrenutne;
        private System.Windows.Forms.RadioButton radioBtnProsle;
        private System.Windows.Forms.Button btnVrati;
    }
}

