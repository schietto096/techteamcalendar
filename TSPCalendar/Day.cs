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

        public Day(DayNames d, int number, MonthNames m)
        {
            dow = d;
            dayNum = number;
            monthName = m;

        }
    }

    
}
