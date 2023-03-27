using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class ParkHouse
    {
        int capacity;
        Car[] cars = { };
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
            set { }
        }
    }
}
