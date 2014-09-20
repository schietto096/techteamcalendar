using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPCalendar
{
    public enum DayNames { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    public enum MonthNames { January = 1, February, March, April, May, June, July, August, September, October, November, December };

    class Calendar
    {

        public Year year;
        public List<Task> tasks = new List<Task>();

        public void initCalendar(int y)
        {

            //create current year
            year = new Year();

            //populate year with months
            year.months = new List<Month>();

            year.months.Add(new Month(MonthNames.January,31));
            year.months.Add(new Month(MonthNames.February,28));     // needs leap year check
            year.months.Add(new Month(MonthNames.March, 31));
            year.months.Add(new Month(MonthNames.April, 30));
            year.months.Add(new Month(MonthNames.May, 31));
            year.months.Add(new Month(MonthNames.June, 30));
            year.months.Add(new Month(MonthNames.July, 31));
            year.months.Add(new Month(MonthNames.August, 31));
            year.months.Add(new Month(MonthNames.September, 30));
            year.months.Add(new Month(MonthNames.October, 31));
            year.months.Add(new Month(MonthNames.November, 30));
            year.months.Add(new Month(MonthNames.December, 31));

            //populate each month with days
            foreach(Month m in year.months)
            {

                //get start day of week
                DateTime date = new DateTime(y, (int) m.monthName, 1);
                int dow = (int) date.DayOfWeek;

                //add day to month
                for (int i = 0; i < m.numDays; i++ )
                {
                    m.days.Add(new Day((DayNames) ((i%7)+dow), i+1, m.monthName));
                }
            }

        }

        public bool HasTask(int d, MonthNames m, int year)
        {

            

            foreach (Task t in tasks)
            {

                if (t.taskYear == year && t.taskMonth == m && t.taskDay == d)
                {
                    return true;
                }

            }

            return false;
        }

        public int NumTask(int d, MonthNames m, int year)
        {

            int numTasks = 0;

            foreach (Task t in tasks)
            {

                if (t.taskYear == year && t.taskMonth == m && t.taskDay == d)
                {
                    numTasks++;
                }

            }

            return numTasks;
        }

        public List<Task> GetTaskList()
        {
            return this.tasks;
        }





    }




}