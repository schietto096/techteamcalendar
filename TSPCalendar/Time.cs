using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPCalendar
{
    class Time
    {

        public int startHour;
        public int startMin;
        public bool startAmPm;
        public int endHour;
        public int endMin;
        public bool endAmPm;
        
        string startTime() {
            if (startAmPm) //am is true
            {
                return startHour + "" + startMin;
            }
            else
            {
                startHour = startHour + 12;
                return startHour + "" + startMin;
            }
        }

        string endTime()
        {
            if (endAmPm) //am is true
            {
                return endHour + "" + endMin;
            }
            else
            {
                endHour = endHour + 12;
                return endHour + "" + endMin;
            }
        }


    }

}
