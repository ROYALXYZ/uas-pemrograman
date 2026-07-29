using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Cat - class turunan Animal yang mengimplementasi IMoveable
    public class Cat : Animal, IMoveable
    {
        private bool apakahLiar;
        private string warnaKulit;

        public bool ApakahLiar 
        { 
            get { return apakahLiar; }
            set { apakahLiar = value; }
        }

        public string WarnaKulit 
        { 
            get { return warnaKulit; }
            set { warnaKulit = value; }
        }

        public Cat(string nama, int umur, string habitat, bool liar, string warna) 
            : base(nama, umur, habitat)
        {
            this.ApakahLiar = liar;
            this.WarnaKulit = warna;
        }

        public override void Makan()
        {
            Console.WriteLine($"{Nama} (Kucing) sedang makan ikan dan whiskas");
        }

        public override void Bersuara()
        {
            Console.WriteLine($"{Nama}: Meong meong! Miauw!");
        }

        public void Berjalan()
        {
            Console.WriteLine($"{Nama} berjalan dengan anggun dan tenang");
        }

        public void Berlari()
        {
            Console.WriteLine($"{Nama} berlari dengan lincah mengejar tikus");
        }

        public void Memanjat()
        {
            Console.WriteLine($"{Nama} memanjat pohon dengan cakar yang tajam");
        }

        public void Tidur()
        {
            Console.WriteLine($"{Nama} tidur dengan nyenyak selama 16 jam sehari");
        }

        public void CekStatus()
        {
            string status = ApakahLiar ? "liar" : "jinak";
            Console.WriteLine($"{Nama} adalah kucing {status} berwarna {WarnaKulit}");
        }
    }
}
