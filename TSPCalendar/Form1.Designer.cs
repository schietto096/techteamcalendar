namespace TSPCalendar
{
    partial class Form1
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
            this.buttonMonthLeft = new System.Windows.Forms.Button();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.buttonMonthRight = new System.Windows.Forms.Button();
            this.buttonYearRight = new System.Windows.Forms.Button();
            this.YearLabel = new System.Windows.Forms.Label();
            this.buttonYearLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMonthLeft
            // 
            this.buttonMonthLeft.Location = new System.Drawing.Point(58, 12);
            this.buttonMonthLeft.Name = "buttonMonthLeft";
            this.buttonMonthLeft.Size = new System.Drawing.Size(32, 32);
            this.buttonMonthLeft.TabIndex = 0;
            this.buttonMonthLeft.Text = "<";
            this.buttonMonthLeft.UseVisualStyleBackColor = true;
            this.buttonMonthLeft.Click += new System.EventHandler(this.buttonMonthLeft_Click_1);
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(116, 22);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(37, 13);
            this.MonthLabel.TabIndex = 1;
            this.MonthLabel.Text = "Month";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonthLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMonthRight
            // 
            this.buttonMonthRight.Location = new System.Drawing.Point(191, 12);
            this.buttonMonthRight.Name = "buttonMonthRight";
            this.buttonMonthRight.Size = new System.Drawing.Size(32, 32);
            this.buttonMonthRight.TabIndex = 2;
            this.buttonMonthRight.Text = ">";
            this.buttonMonthRight.UseVisualStyleBackColor = true;
            this.buttonMonthRight.Click += new System.EventHandler(this.buttonMonthRight_Click);
            // 
            // buttonYearRight
            // 
            this.buttonYearRight.Location = new System.Drawing.Point(334, 12);
            this.buttonYearRight.Name = "buttonYearRight";
            this.buttonYearRight.Size = new System.Drawing.Size(32, 32);
            this.buttonYearRight.TabIndex = 5;
            this.buttonYearRight.Text = ">";
            this.buttonYearRight.UseVisualStyleBackColor = true;
            this.buttonYearRight.Click += new System.EventHandler(this.buttonYearRight_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(287, 22);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 4;
            this.YearLabel.Text = "Year";
            // 
            // buttonYearLeft
            // 
            this.buttonYearLeft.Location = new System.Drawing.Point(239, 12);
            this.buttonYearLeft.Name = "buttonYearLeft";
            this.buttonYearLeft.Size = new System.Drawing.Size(32, 32);
            this.buttonYearLeft.TabIndex = 3;
            this.buttonYearLeft.Text = "<";
            this.buttonYearLeft.UseVisualStyleBackColor = true;
            this.buttonYearLeft.Click += new System.EventHandler(this.buttonYearLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 517);
            this.Controls.Add(this.buttonYearRight);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.buttonYearLeft);
            this.Controls.Add(this.buttonMonthRight);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.buttonMonthLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMonthLeft;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Button buttonMonthRight;
        private System.Windows.Forms.Button buttonYearRight;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Button buttonYearLeft;

    }
}

