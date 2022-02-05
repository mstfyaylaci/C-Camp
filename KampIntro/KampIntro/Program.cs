using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            // type safety : tip güveliği değişken ne ise onu belirtmek lazım
            // do not repat yourself: kendini tekrarlama

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin ";
            kurs1.IzlenmeOranı = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mustafa ";
            kurs2.IzlenmeOranı = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Mervan ";
            kurs3.IzlenmeOranı = 30;

            // yeni bir kurs eklemek istediğimizde sadece kurs4 ve bu kurs4 ü listeye ekleyerek kendimizi tekerarlamamış oluyoruz
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +":" +kurs.Egitmen );
            }
            
            /*
             * ternary oporotörü kullanımı
            string kullaniciAdi = "", sifre = "";
            
            Console.WriteLine("Kullanici Adini Girin: ");
            
            kullaniciAdi = Console.ReadLine();
            
            Console.WriteLine("Sifreyi Girin");
            
            sifre = Console.ReadLine();
            
            string durum = (kullaniciAdi == "admin" && sifre == "12345") ? "Giris Basarili" : "Kullanici adi ve ya sifre hatali";
            
            Console.WriteLine(durum);
            */
        }

        class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int IzlenmeOranı { get; set; }
        }
    }
}
