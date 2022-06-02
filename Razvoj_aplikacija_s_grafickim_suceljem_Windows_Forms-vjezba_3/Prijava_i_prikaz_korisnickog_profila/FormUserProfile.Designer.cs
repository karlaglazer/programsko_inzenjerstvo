namespace Prijava_i_prikaz_korisničkog_profila
{
    partial class FormUserProfile
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.radioBtnGuest = new System.Windows.Forms.RadioButton();
            this.radioBtnEmployee = new System.Windows.Forms.RadioButton();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // txtFirst
            // 
            this.txtFirst.Enabled = false;
            this.txtFirst.Location = new System.Drawing.Point(81, 48);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(129, 20);
            this.txtFirst.TabIndex = 4;
            // 
            // txtLast
            // 
            this.txtLast.Enabled = false;
            this.txtLast.Location = new System.Drawing.Point(81, 80);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(129, 20);
            this.txtLast.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(81, 139);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(129, 20);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(81, 171);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(129, 20);
            this.txtPass.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnEmployee);
            this.groupBox1.Controls.Add(this.radioBtnGuest);
            this.groupBox1.Controls.Add(this.radioBtnAdmin);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(82, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User type:";
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Location = new System.Drawing.Point(16, 30);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(85, 17);
            this.radioBtnAdmin.TabIndex = 0;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "Administrator";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnGuest
            // 
            this.radioBtnGuest.AutoSize = true;
            this.radioBtnGuest.Location = new System.Drawing.Point(16, 53);
            this.radioBtnGuest.Name = "radioBtnGuest";
            this.radioBtnGuest.Size = new System.Drawing.Size(53, 17);
            this.radioBtnGuest.TabIndex = 1;
            this.radioBtnGuest.TabStop = true;
            this.radioBtnGuest.Text = "Guest";
            this.radioBtnGuest.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmployee
            // 
            this.radioBtnEmployee.AutoSize = true;
            this.radioBtnEmployee.Location = new System.Drawing.Point(16, 76);
            this.radioBtnEmployee.Name = "radioBtnEmployee";
            this.radioBtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.radioBtnEmployee.TabIndex = 2;
            this.radioBtnEmployee.TabStop = true;
            this.radioBtnEmployee.Text = "Employee";
            this.radioBtnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(135, 326);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 362);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUserProfile";
            this.Text = "FormUserProfile";
            this.Load += new System.EventHandler(this.FormUserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnEmployee;
        private System.Windows.Forms.RadioButton radioBtnGuest;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.Button btnLogOut;
    }
}