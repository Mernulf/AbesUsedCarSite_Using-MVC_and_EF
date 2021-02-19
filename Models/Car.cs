using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CarDb.Models
{
    public class Car
    {
        public Car()
        {
        }

        public Car(int id, string brand, string model, int year, int price, string seller)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Seller = seller;

        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Seller { get; set; }

    }
}
