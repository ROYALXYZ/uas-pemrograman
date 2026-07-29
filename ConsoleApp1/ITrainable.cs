using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Interface untuk hewan yang bisa dilatih
    public interface ITrainable
    {
        void Berlatih(string trik);
        void TampilkanTrik();
    }
}
