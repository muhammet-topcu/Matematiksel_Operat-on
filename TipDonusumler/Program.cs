using System;

namespace TipDonusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir veri tipindeki değişkeni diğer başka veri tipine çevirmek için ihtiyacımız olan
            //bu sınıfın adı "Convert"sınıfıdır.
            //bu alan için istisnai bi durum vardır:Dış dünyadan gösterilecek olan ne varsa bu
            //değer mutlaka metinsel(string) veri tipi olmalıdır.Dolayısıyla .Net bizlere stringe çevirmek
            //için kolaylık sunmuştur.

            int sayi = 25;
            Console.WriteLine(sayi.ToString());
            //unutulmaması gereken; bir noktada veriyi stringe çevirirseniz matematiksel özelliklerini 
            //kaybeder!!!!!

            string cevrilecekdeger = "123";
            int cevrilmısdeger = Convert.ToInt32(cevrilecekdeger);
            //convert.ToInt=> int'de çevirme işlemi başlatılır.

            byte cevrılmışbyte = Convert.ToByte(cevrilecekdeger);
            //convert.ToByte=> byte'a çevirir.

            short cevrilmisdeğer2 = Convert.ToInt16(cevrilecekdeger);

            long cevrılmısdeger3 = Convert.ToInt64(cevrilecekdeger);
            //long'a çevirir.
            float cevrılmısdeger4 = Convert.ToSingle(cevrilecekdeger);
            //floata çevirir.

            bool sonuc = true;
            int sonuc1 = Convert.ToInt32(sonuc);
            Console.WriteLine(sonuc1);
            string sonuc2 = Convert.ToString(sonuc);
            Console.WriteLine(sonuc2);

            //kullanıcının girdiği üç sayının ortalaması;
            #region
            Console.WriteLine("sayı gir");
            double sayı1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayı gir");
            double sayı2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayı gir");
            double sayı3 = Convert.ToDouble(Console.ReadLine());
            double ortalama = (sayı1 + sayı2 + sayı3) / 3;
            Console.WriteLine("ortalama değer\t:" + ortalama);
            #endregion

            //dışarıdan girmiş olduğu bir sayının 10 eksiğinin 20 fazlasının 2 ye bölümünden kalanının
            //karesini alın..
            #region
            Console.WriteLine("sayı gir");
            double sayı = Convert.ToDouble(Console.ReadLine());
            double sonucc = (sayı - 10 + 20) % 2;
            double karesi = sonucc * sonucc;
            Console.WriteLine(karesi);
            #endregion

            //Dışarıdan ürünün Id'si,ürünün adı,ürün fiyatı,ürünün cateId'sini alıp ekrana bastıran
            //programı getiriniz.

            #region
            Console.WriteLine("ürün ID giriniz.");
            int ürünId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ürün adı giriniz");
            string ürünAdı = Console.ReadLine();
            Console.WriteLine("ürün fiyatı");
            decimal ürünfiyat = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("CateId gir");
            int CateId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ürünün adı" + ürünAdı + "ID :\t" + ürünId
                                  + "kategori Id'si\t:" + CateId + "fiyatı" + ürünfiyat);
            #endregion

            //2. Yol  :
            Console.WriteLine($"Ürün Adı :{ürünAdı} Id :{ürünId} CatId :{CateId} Fiyat :{ürünfiyat}");


            //dışarıdan girilen iki sayının karelerinin toplamı ile karelerinin farkının toplamı kaçtır?
            #region
            Console.WriteLine("sayı giriniz");
            double sayıı1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayı giriniz");
            double sayıı2 = Convert.ToDouble(Console.ReadLine());
            double sonucc1 = (sayı1 * sayı1);
            double sonucc2 = (sayı1 * sayı1);
            double toplam = sonucc1 + sonucc2;
            double fark = sonucc1 - sonucc2;
            double sonuç = toplam + fark;
            Console.WriteLine(sonuç);
            #endregion
           
            //vize notunun %30'u final notunun da %70'ni alıp öğrencilerin not ortalamasını çıkaran 
            //bir program yazınız.
            #region
            Console.WriteLine("vize notu gir");
            double vizenot = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("final notu gir");
            double finalnot = Convert.ToDouble(Console.ReadLine());
            double ortalamaa = (vizenot * 30) / 100 + (finalnot * 70) / 100;
            Console.WriteLine("ortalama"+ortalamaa);
            #endregion


        }

    }

}  
