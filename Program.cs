using System;

namespace mutlakKarealma
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Kaç Adet Sayı Girmek İstediğinizi Yazınız:");
            int Sayı = Convert.ToInt32(Console.ReadLine());
            int[] sayıListesi = new int[Sayı];

            Console.WriteLine($"lütfen{Sayı} tane sayı giriniz");
            for (int i = 0; i < Sayı; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz:", i + 1);
                sayıListesi[i] = Convert.ToInt32(Console.ReadLine());
            }
            int toplam = 0;
            int toplam1 = 0;

            for (int i = 0; i < sayıListesi.Length; i++)
            {
                if (sayıListesi[i] < 67)
                {
                    toplam = (67 - sayıListesi[i]) + toplam;
                }
                else
                {
                    int fark = 67 - sayıListesi[i];
                    int mutlak = Math.Abs(fark);
                    int sonuc = (mutlak * mutlak) + toplam1;
                }
                Console.WriteLine($" {toplam} {toplam1} ");

            }
        }
    }
}