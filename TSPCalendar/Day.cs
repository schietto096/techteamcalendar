using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPCalendar
{
    class Day
    {
        public DayNames dow;
        public int dayNum;
        public MonthNames monthName;

        public List<Task> Tasks = new List<Task>();

        public Day(DayNames d, int number, MonthNames m)
        {
            dow = d;
            dayNum = number;
            monthName = m;




        }


        void AddTask(string n, string l, string d){

            Task temp = new Task();

            temp.TaskName = n;
            temp.TaskLocation = l;
            temp.TaskDescription = d;

            Tasks.Add(temp);

        }
    }

    
}
