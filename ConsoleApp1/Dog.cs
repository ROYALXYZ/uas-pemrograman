using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Dog - class turunan Animal yang mengimplementasi IMoveable dan ITrainable
    public class Dog : Animal, IMoveable, ITrainable
    {
        private string ras;
        private List<string> daftarTrik;

        public string Ras 
        { 
            get { return ras; }
            set { ras = value; }
        }

        public Dog(string nama, int umur, string habitat, string ras) 
            : base(nama, umur, habitat)
        {
            this.Ras = ras;
            this.daftarTrik = new List<string>();
        }

        public override void Makan()
        {
            Console.WriteLine($"{Nama} (Anjing) sedang makan daging dan dog food");
        }

        public override void Bersuara()
        {
            Console.WriteLine($"{Nama}: Guk guk guk! Woof woof!");
        }

        public void Berjalan()
        {
            Console.WriteLine($"{Nama} berjalan dengan 4 kaki");
        }

        public void Berlari()
        {
            Console.WriteLine($"{Nama} berlari dengan cepat mengejar bola");
        }

        public void Berlatih(string trik)
        {
            daftarTrik.Add(trik);
            Console.WriteLine($"{Nama} sedang berlatih trik baru: {trik}");
        }

        public void TampilkanTrik()
        {
            Console.WriteLine($"\nTrik yang dikuasai {Nama}:");
            if (daftarTrik.Count > 0)
            {
                foreach (string trik in daftarTrik)
                {
                    Console.WriteLine($"- {trik}");
                }
            }
            else
            {
                Console.WriteLine("- Belum ada trik yang dipelajari");
            }
        }

        public void MenjagaRumah()
        {
            Console.WriteLine($"{Nama} menjaga rumah dengan setia. Guk guk!");
        }
    }
}
