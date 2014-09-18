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

        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            // instantiate calender class
            cal = new Calendar();

            // initilize calendar
            cal.initCalendar(currentYear);

            //load month in GUI
            loadMonth(MonthNames.August);



        }

        void loadMonth( MonthNames m)
        {
            // if buttons in temp button array, delete them
            if (buttons.Count > 0)
            {
                foreach (Button b in buttons)
                {
                    this.Controls.Remove(b);
                    //buttons.Remove(b);
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

                btn.Width = daySize;
                btn.Height = daySize;

                btn.TextAlign = ContentAlignment.TopLeft;

                btn.Location = new Point(
                    daySize * (d % 7) + boarder,  // x position value
                    daySize * (d / 7) + boarder * 3   // y position value
                    );

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

                this.Controls.Add(lbl);
            }


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

        }

        private void buttonMonthRight_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null && (int) currentMonth < 12)
            {
                currentMonth += 1;
                loadMonth(currentMonth);
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
    }
}
