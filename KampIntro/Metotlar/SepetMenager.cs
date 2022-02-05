using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMenager
    {
        public void Add(Product product) // parametre olarak classı verdik clasın bütün özelliklerini aldı
        {
            Console.WriteLine("sepete eklendi : "+ product.Name);
        }

        // sonradan ekleme yapıldğında patlayabiliyoruz
        public void Add2(string productName , string detail, int price, int quantity)
        {
            Console.WriteLine("sepete eklendi : " + productName);
        }
    }
}
