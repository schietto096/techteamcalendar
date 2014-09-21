namespace TSPCalendar
{
    partial class Agenda
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
            this.tasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tasks
            // 
            this.tasks.AutoSize = true;
            this.tasks.Location = new System.Drawing.Point(13, 13);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(36, 13);
            this.tasks.TabIndex = 0;
            this.tasks.Text = "Tasks";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 310);
            this.Controls.Add(this.tasks);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tasks;



    }
}