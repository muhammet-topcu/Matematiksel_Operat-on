using System;

namespace ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dısarıdan girilen iki sayının toplamıyla farkının birbirlerine bölümünden kalan kaçtır.
            #region
            Console.WriteLine("lütfen bir sayı giriniz.");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen ikinci bir sayı giriniz.");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayı1 + sayı2;
            int fark = sayı1 - sayı2;
            int mod = sayı1 % sayı2;
            Console.WriteLine("işlemin sonucu"+mod);
            #endregion 

        }

    }
}
