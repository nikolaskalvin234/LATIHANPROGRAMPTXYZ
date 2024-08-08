using System;

namespace Latihan_program_PT_XYZ
{
    class Program
    {
        static void Main(string[] args)
        {
             string NIP, Nama;
        int JumlahJamKerja;

        Console.Write("Masukkan NIP: ");
         NIP = Console.ReadLine();

        Console.Write("Masukkan Nama: ");
         Nama = Console.ReadLine();

        Console.Write("Masukkan Jumlah Jam Kerja: ");
        JumlahJamKerja = int.Parse(Console.ReadLine());

        double gaji = HitungGaji(NIP, Nama, JumlahJamKerja);
        double lembur = HitungLembur(JumlahJamKerja);
        double makan = HitungUangMakan(JumlahJamKerja);
        double transport = TransportLembur(JumlahJamKerja);

        double TotalGaji = gaji + lembur + makan + transport;

        Console.WriteLine(Nama +" "+ NIP);
        Console.WriteLine("Gaji Pokok untuk adalah: Rp. " + gaji);
        Console.WriteLine("Gaji Lembur untuk adalah: Rp. " + lembur);
        Console.WriteLine("Uang Makan adalah: Rp. " + makan );
        Console.WriteLine("Uang Transport adalah: Rp. " + transport );
        Console.WriteLine("Total Gaji adalah: Rp. " + TotalGaji );
    }

    static double HitungGaji(string NIP, string Nama, int JumlahJamKerja)
    {
        if (JumlahJamKerja <= 7) {
        double gajiPokok = JumlahJamKerja * 20000;  
        return gajiPokok;  
        }
        return 7*20000;
    }

    static double HitungLembur(int JumlahJamKerja)
    {
        if (JumlahJamKerja > 7)
        {
            double lembur = (JumlahJamKerja - 7) * 1.5 * 20000;
            return lembur;
        }
        return 0;
    }
    static double HitungUangMakan(int JumlahJamKerja)
    {
        if (JumlahJamKerja >= 8 )
        {
            double makan = 5000;
            return makan;
        }
        return 0;
    }

    static double TransportLembur(int JumlahJamKerja)
    {
        if (JumlahJamKerja >= 9)
        {
            double transport = 4000;
            return transport;
        }
        return 0;
    }
}
}