using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtokushta
{
    class CarDealerShip
    {
        private int numberOfOwner;
        public int NumberOfOwner
        {
            get { return numberOfOwner; }
            set { numberOfOwner = value; }
        }

        private string licensePlate;
        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        private string engineNumber;

        public string EngineNumber
        {
            get { return engineNumber; }
            set { engineNumber = value; }
        }

        private string compartmentNumber;

        public string CompartmentNumber
        {
            get { return compartmentNumber; }
            set { compartmentNumber = value; }
        }

        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void Input()
        {
            Console.Write($"Nomer na sobstvenika: ");
            this.NumberOfOwner = int.Parse(Console.ReadLine());
            Console.Write($"Nomer na avtomobil: ");
            this.LicensePlate = Console.ReadLine();
            Console.Write($"Nomer na dvigatel: ");
            this.EngineNumber = Console.ReadLine();
            Console.Write($"Nomer na kupe: ");
            this.CompartmentNumber = Console.ReadLine();
            Console.Write($"Marka: ");
            this.Brand = Console.ReadLine();
            Console.Write($"Cena: ");
            this.Price = double.Parse(Console.ReadLine());
            Console.Write($"Godina: ");
            this.Year = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine($"Nomer na sobstvenika: 0{this.NumberOfOwner} Nomer na avtomobil: {this.LicensePlate} Nomer na dvigatel: {this.EngineNumber}" +
                $" Nomer na kupe: {this.CompartmentNumber} Marka: {this.Brand} Cena: {this.Price}lv. Godina: {this.Year}");
        }
    }
}
