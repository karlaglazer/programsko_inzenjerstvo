namespace Filmovi
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
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Location = new System.Drawing.Point(28, 21);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.Size = new System.Drawing.Size(719, 304);
            this.dgvFilmovi.TabIndex = 0;
            // 
            // FilmoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 348);
            this.Controls.Add(this.dgvFilmovi);
            this.Name = "FilmoviForm";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.FilmoviForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmovi;
    }
}

