namespace _34._2DArraysRChuIII
{
    partial class frm2DArrays
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
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.RichTextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(67, 12);
            this.nudLength.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 20);
            this.nudLength.TabIndex = 0;
            this.nudLength.ValueChanged += new System.EventHandler(this.NudLength_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(67, 38);
            this.nudWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.ValueChanged += new System.EventHandler(this.NudWidth_ValueChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 14);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(49, 13);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length : ";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 40);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width : ";
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(12, 64);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(324, 227);
            this.txtArray.TabIndex = 4;
            this.txtArray.Text = "";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(9, 306);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(56, 13);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average : ";
            // 
            // frm2DArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 328);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudLength);
            this.Name = "frm2DArrays";
            this.Text = "2D Arrays Program By Romy I. Chu III";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.RichTextBox txtArray;
        private System.Windows.Forms.Label lblAverage;
    }
}

