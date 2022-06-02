namespace Streaming_servis
{
    partial class FilmoviForm
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
            this.dgvNepogledani = new System.Windows.Forms.DataGridView();
            this.btnPogledaj = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNepogledani)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neodgledani filmovi:";
            // 
            // dgvNepogledani
            // 
            this.dgvNepogledani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNepogledani.Location = new System.Drawing.Point(26, 57);
            this.dgvNepogledani.Name = "dgvNepogledani";
            this.dgvNepogledani.Size = new System.Drawing.Size(426, 274);
            this.dgvNepogledani.TabIndex = 1;
            // 
            // btnPogledaj
            // 
            this.btnPogledaj.Location = new System.Drawing.Point(196, 362);
            this.btnPogledaj.Name = "btnPogledaj";
            this.btnPogledaj.Size = new System.Drawing.Size(111, 36);
            this.btnPogledaj.TabIndex = 2;
            this.btnPogledaj.Text = "Pogledaj film";
            this.btnPogledaj.UseVisualStyleBackColor = true;
            this.btnPogledaj.Click += new System.EventHandler(this.btnPogledaj_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(339, 362);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(113, 36);
            this.btnOsvjezi.TabIndex = 3;
            this.btnOsvjezi.Text = "Osvježi prikaz";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // FilmoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 428);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnPogledaj);
            this.Controls.Add(this.dgvNepogledani);
            this.Controls.Add(this.label1);
            this.Name = "FilmoviForm";
            this.Text = "Filmovi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNepogledani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNepogledani;
        private System.Windows.Forms.Button btnPogledaj;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}

