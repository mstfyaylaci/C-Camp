using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new Product();

            product1.Name = "Dell";
            product1.Price = 10;
            product1.Detail = "notebook";

            Product product2 = new Product();

            product2.Name = "Monster";
            product2.Price = 15;
            product2.Detail = "Gamer Laptop";

            Product[] products = new Product[] { product1,product2};

            foreach (Product product in products) // 1.prodcut typesafe veri tipini vermezmiz lazım  2. takma isim  3.arrray ismi 
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine("-------------------");

            }
            Console.WriteLine("--------Metot lar-----------");
            
            SepetMenager sepetMenager = new SepetMenager();

            sepetMenager.Add(product1);

            sepetMenager.Add(product2);
        }
    }
}
