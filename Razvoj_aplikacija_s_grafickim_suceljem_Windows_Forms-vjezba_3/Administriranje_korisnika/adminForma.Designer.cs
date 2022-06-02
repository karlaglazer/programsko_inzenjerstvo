namespace Administriranje_korisnika
{
    partial class adminForma
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
            this.components = new System.ComponentModel.Container();
            this.korisniciDataGrid = new System.Windows.Forms.DataGridView();
            this.usersRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // korisniciDataGrid
            // 
            this.korisniciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGrid.Location = new System.Drawing.Point(12, 30);
            this.korisniciDataGrid.Name = "korisniciDataGrid";
            this.korisniciDataGrid.Size = new System.Drawing.Size(643, 208);
            this.korisniciDataGrid.TabIndex = 0;
            this.korisniciDataGrid.SelectionChanged += new System.EventHandler(this.korisniciDataGrid_SelectionChanged);
            // 
            // usersRepositoryBindingSource
            // 
            this.usersRepositoryBindingSource.DataSource = typeof(AutentifikacijaLib.UsersRepository);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(12, 257);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 43);
            this.btnActivate.TabIndex = 1;
            this.btnActivate.Text = "Activate user";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(109, 257);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(75, 43);
            this.btnDeactivate.TabIndex = 2;
            this.btnDeactivate.Text = "Deactivate user";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users:";
            // 
            // adminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.korisniciDataGrid);
            this.Name = "adminForma";
            this.Text = "Administrator Start Form";
            this.Load += new System.EventHandler(this.adminForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView korisniciDataGrid;
        private System.Windows.Forms.BindingSource usersRepositoryBindingSource;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Label label1;
    }
}