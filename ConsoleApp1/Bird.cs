using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Bird - class turunan Animal yang mengimplementasi IMoveable
    public class Bird : Animal, IMoveable
    {
        private double rentangSayap;
        private bool bisaTerbang;

        public double RentangSayap 
        { 
            get { return rentangSayap; }
            set 
            { 
                if (value > 0)
                    rentangSayap = value;
                else
                    Console.WriteLine("Error: Rentang sayap harus positif!");
            }
        }

        public bool BisaTerbang 
        { 
            get { return bisaTerbang; }
            set { bisaTerbang = value; }
        }

        public Bird(string nama, int umur, string habitat, double rentang, bool terbang) 
            : base(nama, umur, habitat)
        {
            this.RentangSayap = rentang;
            this.BisaTerbang = terbang;
        }

        public override void Makan()
        {
            Console.WriteLine($"{Nama} (Burung) sedang makan biji-bijian dan serangga");
        }

        public override void Bersuara()
        {
            Console.WriteLine($"{Nama}: Cuit cuit cuit! Kicau kicau!");
        }

        public void Berjalan()
        {
            Console.WriteLine($"{Nama} berjalan dengan melompat-lompat kecil");
        }

        public void Berlari()
        {
            Console.WriteLine($"{Nama} berlari sambil mengepakkan sayap");
        }

        public void Terbang()
        {
            if (BisaTerbang)
            {
                Console.WriteLine($"{Nama} terbang tinggi dengan rentang sayap {RentangSayap} cm");
            }
            else
            {
                Console.WriteLine($"{Nama} tidak bisa terbang (contoh: Pinguin, Ayam)");
            }
        }

        public void BersarangDiPohon()
        {
            Console.WriteLine($"{Nama} membuat sarang di pohon untuk bertelur");
        }

        public void CekKemampuanTerbang()
        {
            string status = BisaTerbang ? "bisa terbang" : "tidak bisa terbang";
            Console.WriteLine($"{Nama} {status} dengan rentang sayap {RentangSayap} cm");
        }
    }
}
