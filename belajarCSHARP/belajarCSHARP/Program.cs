using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belajarCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Nama karyawan :");
            string karyawan = Console.ReadLine();
        
            Console.WriteLine("isi jumlah lembur berdasarkan hari (1-10) :");

            int lembur = int.Parse(Console.ReadLine());

            int bonus = 25000 * lembur;
            int gaji = 4000000 + bonus;

            Console.WriteLine();
            Console.WriteLine("Nama Karyawan : " + karyawan);
            Console.WriteLine("Jumlah lembur : " + lembur);
            Console.WriteLine("Jumlah Gaji + Lembur : " + gaji);

            Console.WriteLine();

            Console.Write("Press Any key to Continue!");
            Console.ReadKey(true);
        }
    }
}
