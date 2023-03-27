using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren2Praktikum
{
    internal class Address
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
            get { return this.country; }
        }
        public override string ToString()
        => $"Street:{this.street}, City:{this.city}, ZipCode:{this.zipCode}, Country:{this.country}";
    }
}
