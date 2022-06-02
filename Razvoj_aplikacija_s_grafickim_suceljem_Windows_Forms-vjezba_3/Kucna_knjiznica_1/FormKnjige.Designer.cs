namespace Kućna_knjižnica_1
{
    partial class FormKnjige
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
            this.dataGridDostupne = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPosudjene = new System.Windows.Forms.DataGridView();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDostupne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPosudjene)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDostupne
            // 
            this.dataGridDostupne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDostupne.Location = new System.Drawing.Point(12, 41);
            this.dataGridDostupne.Name = "dataGridDostupne";
            this.dataGridDostupne.Size = new System.Drawing.Size(287, 150);
            this.dataGridDostupne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dostupne knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Knjige na posudbi:";
            // 
            // dataGridPosudjene
            // 
            this.dataGridPosudjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPosudjene.Location = new System.Drawing.Point(12, 260);
            this.dataGridPosudjene.Name = "dataGridPosudjene";
            this.dataGridPosudjene.Size = new System.Drawing.Size(287, 150);
            this.dataGridPosudjene.TabIndex = 3;
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(224, 197);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(75, 23);
            this.btnPosudi.TabIndex = 4;
            this.btnPosudi.Text = "Posudi knjigu";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(224, 416);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(75, 23);
            this.btnVrati.TabIndex = 5;
            this.btnVrati.Text = "Vrati knjigu";
            this.btnVrati.UseVisualStyleBackColor = true;
            // 
            // FormKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 448);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.dataGridPosudjene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDostupne);
            this.Name = "FormKnjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.FormKnjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDostupne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPosudjene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDostupne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPosudjene;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnVrati;
    }
}

