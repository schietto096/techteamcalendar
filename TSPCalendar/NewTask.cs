using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSPCalendar
{
    public partial class NewTask : Form
    {
        private Form1 main;

        public NewTask( Form1 f )
        {
            InitializeComponent();
            
            main = f;
        
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            Time t = new Time();

            t.startHour = (int)startHour.Value;
            t.startMin = (int)startMin.Value;
            t.startAmPm = AM.Checked;
            t.endHour = (int)endHour.Value;
            t.endMin = (int)endMin.Value;
            t.endAmPm = AM2.Checked;

            main.makeTask(textBox1.Text, textBox2.Text, textBox3.Text,t);

            main.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            main.Show();
        }

        private void startHour_ValueChanged(object sender, EventArgs e)
        {
            if (((int)startHour.Value) > 12)
            {
                startHour.Value = 1;
            }

            if (((int)startHour.Value) < 1)
            {
                startHour.Value = 12;
            } 
                
        }

        private void startMin_ValueChanged(object sender, EventArgs e)
        {
            if (((int)startMin.Value) > 59)
            {
                startMin.Value = 0;
            }

            if (((int)startMin.Value) < 0)
            {
                startMin.Value = 59;
            } 
        }

        private void endHour_ValueChanged(object sender, EventArgs e)
        {
            if (((int)endHour.Value) > 12)
            {
                endHour.Value = 1;
            }

            if (((int)endHour.Value) < 1)
            {
                endHour.Value = 12;
            } 
        }

        private void endMin_ValueChanged(object sender, EventArgs e)
        {

            if (((int)endMin.Value) > 59)
            {
                endMin.Value = 0;
            }

            if (((int)endMin.Value) < 0)
            {
                endMin.Value = 59;
            } 

        }
    }
}
