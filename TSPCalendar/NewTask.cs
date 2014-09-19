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

        }
    }
}
