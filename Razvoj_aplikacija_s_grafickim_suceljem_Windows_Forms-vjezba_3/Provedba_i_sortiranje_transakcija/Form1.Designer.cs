namespace Provedba_i_sortiranje_transakcija
{
    partial class FormPopisTransakcija
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
            this.dataGridViewPopis = new System.Windows.Forms.DataGridView();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnProvedi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopis
            // 
            this.dataGridViewPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopis.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPopis.Name = "dataGridViewPopis";
            this.dataGridViewPopis.Size = new System.Drawing.Size(514, 228);
            this.dataGridViewPopis.TabIndex = 0;
            this.dataGridViewPopis.SelectionChanged += new System.EventHandler(this.dataGridViewPopis_SelectionChanged);
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Location = new System.Drawing.Point(356, 246);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(75, 47);
            this.btnStorniraj.TabIndex = 1;
            this.btnStorniraj.Text = "Storniraj transakciju";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // btnProvedi
            // 
            this.btnProvedi.Location = new System.Drawing.Point(451, 246);
            this.btnProvedi.Name = "btnProvedi";
            this.btnProvedi.Size = new System.Drawing.Size(75, 47);
            this.btnProvedi.TabIndex = 2;
            this.btnProvedi.Text = "Provedi transakciju";
            this.btnProvedi.UseVisualStyleBackColor = true;
            this.btnProvedi.Click += new System.EventHandler(this.btnProvedi_Click);
            // 
            // FormPopisTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 303);
            this.Controls.Add(this.btnProvedi);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.dataGridViewPopis);
            this.Name = "FormPopisTransakcija";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.FormPopisTransakcija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopis;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button btnProvedi;
    }
}

