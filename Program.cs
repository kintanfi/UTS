using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2280
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan kry1 = new karyawan();

            kry1.Nik = "18112222";
            kry1.Nama = "udin hehehe";
            kry1.GajiBulanan = 5000000;

            karyawan kry2 = new karyawan();

            kry2.Nik = "18110000";
            kry2.Nama = "jamaloedin aj";
            kry2.GajiBulanan = 4100000;

            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Asyiiik kenaikan gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));

            Console.ReadKey();
        }
    }
}
