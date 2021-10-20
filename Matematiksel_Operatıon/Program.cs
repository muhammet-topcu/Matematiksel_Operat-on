using System;

namespace Matematiksel_Operatıon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematiksel işlemler");
            Console.WriteLine("--------------------------");

            //toplama işlemi :
            int Sayıbir = 100;
            int Sayıiki = 25;

            int toplam = Sayıbir + Sayıiki;
            Console.WriteLine("Toplama işleminin sonucu\t"+ toplam);
            Console.WriteLine("toplama işleminin sonucu\t"+(Sayıbir+Sayıiki));
            Console.WriteLine("toplamaz yanyana getirir\t"+Sayıbir+Sayıiki);

            Console.WriteLine("çıkarma işlemi");
            int fark = Sayıbir - Sayıiki;
            Console.WriteLine("fark"+fark);
            Console.WriteLine("fark"+(Sayıbir-Sayıiki));

            #region Çarpma
            int çarpım = Sayıbir * Sayıiki;
            Console.WriteLine("sonuç :"+çarpım);
            #endregion

            #region Bölme
            double bölüm = Sayıbir / Sayıiki;
            Console.WriteLine("bölüm:\t"+bölüm);
            #endregion

            #region ModAlma
            int mod = Sayıbir % Sayıiki;
            Console.WriteLine("mod değeri"+ mod);
            Console.WriteLine("mod"+(Sayıbir%Sayıiki));
            #endregion

            Console.WriteLine("---------------------------------------------------");
            int sayı = 15;
            Console.WriteLine("sayının ilk değeri\t:"+sayı);
            sayı = sayı + 1;
            Console.WriteLine("sayının bir üstü\t:"+sayı);
            sayı += 1;
            Console.WriteLine("sayının bir üstü\t:"+sayı);
            sayı++;
            Console.WriteLine("sayının bir üstü\t:"+sayı);

          
            Console.WriteLine("--------------------------------------------------------------");
          
            #region Sayıyı bir eksiltme
            Console.WriteLine("sayının şuanki değeri\t:"+sayı);
            sayı = sayı - 1;
            Console.WriteLine("sayının bir eksiği\t:"+sayı);
            sayı -= 1;
            Console.WriteLine("sayının bir eksiği"+sayı);
            sayı--;
            Console.WriteLine("sayının bir eksiği"+sayı);
            #endregion




        }
    }
}
