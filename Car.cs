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
        //operator overloads
        public static Car[] operator +(Car[] cars, Car car)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    cars[i] = car;
                }
            }
            return cars;
        }
        public static bool operator ==(Car car1, Car car2) => car1.LicensePlate == car2.LicensePlate;
        public static bool operator !=(Car car1, Car car2) => !(car1 == car2);
        public static Car[] operator -(Car[] cars, Car searchedCar)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == searchedCar)
                {
                    cars[i] = null;
                }
            }
            return cars;
        }

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
