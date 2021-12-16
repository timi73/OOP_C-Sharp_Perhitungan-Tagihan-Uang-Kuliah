using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Tagihan : Mahasiswa
    {
        int tSks, tSpp, tTotal;
        string[] progdi = { "Teknik Informatika", "Sistem Informasi", "Elektro" };
        int[] spp = { 900000, 750000, 1200000 };
        int[] sks = { 200000, 150000, 300000 };

        public void TagihanKeseluruhan()
        {
            CekProgdi(base.Progdi);
            Console.WriteLine("========================================");
            Console.WriteLine("          T A G I H A N");
            Console.WriteLine("========================================");
            Console.WriteLine($" {Nim} / {Name}");
            Console.WriteLine($" SPP Bayar       : {tSpp}");
            Console.WriteLine($" SKS Bayar       : {tSks}");
            Console.WriteLine($" Total Tagihan   : {tTotal}");
            Console.WriteLine("========================================");
        }
        public void CekProgdi(String prog) {
            for (int i = 0; i < progdi.Length; i++)
            {
                if (prog == progdi[i]) {
                    tSks = HitungSks(i);
                    tSpp = HitungSks(i);
                    tTotal = TotalHitung(i);
                }
            }
        }

        public int TotalHitung(int index)
        {
            int Total = HitungSks(index) + HitungSpp(index);
            return Total;
        }

        public int HitungSks(int index) {
            int total = SksAmbil * sks[index];
            return total;
        }

        public int HitungSpp(int index) {
            int total = spp[index];
            return total;
        }
    }
}
