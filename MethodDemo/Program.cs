using System;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager manager = new MusteriManager();
            var musteriler = manager.MusteriListele();
 
            foreach (var item in musteriler)
            {
                Console.WriteLine($"{item.Id} - {item.Ad} - {item.Soyad} - {item.MusteriNo}");
            }
            Console.WriteLine("----- Musteri Listelendi -------\n");

            

            Musteri yeniMusteri = new Musteri()
            {
                Id = 4,
                Ad = "Abbas",
                Soyad = "Yolcu",
                MusteriNo = 1000004
            };
            
            manager.MusteriEkle(yeniMusteri);

            foreach (var item in manager.MusteriListele())
            {
                Console.WriteLine($"{item.Id} - {item.Ad} - {item.Soyad} - {item.MusteriNo}");
            }

            Console.WriteLine("------ Musteri Eklendi ----------\n");




            manager.MusteriSil(1);

            foreach (var item in manager.MusteriListele())
            {
                Console.WriteLine($"{item.Id} - {item.Ad} - {item.Soyad} - {item.MusteriNo}");
            }

            Console.WriteLine("------ Musteri Silindi ----------");
            Console.ReadKey();
        }
    }
}
