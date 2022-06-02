namespace Kućna_knjižnica_1
{
    partial class FormPosudiKnjigu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtOsoba = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnUredu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osoba:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(100, 34);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 3;
            // 
            // txtOsoba
            // 
            this.txtOsoba.Location = new System.Drawing.Point(100, 116);
            this.txtOsoba.Name = "txtOsoba";
            this.txtOsoba.Size = new System.Drawing.Size(100, 20);
            this.txtOsoba.TabIndex = 4;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(100, 73);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(100, 20);
            this.txtNaslov.TabIndex = 5;
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(22, 158);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(75, 23);
            this.btnUredu.TabIndex = 6;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(136, 158);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FormPosudiKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 210);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtOsoba);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPosudiKnjigu";
            this.Text = "FormPosudiKnjigu";
            this.Load += new System.EventHandler(this.FormPosudiKnjigu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtOsoba;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.Button btnOdustani;
    }
}