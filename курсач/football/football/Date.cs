using System;
using System.Collections.Generic;
using System.Text;

namespace football
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int dd, int mm, int yy)
        {
            if (dd < 32 && mm < 13)
            {
                day = dd;
                month = mm;
                year = yy;
            }
            else
                throw new Exception("Неверный формат даты.");
        }

        public override string ToString()
        {
            return day.ToString() + "." + month.ToString() + "." + year.ToString();
        }
    }
}
