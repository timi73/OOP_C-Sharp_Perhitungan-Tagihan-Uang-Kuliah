using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Mahasiswa : Interface
    {
        public int Nim { get; set; }
        public String Name { get; set; }
        public String Progdi { get; set; }
        public int SksAmbil { get; set; }

        public void DataMahasiswa() {
            Console.WriteLine("=========================================");
            Console.WriteLine($"NIM             : {Nim}");
            Console.WriteLine($"Name            : {Name}");
            Console.WriteLine($"Program Studi   : {Progdi}");
            Console.WriteLine($"SKS Ambil       : {SksAmbil}");
            Console.WriteLine("=========================================");
        }
    }

}
