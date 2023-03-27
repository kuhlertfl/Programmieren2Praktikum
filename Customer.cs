using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Customer
    {
        int customNumber;
        Address address;
        Birthdate birthdate;
        int numberOfSeats;
        DriveType driveType;
        CarBrand carBrand;

        public int CustomNumber
        {
            private set { customNumber = value; }
            get { return customNumber; }
        }
        public Address Address
        {
            private set { this.address = value; }
            get { return this.address; }
        }
        public Birthdate Birthday
        {
            private set { birthdate = value; }
            get { return birthdate; }
        }
    }
}
