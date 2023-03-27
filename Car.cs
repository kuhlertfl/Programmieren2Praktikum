using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Car
    {
        string licensePlate;
        CarBrand carBrand;
        DriveType driveTyp;
        int numberOfSeats;
        string parkhaus;

        public string LicensePlate
        {
            private set { licensePlate = value; }
            get { return licensePlate; }
        }
        public CarBrand CarBrand
        {
            private set { carBrand = value; }
            get { return carBrand; }
        }
        public DriveType DriveType
        {
            private set { driveTyp = value; }
            get { return driveTyp; }
        }
        public int NumberOfSeats
        {
            private set { numberOfSeats = value; }
            get { return numberOfSeats; }
        }
        public string Parkhouse
        {
            private set { parkhaus = value; }
            get { return parkhaus; }
        }
    }
}
