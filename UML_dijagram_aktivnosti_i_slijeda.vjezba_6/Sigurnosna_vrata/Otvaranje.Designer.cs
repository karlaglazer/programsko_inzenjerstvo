namespace Sigurnosna_vrata
{
    partial class Otvaranje
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
            this.txtBrojKartice = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btn501 = new System.Windows.Forms.Button();
            this.btn502 = new System.Windows.Forms.Button();
            this.btn503 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj kartice: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN:";
            // 
            // txtBrojKartice
            // 
            this.txtBrojKartice.Location = new System.Drawing.Point(156, 56);
            this.txtBrojKartice.Name = "txtBrojKartice";
            this.txtBrojKartice.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKartice.TabIndex = 2;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(156, 119);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(100, 20);
            this.txtPIN.TabIndex = 3;
            // 
            // btn501
            // 
            this.btn501.Location = new System.Drawing.Point(32, 199);
            this.btn501.Name = "btn501";
            this.btn501.Size = new System.Drawing.Size(75, 38);
            this.btn501.TabIndex = 4;
            this.btn501.Text = "Otvori vrata br: 501";
            this.btn501.UseVisualStyleBackColor = true;
            this.btn501.Click += new System.EventHandler(this.btn501_Click);
            // 
            // btn502
            // 
            this.btn502.Location = new System.Drawing.Point(129, 199);
            this.btn502.Name = "btn502";
            this.btn502.Size = new System.Drawing.Size(75, 38);
            this.btn502.TabIndex = 5;
            this.btn502.Text = "Otvori vrata br: 502";
            this.btn502.UseVisualStyleBackColor = true;
            this.btn502.Click += new System.EventHandler(this.btn502_Click);
            // 
            // btn503
            // 
            this.btn503.Location = new System.Drawing.Point(227, 199);
            this.btn503.Name = "btn503";
            this.btn503.Size = new System.Drawing.Size(75, 38);
            this.btn503.TabIndex = 6;
            this.btn503.Text = "Otvori vrata br: 503";
            this.btn503.UseVisualStyleBackColor = true;
            this.btn503.Click += new System.EventHandler(this.btn503_Click);
            // 
            // Otvaranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 282);
            this.Controls.Add(this.btn503);
            this.Controls.Add(this.btn502);
            this.Controls.Add(this.btn501);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtBrojKartice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Otvaranje";
            this.Text = "Otvaranje vrata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojKartice;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btn501;
        private System.Windows.Forms.Button btn502;
        private System.Windows.Forms.Button btn503;
    }
}

