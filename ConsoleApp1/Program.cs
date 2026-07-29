using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List dengan new object langsung
            List<Animal> daftarHewan = new List<Animal>
            {
                new Dog("Bulgogi", 5, "Kandang Anjing", "Golden Retriever"),
                new Cat("Popo", 3, "Kandang Kucing", false, "Putih"),
                new Bird("Mprit", 2, "Kandang Burung", 25.5, true)
            };

            // Loop dan panggil method
            foreach (Animal hewan in daftarHewan)
            {
                hewan.TampilkanInfo();
                hewan.Bersuara();
                hewan.Makan();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
