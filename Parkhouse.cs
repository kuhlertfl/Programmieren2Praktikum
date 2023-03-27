using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class ParkHouse
    {
        //set fields
        int capacity;
        Car[] cars;

        //Overload operators
        public static Car[] operator + (Car[] cars , Car car)
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
        public static Car[] operator - (Car[] cars , Car searchedCar)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == searchedCar)
                {
                    cars[i] == null; 
                }
            }
        }

        //Propertys
        public int Capacity
        {
            private set { capacity = value; }
            get { return capacity; }
        }
        public Car[] Cars
        {
            get { rewturn this.cars; }
        }

        //Constructor
        public ParkHouse(int capacity, Car[] cars = new Car[capacity])
        {
            if(cars.Length > capacity)
            {
                throw new Exception("The Parkhouse capacity is too low");
            }
            this.cars = cars;
        }

        //Indexer
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
            
        }
        public Car[] this[CarBrand carbrand]
        {

            get
            {
                Car[] tempArray = new Car[1];
                int foundIndex = 0;
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null && cars[i].CarBrand == carbrand)
                    {
                        if (foundIndex == tempArray.Length)
                        {
                            Array.Resize(ref tempArray, tempArray.Length * 2);
                        }
                        tempArray[foundIndex] = cars[i];
                        foundIndex++;
                    }
                }
                Car[] fittingCars = new Car[foundIndex];
                Array.Copy(tempArray, fittingCars, foundIndex);
                if (foundIndex == 0)
                {
                    return null;
                }
                return fittingCars;
            }
            
        }
    }
}
