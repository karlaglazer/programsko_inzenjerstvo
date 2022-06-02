namespace Inventura
{
    partial class ReportForm
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.richTxtReport = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(284, 323);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(149, 37);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display report";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // richTxtReport
            // 
            this.richTxtReport.Location = new System.Drawing.Point(21, 24);
            this.richTxtReport.Name = "richTxtReport";
            this.richTxtReport.Size = new System.Drawing.Size(411, 287);
            this.richTxtReport.TabIndex = 1;
            this.richTxtReport.Text = "";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 374);
            this.Controls.Add(this.richTxtReport);
            this.Controls.Add(this.btnDisplay);
            this.Name = "ReportForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.RichTextBox richTxtReport;
    }
}

