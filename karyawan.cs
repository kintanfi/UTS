using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2280
{
    public class karyawan
    {
        public karyawan()
        {

        }

        public karyawan(string nik, string nama, int gajibulanan)
        {
            if (gajibulanan < 0)
            {
                Console.WriteLine("Gaji harus diatas 0!");
            }
            else
            {
                nik = nik;
                nama = nama;
                gajibulanan = gajibulanan;
            }
        }

        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
    }
}
