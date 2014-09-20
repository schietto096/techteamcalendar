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
    public partial class Form1 : Form
    {

        int boarder = 32;   // pixel border size of tiles
        int daySize = 64;   // pixel size of tiles

        private Calendar cal;
        private MonthNames currentMonth;
        private int currentYear = 2014;
        private int currentDay = 1;

        private List<Button> buttons = new List<Button>();
        private List<Label> labels = new List<Label>();

        public Form1()
        {
            InitializeComponent();

            // get current system day month and year
            currentDay = System.DateTime.Now.Day;
            currentMonth = (MonthNames)System.DateTime.Now.Month;
            currentYear = System.DateTime.Now.Year;


            // instantiate calender class
            cal = new Calendar();

            // initilize calendar
            cal.initCalendar(currentYear);

            //load month in GUI
            loadMonth(currentMonth);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;



        }

        void loadMonth( MonthNames m)
        {
            // if buttons in temp button array, delete them
            if (buttons.Count > 0)
            {
                foreach (Button b in buttons)
                {
                    //this.buttons.Remove(b);
                    this.Controls.Remove(b);
                    //buttons.Clear();
                }
            }

            // if labels in temp label array, delete them
            if (labels.Count > 0)
            {
                foreach (Label l in labels)
                {
                    this.Controls.Remove(l);
                }
            }

            //set current month
            currentMonth = m;

            //calculate day and shift value, Sun = 0, Sat = 6
            int dayShift = ((int)(cal.year.months[(int)currentMonth - 1].days[0].dow));

            // for every day in month add button in form1
            for (
                int d = 0 + dayShift;                                           //get starting day and shift appropriately
                d < cal.year.months[(int)currentMonth - 1].numDays + dayShift;  // total days + shift value
                d++
                )
            {

                Button btn = new Button();

                btn.Text = cal.year.months[(int)currentMonth - 1].days[d - dayShift].dayNum.ToString();

                btn.Width = daySize-4;
                btn.Height = daySize-4;

                btn.TextAlign = ContentAlignment.TopLeft;

                btn.Location = new Point(
                    daySize * (d % 7) + boarder,  // x position value
                    daySize * (d / 7) + boarder * 3   // y position value
                    );

                //get rid of boarder and change color
                btn.BackColor = System.Drawing.Color.Ivory;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Microsoft Sans serif",16);

                if(System.DateTime.Now.Day == d+1-dayShift && System.DateTime.Now.Month == (int) currentMonth && System.DateTime.Now.Year == currentYear)
                {
                    btn.BackColor = System.Drawing.Color.LawnGreen;
                }
                

                // check if day has a task
                int numTasks = cal.NumTask(d + 1 - dayShift, currentMonth, currentYear);

                if (numTasks > 0)
                {
                    // Add indicator for task at this day

                    Button taskLabel = new Button();

                    taskLabel.Location = new Point(
                         daySize * (d % 7) + boarder + (daySize/2),  // x position value
                         daySize * (d / 7) + boarder * 3 +(daySize/2)  // y position value
                        );

                    taskLabel.Text = numTasks.ToString();

                    taskLabel.Width = daySize / 2 - 3;
                    taskLabel.Height = daySize / 2 - 3;

                    //get rid of boarder and change color
                    taskLabel.BackColor = System.Drawing.Color.SeaGreen;
                    taskLabel.FlatStyle = FlatStyle.Flat;
                    taskLabel.FlatAppearance.BorderSize = 0;
                    taskLabel.ForeColor = System.Drawing.Color.White;
                    taskLabel.Font = new Font("Microsoft Sans serif", 12);

                    this.Controls.Add(taskLabel);
                    this.buttons.Add(taskLabel);
                }

                btn.Click += new EventHandler(this.buttonDay_Click);

                this.Controls.Add(btn);

                //add day buttons to holder list
                buttons.Add(btn);

            }

            //Update labels
            MonthLabel.Text = currentMonth.ToString();
            YearLabel.Text = currentYear.ToString();

            //Display Days of week
            for (int i = 0; i < 7; i++)
            {
                Label lbl = new Label();
                lbl.Text = ((DayNames)i).ToString();
                lbl.Width = daySize;
                lbl.TextAlign = ContentAlignment.TopCenter;


                lbl.Location = new Point(
                    daySize * i + boarder,
                    2 * boarder
                    );

                lbl.BackColor = System.Drawing.Color.Transparent;

                this.Controls.Add(lbl);
                
            }



            //Display Tasks if present




        }

        public void makeTask(string n, string l, string d, Time t)
        {

            // create new task:

            Task task = new Task();

            task.taskName = n;
            task.taskLocation = l;
            task.taskDescription = d;
            task.taskTime = t;
            task.taskDay = currentDay;
            task.taskMonth = currentMonth;
            task.taskYear = currentYear;

            // add new task to year
            cal.tasks.Add(task);

            loadMonth(currentMonth);


        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //get day of month from button text
            currentDay = int.Parse(btn.Text);

            this.Hide();
            

            // make a new task window prompt
            NewTask newTask = new NewTask(this);
            newTask.Show();
            
        }

        private void buttonMonthLeft_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMonthLeft_Click_1(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null && (int) currentMonth > 1)
            {
                currentMonth -= 1;
                loadMonth(currentMonth);
            }
            // January to December decrement year
            else if (btn != null && (int)currentMonth == 1)
            {
                currentMonth = currentMonth + 11;
                //decrement year
                currentYear -= 1;

                //reinit calendar
                cal.initCalendar(currentYear);

                //reload month GUI
                loadMonth(currentMonth);

                //update year label
                YearLabel.Text = currentYear.ToString();
            }

        }

        private void buttonMonthRight_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null && (int) currentMonth < 12)
            {
                currentMonth += 1;
                loadMonth(currentMonth);
            }
            // December to January increment year
            else if (btn != null && (int)currentMonth == 12)
            {
                currentMonth = currentMonth - 11;
                currentYear += 1;
                //reinit calendar
                cal.initCalendar(currentYear);

                //reload month GUI
                loadMonth(currentMonth);

                //update year label
                YearLabel.Text = currentYear.ToString();
                

            }

        }

        private void buttonYearLeft_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null)
            {
                //decrement year
                currentYear -= 1;

                //reinit calendar
                cal.initCalendar(currentYear);

                //reload month GUI
                loadMonth(currentMonth);

                //update year label
                YearLabel.Text = currentYear.ToString();
            }

        }

        private void buttonYearRight_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null)
            {
                //increment year
                currentYear += 1;

                //reinit calendar
                cal.initCalendar(currentYear);

                //reload month GUI
                loadMonth(currentMonth);

                //update year label
                YearLabel.Text = currentYear.ToString();
            }

        }

        private void YearLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
