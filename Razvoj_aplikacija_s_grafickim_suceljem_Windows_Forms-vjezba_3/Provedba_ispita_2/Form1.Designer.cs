namespace Provedba_ispita_2
{
    partial class FormIspit
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
            this.btnPrethodno = new System.Windows.Forms.Button();
            this.btnSljedece = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPitanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrethodno
            // 
            this.btnPrethodno.Location = new System.Drawing.Point(12, 42);
            this.btnPrethodno.Name = "btnPrethodno";
            this.btnPrethodno.Size = new System.Drawing.Size(133, 33);
            this.btnPrethodno.TabIndex = 0;
            this.btnPrethodno.Text = "<< Prethodno pitanje";
            this.btnPrethodno.UseVisualStyleBackColor = true;
            this.btnPrethodno.Click += new System.EventHandler(this.btnPrethodno_Click);
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(170, 42);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(133, 33);
            this.btnSljedece.TabIndex = 1;
            this.btnSljedece.Text = "Sljedece pitanje >>";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PITANJE:";
            // 
            // txtPitanje
            // 
            this.txtPitanje.Location = new System.Drawing.Point(12, 103);
            this.txtPitanje.Multiline = true;
            this.txtPitanje.Name = "txtPitanje";
            this.txtPitanje.Size = new System.Drawing.Size(291, 46);
            this.txtPitanje.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ODGOVORI:";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(15, 188);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(288, 40);
            this.btnA.TabIndex = 5;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(15, 234);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(288, 40);
            this.btnB.TabIndex = 6;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(15, 280);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(288, 40);
            this.btnC.TabIndex = 7;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(15, 326);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(288, 40);
            this.btnD.TabIndex = 8;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // FormIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 381);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPitanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.btnPrethodno);
            this.Name = "FormIspit";
            this.Text = "Ispit";
            this.Load += new System.EventHandler(this.FormIspit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrethodno;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPitanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
    }
}

