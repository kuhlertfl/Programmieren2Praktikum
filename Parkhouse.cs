using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class ParkHouse
    {
        //set fields
        int capacity;
        Car[] cars;

        //Propertys
        public int Capacity
        {
            private set { capacity = value; }
            get { return capacity; }
        }
        public Car[] Cars
        {
            get { return this.cars; }
        }

        //Constructor
        public ParkHouse(int capacity)
        {
            this.capacity = capacity;
            this.cars = new Car[capacity];
        }
        public ParkHouse(int capacity, Car[] cars)
        {
            this.capacity = capacity;
            this.cars = new Car[capacity];
            for (int i = 0; i < cars.Length; i++)
            {
                this.cars[i] = cars[i];
            }
        }
        //Overload operators
        public static ParkHouse operator +(ParkHouse parkHouse, Car car)
        {
            for (int i = 0; i < parkHouse.cars.Length; i++)
            {
                if (parkHouse.cars[i] == null)
                {
                    parkHouse.cars[i] = car;
                    return parkHouse;
                }
            }
            throw new Exception("ParkHouse is full");
        }

        public static ParkHouse operator -(ParkHouse parkHouse, Car car)
        {
            for (int i = 0; i < parkHouse.cars.Length; i++)
            {
                if (parkHouse.cars[i] == car)
                {
                    parkHouse.cars[i] = null;
                    return parkHouse;
                }
            }
            throw new Exception("Car is not in the ParkHouse");

        }

        //Methods
        public static Car CarExists(ParkHouse parkHouse, Car car)
        {
            
            for (int i = 0; i < parkHouse.cars.Length; i++)
            {
                if (parkHouse.cars[i] != null)
                {
                    if (parkHouse.cars[i] == car)
                    {
                        return car;
                    }
                }
                
            }
            return null;
        }
        public void AddCars(Car[] cars)
        {
            this.cars = cars;
        }
        public int Length => cars.Length;
        //Indexer
        public Car this[int index]
        {
            get => cars[index];
            set => cars[index] = value; 
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
