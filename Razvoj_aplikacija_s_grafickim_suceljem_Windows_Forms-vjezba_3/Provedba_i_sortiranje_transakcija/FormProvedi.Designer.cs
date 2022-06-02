namespace Provedba_i_sortiranje_transakcija
{
    partial class FormProvedi
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
            this.comboPlatitelj = new System.Windows.Forms.ComboBox();
            this.comboPrimatelj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnProvedi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platitelj: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primatelj: ";
            // 
            // comboPlatitelj
            // 
            this.comboPlatitelj.FormattingEnabled = true;
            this.comboPlatitelj.Location = new System.Drawing.Point(98, 44);
            this.comboPlatitelj.Name = "comboPlatitelj";
            this.comboPlatitelj.Size = new System.Drawing.Size(121, 21);
            this.comboPlatitelj.TabIndex = 2;
            // 
            // comboPrimatelj
            // 
            this.comboPrimatelj.FormattingEnabled = true;
            this.comboPrimatelj.Location = new System.Drawing.Point(98, 87);
            this.comboPrimatelj.Name = "comboPrimatelj";
            this.comboPrimatelj.Size = new System.Drawing.Size(121, 21);
            this.comboPrimatelj.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iznos:";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(98, 148);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(121, 20);
            this.txtIznos.TabIndex = 5;
            // 
            // btnProvedi
            // 
            this.btnProvedi.Location = new System.Drawing.Point(52, 192);
            this.btnProvedi.Name = "btnProvedi";
            this.btnProvedi.Size = new System.Drawing.Size(75, 23);
            this.btnProvedi.TabIndex = 6;
            this.btnProvedi.Text = "Provedi";
            this.btnProvedi.UseVisualStyleBackColor = true;
            this.btnProvedi.Click += new System.EventHandler(this.btnProvedi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(144, 192);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FormProvedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 249);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnProvedi);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPrimatelj);
            this.Controls.Add(this.comboPlatitelj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProvedi";
            this.Text = "FormProvedi";
            this.Load += new System.EventHandler(this.FormProvedi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPlatitelj;
        private System.Windows.Forms.ComboBox comboPrimatelj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnProvedi;
        private System.Windows.Forms.Button btnOdustani;
    }
}