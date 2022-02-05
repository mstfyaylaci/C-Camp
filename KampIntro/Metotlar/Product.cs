using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        // Property -- özellikler
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Detail { get; set; }

        // sonradan eklendiğii için projede kendimizi tekrarlamıyoruz
        public int Quantity { get; set; }
    }

}
