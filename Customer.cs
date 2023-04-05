using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Customer
    {
        //fields
        int customNumber;
        Address address;
        Birthdate birthdate;
        int numberOfSeats;
        DriveType driveType;
        CarBrand carBrand;
        Car car;

       
        //Propertys
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
        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            private set { numberOfSeats = value; }
        }
        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        //Constructor
        public Customer(int customNumber, Address address, Birthdate birthdate, int numberOfSeats, DriveType driveType, CarBrand carBrand)
        {
            this.customNumber = customNumber;
            this.address = address;
            this.Birthday = Birthday;
            this.numberOfSeats = numberOfSeats;
            this.driveType = driveType;
            this.carBrand = carBrand;
            
            

        }
        //Methods 
        public void RentCar(ParkHouse parkhouse)
        {
            for (int i = 0; i < parkhouse.Cars.Length; i++)
            {
                if (parkhouse.Cars[i] != null  && parkhouse.Cars[i].NumberOfSeats == this.NumberOfSeats)
                {
                    this.Car = parkhouse.Cars[i];
                    parkhouse.Cars[i] = null;
                    break;
                }
            }
        }
        public override string ToString()
        => $"CustomerNumber : {CustomNumber}";

        //Indexer

    }
}
