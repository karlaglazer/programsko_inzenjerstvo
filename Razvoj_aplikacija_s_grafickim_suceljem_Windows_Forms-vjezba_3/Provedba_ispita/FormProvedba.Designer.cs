namespace Provedba_ispita
{
    partial class FormProvedba
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
            this.txtPitanje = new System.Windows.Forms.TextBox();
            this.listBMoguciOdgovori = new System.Windows.Forms.ListBox();
            this.txtPotvrdjeni = new System.Windows.Forms.TextBox();
            this.btnSljedece = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mogući odgovori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potvrđeni odgovor:";
            // 
            // txtPitanje
            // 
            this.txtPitanje.Enabled = false;
            this.txtPitanje.Location = new System.Drawing.Point(123, 47);
            this.txtPitanje.Name = "txtPitanje";
            this.txtPitanje.Size = new System.Drawing.Size(364, 20);
            this.txtPitanje.TabIndex = 3;
            // 
            // listBMoguciOdgovori
            // 
            this.listBMoguciOdgovori.FormattingEnabled = true;
            this.listBMoguciOdgovori.Location = new System.Drawing.Point(123, 97);
            this.listBMoguciOdgovori.Name = "listBMoguciOdgovori";
            this.listBMoguciOdgovori.Size = new System.Drawing.Size(222, 95);
            this.listBMoguciOdgovori.TabIndex = 4;
            // 
            // txtPotvrdjeni
            // 
            this.txtPotvrdjeni.Enabled = false;
            this.txtPotvrdjeni.Location = new System.Drawing.Point(123, 235);
            this.txtPotvrdjeni.Name = "txtPotvrdjeni";
            this.txtPotvrdjeni.Size = new System.Drawing.Size(176, 20);
            this.txtPotvrdjeni.TabIndex = 5;
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(372, 97);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(115, 92);
            this.btnSljedece.TabIndex = 6;
            this.btnSljedece.Text = "Sljedeće pitanje ->";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(123, 198);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(144, 23);
            this.btnPotvrdi.TabIndex = 7;
            this.btnPotvrdi.Text = "Potvrdi odgovor";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // FormProvedba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 288);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.txtPotvrdjeni);
            this.Controls.Add(this.listBMoguciOdgovori);
            this.Controls.Add(this.txtPitanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProvedba";
            this.Text = "Provedba ispita";
            this.Load += new System.EventHandler(this.FormProvedba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPitanje;
        private System.Windows.Forms.ListBox listBMoguciOdgovori;
        private System.Windows.Forms.TextBox txtPotvrdjeni;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}

