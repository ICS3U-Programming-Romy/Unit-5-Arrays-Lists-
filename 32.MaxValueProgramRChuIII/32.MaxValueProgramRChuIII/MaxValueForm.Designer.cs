namespace _32.MaxValueProgramRChuIII
{
    partial class frmMaxValue
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnMaxValue = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnMaxValue
            // 
            this.btnMaxValue.Location = new System.Drawing.Point(12, 207);
            this.btnMaxValue.Name = "btnMaxValue";
            this.btnMaxValue.Size = new System.Drawing.Size(91, 23);
            this.btnMaxValue.TabIndex = 1;
            this.btnMaxValue.Text = "Find Max Value";
            this.btnMaxValue.UseVisualStyleBackColor = true;
            this.btnMaxValue.Click += new System.EventHandler(this.btnMaxValue_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(12, 41);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 160);
            this.lstNumbers.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(153, 212);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(111, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "The highest value is : ";
            // 
            // frmMaxValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 266);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnMaxValue);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmMaxValue";
            this.Text = "Max Value Program By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnMaxValue;
        private System.Windows.Forms.ListBox lstNumbers;
        public System.Windows.Forms.Label lblOutput;
    }
}

