using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan");
            Console.Write("Nota: ");
            penjualan.nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            penjualan.tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            penjualan.customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            penjualan.jenis = Console.ReadLine();
            Console.Write("Total Nota : ");
            penjualan.total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("Tekan ENTER untuk kembali ke menu awal");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            int i = 0;
            Console.WriteLine("Data Penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                i++;
                string jenis;
                if (penjualan.jenis == "T")
                {
                    jenis = "Tunai";
                }
                else if (penjualan.jenis == "K")
                {
                    jenis = "Kredit";
                }
                else
                {
                    jenis = "Salah Input";
                }
                Console.WriteLine(i + ", " + penjualan.nota + ", " + penjualan.tanggal + ", " + penjualan.customer + ", " + jenis + ", " + penjualan.total);
            }
            if (i < 1)
            {
                Console.WriteLine("Data Penjualan Kosong");
            }
            Console.WriteLine("Tekan ENTER untuk kembali ke menu awal");
            Console.ReadKey();
        }
    }
}