using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;

            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;

            // sayi1 ??? = cevap 30 çünkü değer tiptir stackte tutulur

            int[] sayilar1 = new int[] { 10, 20, 30 };

            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;

            sayilar2[0] = 999;

            //sayilar[0]=??? cevap= 999  çünkü referasn tiptir heapte bir alan tutulur ve bu alanın adresleri ile eşleşir burda sayilar1 artık sayilar2 nin adresini tutar 

        }
    }
}
