using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPCalendar
{
    public class Month
    {

        public MonthNames monthName;
        public int numDays = 31;
        public List<Day> days = new List<Day>();

        public Month(MonthNames n, int d)
        {
            monthName = n;
            numDays = d;

        }

        
    }

    
}
