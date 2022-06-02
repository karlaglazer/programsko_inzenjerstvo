namespace Konverzija_valuta
{
    partial class FrmConverter
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
            this.comboBoxCurrency1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCurrency2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose first currency: ";
            // 
            // comboBoxCurrency1
            // 
            this.comboBoxCurrency1.FormattingEnabled = true;
            this.comboBoxCurrency1.Location = new System.Drawing.Point(64, 49);
            this.comboBoxCurrency1.Name = "comboBoxCurrency1";
            this.comboBoxCurrency1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurrency1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose second currency: ";
            // 
            // comboBoxCurrency2
            // 
            this.comboBoxCurrency2.FormattingEnabled = true;
            this.comboBoxCurrency2.Location = new System.Drawing.Point(64, 89);
            this.comboBoxCurrency2.Name = "comboBoxCurrency2";
            this.comboBoxCurrency2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurrency2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(64, 129);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(79, 175);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Converted amount:";
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(64, 240);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(100, 20);
            this.txtConverted.TabIndex = 8;
            // 
            // FrmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 300);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCurrency2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCurrency1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConverter";
            this.Text = "Money Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCurrency1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCurrency2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConverted;
    }
}

