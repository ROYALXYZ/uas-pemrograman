using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Animal - abstract base class dengan encapsulation (private fields + properties)
    public abstract class Animal
    {
        private string nama;
        private int umur;
        private string habitat;

        public string Nama 
        { 
            get { return nama; }
            set { nama = value; }
        }

        public int Umur 
        { 
            get { return umur; }
            set 
            { 
                if (value >= 0)
                    umur = value;
                else
                    Console.WriteLine("Error: Umur tidak boleh negatif!");
            }
        }

        public string Habitat 
        { 
            get { return habitat; }
            set { habitat = value; }
        }

        public Animal(string nama, int umur, string habitat)
        {
            this.Nama = nama;
            this.Umur = umur;
            this.Habitat = habitat;
        }

        // Abstract method - wajib diimplementasi child class
        public abstract void Makan();

        // Virtual method - bisa di-override child class
        public virtual void Bersuara()
        {
            Console.WriteLine("Hewan ini mengeluarkan suara...");
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Umur: {Umur} tahun");
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }
}
