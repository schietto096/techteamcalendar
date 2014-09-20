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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.buttonMonthLeft, "buttonMonthLeft");
            this.buttonMonthLeft.Name = "buttonMonthLeft";
            this.buttonMonthLeft.UseVisualStyleBackColor = true;
            this.buttonMonthLeft.Click += new System.EventHandler(this.buttonMonthLeft_Click_1);
            // 
            // MonthLabel
            // 
            this.MonthLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MonthLabel, "MonthLabel");
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMonthRight
            // 
            resources.ApplyResources(this.buttonMonthRight, "buttonMonthRight");
            this.buttonMonthRight.Name = "buttonMonthRight";
            this.buttonMonthRight.UseVisualStyleBackColor = true;
            this.buttonMonthRight.Click += new System.EventHandler(this.buttonMonthRight_Click);
            // 
            // buttonYearRight
            // 
            resources.ApplyResources(this.buttonYearRight, "buttonYearRight");
            this.buttonYearRight.Name = "buttonYearRight";
            this.buttonYearRight.UseVisualStyleBackColor = true;
            this.buttonYearRight.Click += new System.EventHandler(this.buttonYearRight_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.YearLabel, "YearLabel");
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Click += new System.EventHandler(this.YearLabel_Click);
            // 
            // buttonYearLeft
            // 
            resources.ApplyResources(this.buttonYearLeft, "buttonYearLeft");
            this.buttonYearLeft.Name = "buttonYearLeft";
            this.buttonYearLeft.UseVisualStyleBackColor = true;
            this.buttonYearLeft.Click += new System.EventHandler(this.buttonYearLeft_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonYearRight);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.buttonYearLeft);
            this.Controls.Add(this.buttonMonthRight);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.buttonMonthLeft);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);

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

