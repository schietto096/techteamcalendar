namespace TSPCalendar
{
    partial class NewTask
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startHour = new System.Windows.Forms.NumericUpDown();
            this.startMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AM = new System.Windows.Forms.CheckBox();
            this.AM2 = new System.Windows.Forms.CheckBox();
            this.endMin = new System.Windows.Forms.NumericUpDown();
            this.endHour = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 58);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 74);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time Start";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // startHour
            // 
            this.startHour.AllowDrop = true;
            this.startHour.Location = new System.Drawing.Point(82, 141);
            this.startHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.startHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(64, 20);
            this.startHour.TabIndex = 8;
            this.startHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startMin
            // 
            this.startMin.AllowDrop = true;
            this.startMin.Location = new System.Drawing.Point(152, 141);
            this.startMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMin.Name = "startMin";
            this.startMin.Size = new System.Drawing.Size(64, 20);
            this.startMin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time End";
            // 
            // AM
            // 
            this.AM.AutoSize = true;
            this.AM.Location = new System.Drawing.Point(223, 143);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(42, 17);
            this.AM.TabIndex = 11;
            this.AM.Text = "AM";
            this.AM.UseVisualStyleBackColor = true;
            // 
            // AM2
            // 
            this.AM2.AutoSize = true;
            this.AM2.Location = new System.Drawing.Point(223, 170);
            this.AM2.Name = "AM2";
            this.AM2.Size = new System.Drawing.Size(42, 17);
            this.AM2.TabIndex = 14;
            this.AM2.Text = "AM";
            this.AM2.UseVisualStyleBackColor = true;
            // 
            // endMin
            // 
            this.endMin.AllowDrop = true;
            this.endMin.Location = new System.Drawing.Point(152, 168);
            this.endMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMin.Name = "endMin";
            this.endMin.Size = new System.Drawing.Size(64, 20);
            this.endMin.TabIndex = 13;
            // 
            // endHour
            // 
            this.endHour.AllowDrop = true;
            this.endHour.Location = new System.Drawing.Point(82, 168);
            this.endHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.endHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(64, 20);
            this.endHour.TabIndex = 12;
            this.endHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AM2);
            this.Controls.Add(this.endMin);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.AM);
            this.Controls.Add(this.startMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.Load += new System.EventHandler(this.NewTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startHour;
        private System.Windows.Forms.NumericUpDown startMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox AM;
        private System.Windows.Forms.CheckBox AM2;
        private System.Windows.Forms.NumericUpDown endMin;
        private System.Windows.Forms.NumericUpDown endHour;
    }
}