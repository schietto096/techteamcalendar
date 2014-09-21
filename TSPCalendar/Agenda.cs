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
    public partial class Agenda : Form
    {
        private int day;
        private MonthNames month;
        private int year;
        private Calendar cal;


        public Agenda(int d, MonthNames m, int y, Calendar c)
        {
            InitializeComponent();

            day = d;
            month = m;
            year = y;
            cal = c;

            loadTaskList();

        }

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void loadTaskList()
        {
            Console.WriteLine(day.ToString() +" " +month.ToString() +" " +year.ToString());

            //temp output string
            string allTasks = "";

            List<Task> tempTasks = cal.GetTasks(day,month,year);

            foreach (Task t in tempTasks)
            {

                //format start time string
                string sT = t.taskTime.startHour.ToString() + ":";

                if (t.taskTime.startMin < 10)
                {
                    sT += "0" + t.taskTime.startMin.ToString();
                }
                else
                {
                    sT += t.taskTime.startMin.ToString();
                }

                if (t.taskTime.startAmPm)
                {
                    sT += "am";
                }
                else
                {
                    sT += "pm";
                }

                //format end time string
                string eT = t.taskTime.endHour.ToString() + ":";

                if (t.taskTime.endMin < 10)
                {
                    eT += "0" + t.taskTime.endMin.ToString();
                }
                else
                {
                    eT += t.taskTime.endMin.ToString();
                }

                if (t.taskTime.endAmPm)
                {
                    eT += " am";
                }
                else
                {
                    eT += " pm";
                }


                allTasks += "Name: " + t.taskName +"\n    Time: " +sT +" -> " +eT +"\n    Location: " + t.taskLocation + "\n\t\t    Description: " + t.taskDescription + "\n\n";

            }

            Console.WriteLine(allTasks);

            //set tasks value
            tasks.Text = allTasks;

        }

        private void tasks_Click(object sender, EventArgs e)
        {
            
        }

    }
}
