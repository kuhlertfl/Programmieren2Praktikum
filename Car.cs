using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Car
    {
        //fields
        string licensePlate;
        CarBrand carBrand;
        DriveType driveTyp;
        int numberOfSeats;
        ParkHouse parkHouse;
        //overload true false
        

        //Propertys
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
        public ParkHouse Parkhouse
        {
            private set { parkHouse = value; }
            get { return parkHouse; }
        }

        public static bool operator ==(Car car1, Car car2)
        {
            // Check if both cars are null
            if (ReferenceEquals(car1, null) && ReferenceEquals(car2, null))
                return true;

            // Check if either car is null
            if (ReferenceEquals(car1, null) || ReferenceEquals(car2, null))
                return false;

            // Compare the license plates of the two cars
            return car1.LicensePlate == car2.LicensePlate;
        }

        // Overloaded != operator to negate the result of the == operator
        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }
        //Methods
        public override string ToString()
        => $"{LicensePlate}";

        //Constructor
        public Car(string licensePlate, CarBrand carBrand, DriveType driveType, int numberOfSeats, ParkHouse parkHouse)
        {
            this.LicensePlate = licensePlate;
            this.CarBrand = carBrand;
            this.DriveType = driveTyp;
            this.numberOfSeats = numberOfSeats;
            this.parkHouse = parkHouse;
        }
    }
}
