using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Programmieren2Praktikum
{
    enum DriveType { Hybrid, Electric, Diesel, Petrol }
    enum CarBrand { Leutekutsche, OnlyOffRoad, FaehrtDoch, Zweisitzer }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 2 Parkhouses
            ParkHouse parkHouse1 = new ParkHouse(5);
            ParkHouse parkHouse2 = new ParkHouse(5);

            //Create 3 Cars
            Car car1 = new Car("UL32", CarBrand.Leutekutsche, DriveType.Diesel, 4, parkHouse1);
            Car car2 = new Car("FU43", CarBrand.Leutekutsche, DriveType.Diesel, 4, parkHouse1);
            Car car3 = new Car("NU43", CarBrand.OnlyOffRoad, DriveType.Hybrid, 4, parkHouse1);

            //Add Cars to Parkhouse
            parkHouse1 += car2;
            parkHouse1 = parkHouse1 + car1;
            parkHouse1 = parkHouse1 + car3;

            //Print out every Car in a Parkhouse
            for (int i = 0; i < parkHouse1.Cars.Length; i++)
            {
                Console.WriteLine(parkHouse1.Cars[i]);
            }
            //Check if car exists in a parkhouse
            //prints the LicenseNumber of the searched car if it exists
            //Console.WriteLine(parkHouse1.CarExists(car1));

            //Create Customers
            Customer customer1 = new Customer(12341, new Address("heideloff", "Nürnberg", 90478, "Germany"), new Birthdate(17, 01, 2001), 4, DriveType.Diesel, CarBrand.OnlyOffRoad);
            Customer customer2 = new Customer(45671, new Address("gerlenstraße", "Nürnberg", 90478, "Germany"), new Birthdate(20, 02, 2004), 4, DriveType.Diesel, CarBrand.OnlyOffRoad);
            Customer customer3 = new Customer(89011, new Address("Gansweidweg", "Ulm", 89155, "Germany"), new Birthdate(25, 02, 2004), 4, DriveType.Diesel, CarBrand.OnlyOffRoad);
            //A Car can either be added to a customer by accesing the parkHouse.AddFittingCar method or by accesssing the customer.RentCar method
            //both methods set the customer to a fitting car if existent and delete the car from the Parkhouse 

            parkHouse1.AddFittingCar(customer2);
            Console.WriteLine("Customer2Car: " + customer2.Car);
            foreach(Car car in parkHouse1.Cars)
            {
                Console.WriteLine(car);
            }
            //parkHouse1.AddFittingCar(customer1);

            customer1.RentCar(parkHouse1);
            Console.WriteLine("Customer1Car: " + customer1.Car);


            foreach(Car car in parkHouse1.Cars)
            {
                Console.WriteLine(car);
            }
            
            
            //Print out the Customers
            Console.WriteLine(customer1 + "\n" + customer2 + "\n" +  customer3);







        }
    }
}