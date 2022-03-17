using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            float a, b, hasil;

            Console.WriteLine("Pilih Menu Kalkulator :");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.WriteLine("Input nomor menu [1,2,3,4] : ");
            pilihan = Console.ReadLine();
            Console.WriteLine();

            if (pilihan == "1")
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                hasil = a + b;
                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + (a + b));
            }

            else
                if (pilihan == "2")
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                hasil = a - b;
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + (a - b));
            }

            else
                if (pilihan == "3")
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                hasil = a * b;
                Console.WriteLine("Hasil Perkalian " + a + " X " + b + " = " + (a * b));
            }

            else
                if (pilihan == "4")
            {
                Console.WriteLine("Inputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                hasil = a / b;
                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + (a / b));
            }
            else
            {
                Console.WriteLine("(!) Maaf, Menu yang Anda Pilih Tidak Tersedia.");
            }

            Console.WriteLine();

            Console.WriteLine("Tekan Sembarang Key untuk Keluar.");
            Console.ReadKey();
        }
    }
}