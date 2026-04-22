using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class PlaneTicket
    {
        // Field 
        private string _origin;
        private string _destination;
        private double _cost; 
        private string _currency;

        // Properties
        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        // Method
        public void PrintSummary()
        {
            Console.WriteLine($"Origin: {Origin}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Cost: {Cost} ({Currency})");

            // Logika konversi mata uang
            if (Currency.ToUpper() == "USD")
            {
                // Karena Cost sudah double, perkalian ini sekarang valid
                double convertToRupiah = Cost * 15000;
                Console.WriteLine($"Convert to Rupiah: {convertToRupiah}");
            }
            else if (Currency.ToUpper() == "IDR")
            {
                // Memperbaiki typo 'cosst' menjadi 'Cost'
                double convertToDolar = Cost / 15000;
                Console.WriteLine($"Convert to Dolar: {convertToDolar}");
            }

            Console.WriteLine();
        }
    }
}
