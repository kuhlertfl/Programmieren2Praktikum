using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            get;
            set;
        }

        //Constructor
        public ParkHouse(int capacity)
        {
            Cars = new Car[capacity];
            
        }
        public ParkHouse(int capacity, Car[] cars)
        {
            this.capacity = capacity;
            Cars = new Car[capacity];
            for (int i = 0; i < cars.Length; i++)
            {
                Cars[i] = cars[i];
            }
        }
        //Overload operators
        public static ParkHouse operator +(ParkHouse parkHouse, Car car)
        {
            for (int i = 0; i < parkHouse.Cars.Length; i++)
            {
                if (parkHouse.Cars[i] == null)
                {
                    parkHouse.Cars[i] = car;
                    return parkHouse;
                }
            }
            throw new InvalidOperationException("ParkHouse is full");
        }

        public static ParkHouse operator -(ParkHouse parkHouse, Car car)
        {
            for (int i = 0; i < parkHouse.Cars.Length; i++)
            {
                if (parkHouse.Cars[i] == car)
                {
                    parkHouse.Cars[i] = null;
                    return parkHouse;
                }
            }
            throw new InvalidOperationException("Car is not in the ParkHouse");

        }
        

        //Methods
        public void AddFittingCar(Customer customer)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null  && Cars[i].NumberOfSeats == customer.NumberOfSeats)
                {
                    customer.Car = Cars[i];
                    Cars[i] = null;
                    break;
                }
            }
            
        }
        public Car CarExists(Car car)
        {
            
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null)
                {
                    if (Cars[i] == car)
                    {
                        return car;
                    }
                }
                
            }
            Console.WriteLine("Car is not in the ParkHouse");
            return null;
        }
        public void AddCars(Car[] cars)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (Cars[i] != null)
                    {
                        Cars[i] = cars[i];
                    }
                }
            }
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
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (Cars[i] != null && Cars[i].LicensePlate == gesLicensePlate)
                    {
                        return Cars[i];
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
