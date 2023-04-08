using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Birthdate
    {
        //fields
        int day;
        int month;
        int year;

        //Propertys
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
        //Constructor
        public Birthdate( int day, int month, int year )
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        //Methods
        public override string ToString()
        => $"{ day }.{ month }.{ year }";
        
    }
}
