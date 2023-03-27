using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Birthdate
    {
        int day;
        int month;
        int year;
        public int Day
        {
            private set { day = value; }
            get { return day; }
        }
        public int Month
        {
            private set { month = value; }
            get { return month; }
        }
        public int Year
        {
            private set { year = value; }
            get { return year; }
        }
        public override string ToString()
        => $"{day}.{month}.{year}";
    }
}
