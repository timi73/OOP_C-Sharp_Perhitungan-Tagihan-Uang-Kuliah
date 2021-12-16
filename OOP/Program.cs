using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        public static void AddMahasiswa() {
            Mahasiswa mhs = new Mahasiswa();

            do
            {
                try
                {
                    Console.Write("Masukkan NIM : ");
                    mhs.Nim = Console.ReadLine();
                    Console.Write("Masukkan Nama : ");
                    mhs.Name = Console.ReadLine();
                    Console.Write("Masukkan Progdi : ");
                    mhs.Progdi = Console.ReadLine();
                    Console.Write("Masukkan Jumlah SKS : ");
                    mhs.SksAmbil = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Inputan Salah !!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            } while (true);
            Console.Clear();
            menu();
        }

        public static void menu() {
            int pilihan;
            do
            {
                Console.WriteLine("------------Menu------------");
                Console.WriteLine("1. Masukkan Data Mahasiswa");
                Console.WriteLine("2. Lihat Data Mahasiswa");
                Console.WriteLine("3. Lihat Tagihan Mahasiswa");
                Console.WriteLine("-----------------------------");
                Console.Write("\nMasukkan Nomor Pilihan Anda : ");

                try
                {
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Inputan Anda Salah");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            } while (true);
            DecisionMenu(pilihan);
        }

        public static void DecisionMenu(int pilihan) {
            Mahasiswa mhs = new Mahasiswa();
            Tagihan tgh = new Tagihan();
            if (pilihan == 1)
            {
                Console.Clear();
                AddMahasiswa();
            } else if (pilihan == 2) {
                Console.Clear();
                mhs.DataMahasiswa();
                Console.ReadKey();
                Console.Clear();
                menu();
            }
            else if(pilihan == 3) {
                Console.Clear();
                tgh.TagihanKeseluruhan();
                Console.ReadKey();
                Console.Clear();
                menu();
            } else {
                Console.WriteLine("Nomor yang anda pilih tidak ada di menu");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
        }

    }
}
