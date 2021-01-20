using System;
using System.Collections.Generic;
using System.Text;

namespace MethodDemo
{
    public class MusteriManager
    {
        private List<Musteri> musteri;
        public List<Musteri> Musteri
        {
            get
            {
                if (musteri == null)
                {
                    musteri = new List<Musteri>() 
                    {
                        new Musteri { Id = 1, Ad = "Ali", Soyad = "Al", MusteriNo = 1000000 },
                        new Musteri { Id = 2, Ad = "Veli", Soyad = "Bal", MusteriNo = 1000001 },
                        new Musteri { Id = 3, Ad = "Ayşe", Soyad = "Dal", MusteriNo = 1000002 }
                    };
                }

                return musteri;
            } 
            set 
            {
                musteri = value;
            } 
        }

        public MusteriManager()
        {
        }
        public void MusteriEkle(Musteri musteri)
        {
            Musteri.Add(musteri);
        }

        public List<Musteri> MusteriListele()
        {
            return Musteri;
        }

        public void MusteriSil(int Id) 
        {
            var musteri = Musteri.Find(x => x.Id == Id);
            Musteri.Remove(musteri);
        }
    }
}
