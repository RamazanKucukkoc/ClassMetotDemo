using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
   public class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Müsteri Ekleme Gerçekleşti Id :"+musteri.Id+" Adı :"+ 
                musteri.Ad+" :Soyadı :"+ musteri.Soyad);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müsteri Listeleme Gerçekleşti Id :" + musteri.Id + " Adı :" +
                 musteri.Ad + " :Soyadı :" + musteri.Soyad);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silme Gerçekleşti Id :" + musteri.Id + " Adı :" +
                musteri.Ad + " :Soyadı :" + musteri.Soyad);
        }



    }
}
