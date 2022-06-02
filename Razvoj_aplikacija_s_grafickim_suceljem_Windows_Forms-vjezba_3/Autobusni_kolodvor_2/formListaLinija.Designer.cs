namespace Autobusni_kolodvor_2
{
    partial class formListaLinija
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
            this.dataGridPopis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPopis
            // 
            this.dataGridPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPopis.Location = new System.Drawing.Point(12, 48);
            this.dataGridPopis.Name = "dataGridPopis";
            this.dataGridPopis.Size = new System.Drawing.Size(564, 150);
            this.dataGridPopis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odredište: ";
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(86, 17);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(168, 20);
            this.txtOdrediste.TabIndex = 2;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(260, 17);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(88, 20);
            this.btnPronadji.TabIndex = 3;
            this.btnPronadji.Text = "Pronađi";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(488, 203);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(88, 20);
            this.btnKupi.TabIndex = 4;
            this.btnKupi.Text = "Kupi kartu";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // formListaLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 235);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtOdrediste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPopis);
            this.Name = "formListaLinija";
            this.Text = "Autobusne linije";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPopis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPopis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Button btnKupi;
    }
}

