using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Programmieren2Praktikum
{
    enum DriveType { Hybrid, Electric, Diesel, Petrol }
    enum CarBrand { Leutekutsche, OnlyOffRoad, FaehrtDoch, Zweisitzer}
    class Addressn 
    {
        string street;
        string city;
        int zipCode;
        string country;
        
        public string Street
        {
            private set { street = value; }
            get { return street; }
        }
        public string City
        {
            private set { city = value; }
            get { return city; }
        }
        public int ZipCode
        {
            private set { zipCode = value; }
            get { return zipCode; }
        }
        public string Country
        {
            private set { this.country = value; }
            get { return this.country}
        }
        public override string ToString()
        => $"Street:{this.street}, City:{this.city}, ZipCode:{this.zipCode}, Country:{this.country}";
    }
    class Birthdate
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
    class Customer
    {
        int customNumber;
        string address;
        Birthdate birthdate;
        int numberOfSeats;
        DriveType driveType;
        CarBrand carBrand;

        public int CustomNumber
        {
            private set { customNumber = value; }
            get { return customNumber; }
        }
        public string Address
        {
            private set { address = value; }
            get { return address; }
        }
        public Birthdate Birthday
        {
            private set { birthdate = value; }
            get { return birthdate; }
        }
    }

    class Car
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

    class Parkhouse
    {
        int capacity;
        Car[] cars = {};
        int indexer;
        public int Capacity
        {
            private set { capacity = value; }
            get { return capacity; }
        }
        public Car this[string gesLicensePlate]
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null && cars[i].LicensePlate == gesLicensePlate)
                    {
                        return cars[i];
                    }
                }
                return null;

            }
            set
            {
                if (handyField[k] == null)
                {
                    handyField[k] = value;
                }
                else
                {
                    throw new Exception("address already taken");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}