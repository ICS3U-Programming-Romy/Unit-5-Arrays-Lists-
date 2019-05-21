namespace _35.PassFailRChuIII
{
    partial class frmPassFail
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
            this.btnGetResult = new System.Windows.Forms.Button();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(93, 12);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(75, 23);
            this.btnGetResult.TabIndex = 0;
            this.btnGetResult.Text = "GetResult";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.BtnGetResult_Click);
            // 
            // btnPickFile
            // 
            this.btnPickFile.Location = new System.Drawing.Point(12, 12);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(75, 23);
            this.btnPickFile.TabIndex = 1;
            this.btnPickFile.Text = "Pick File";
            this.btnPickFile.UseVisualStyleBackColor = true;
            // 
            // frmPassFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 47);
            this.Controls.Add(this.btnPickFile);
            this.Controls.Add(this.btnGetResult);
            this.Name = "frmPassFail";
            this.Text = "Pass Fail Program By Romy I. Chu III";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Button btnPickFile;
    }
}

