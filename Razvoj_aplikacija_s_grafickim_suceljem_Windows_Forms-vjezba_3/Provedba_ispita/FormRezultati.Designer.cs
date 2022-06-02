namespace Provedba_ispita
{
    partial class FormRezultati
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
            this.dataGridViewRezultati = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezultati
            // 
            this.dataGridViewRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezultati.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewRezultati.Name = "dataGridViewRezultati";
            this.dataGridViewRezultati.Size = new System.Drawing.Size(574, 163);
            this.dataGridViewRezultati.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(518, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 230);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewRezultati);
            this.Name = "FormRezultati";
            this.Text = "Rezultati ispita";
            this.Load += new System.EventHandler(this.FormRezultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezultati;
        private System.Windows.Forms.Button btnClose;
    }
}