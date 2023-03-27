using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Programmieren2Praktikum
{
    enum DriveType { Hybrid, Electric, Diesel, Petrol }
    enum CarBrand { Leutekutsche, OnlyOffRoad, FaehrtDoch, Zweisitzer}

    internal class Program
    {
        static void Main(string[] args)
        {
            
            ParkHouse parkHouse1 = new ParkHouse(5,new Car[5]);
            ParkHouse parkHouse2 = new ParkHouse(5);
            Car car1 = new Car("UL32", CarBrand.Leutekutsche, DriveType.Diesel, 4, parkHouse1);
            Car car2 = new Car("FU43", CarBrand.Leutekutsche, DriveType.Diesel, 4, parkHouse1);
            Car car3 = new Car("NU43", CarBrand.OnlyOffRoad , DriveType.Hybrid, 4, parkHouse1);
            Car[] cars = { car1, car2, car3 };
            
            Console.WriteLine(car1);
            Console.WriteLine(parkHouse1.CarExists(car1));

        }
    }
}