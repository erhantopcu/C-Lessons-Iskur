using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        #region Metot
        /*Belirli bir işlemi yerine getirmek için yazılam ve istenilen yerde
         * çağırılan kod bloklarıdır.
         * ErişimBelirleyici Niteleyici(varsa) DonusTipi MetotAdı(varsa parametre)
         * {
         * Metotta çağırılacak kod blokları
         * }
         * 
         */
        //private void Metot()
        // {
        //     Console.WriteLine("metot");
        // }
        // private void Ekle(int a, int c)
        // {
        //     int b = 5;
        //     int toplam = a + b + c;
        //     Console.WriteLine(toplam);
        // }
        // private int Toplama()
        // {
        //     int a = 5;
        //     int b = 6;
        //     int sonuc = a + b;
        //     return a + b;

        // }
        ///***************************************************************************************************************
        ////private int Cevre(int uzunlukdeger, int genislikdeger)
        ////{
        ////    int toplam = 2*(genislikdeger+uzunlukdeger); 

        ////    return toplam;
        ////}
        ///***************************************************************************************************************
        ////private void HesapMakinası(int sayi1, int sayi2)
        ////{

        ////    int toplam = sayi1 + sayi2;
        ////    int cikarma = sayi1 - sayi2;
        ////    int carpma = sayi1 * sayi2;
        ////    int bolme = sayi1 / sayi2;

        ////    Console.WriteLine("toplam "+ toplam);
        ////    Console.WriteLine("cıkarma " + cikarma);
        ////    Console.WriteLine("carpma "+ carpma);  
        ////    Console.WriteLine("bolme "+ bolme);   
        ////}
        //////***************************************************************************************************************
        //
        //// void HesapMakinası()
        ////{
        ////    int sayi1 = 2;
        ////    int sayi2 = 3;
        ////    int toplam = sayi1 + sayi2;
        ////    int cikarma = sayi1 - sayi2;
        ////    int carpma = sayi1 * sayi2;
        ////    int bolme = sayi1 / sayi2;

        ////    Console.WriteLine("toplam " + toplam);
        ////    Console.WriteLine("cıkarma " + cikarma);
        ////    Console.WriteLine("carpma " + carpma);
        ////    Console.WriteLine("bolme " + bolme);
        ////}
        ////void HesapMakinası1()
        ////{

        ////}
        ////void HesapMakinası2()
        ////{

        ////}
        ////void HesapMakinası3()
        ////{

        ////}
        /////////***************************************************************************************************************
        // ivme - süre - ilkhız - son hız (s-i)/süre


        ////private void HesapMakinası(double ilkhiz, double sonhiz, double sure)
        ////{

        ////    double ivme = (sonhiz - ilkhiz) / sure;

        ////    Console.WriteLine("ivme: " + ivme);
        //}
        //static void Main(string[] args)
        //{
        ///***************************************************************************************************************
        //Program mrg = new Program();

        //mrg.Toplama();
        //Console.Write(mrg.Toplama());
        //Console.ReadLine();
        ///***************************************************************************************************************
        ////int uzunlukdeger = 0;
        ////int genislikdeger = 0;
        ////Console.WriteLine("Çevre Hesaplama\n");

        ////Console.Write("Uzunluk girin: ");
        ////uzunlukdeger = Convert.ToInt32(Console.ReadLine());

        ////Console.Write("Genislik girin: ");
        ////genislikdeger = Convert.ToInt32(Console.ReadLine());

        ////Program hesap = new Program();
        ////Console.WriteLine("Çevre" + hesap.Cevre(uzunlukdeger,genislikdeger));
        ////Console.ReadLine();
        ///***************************************************************************************************************
        ////Console.Write("sayi1 girin: ");
        ////int sayi1 = Convert.ToInt32(Console.ReadLine());

        ////Console.Write("sayi2 girin: ");
        ////int sayi2 = Convert.ToInt32(Console.ReadLine());

        ////Program prg = new Program();
        ////prg.HesapMakinası(sayi1, sayi2);

        ////Console.ReadLine();
        ///***************************************************************************************************************

        ////Program prg = new Program();
        ////prg.HesapMakinası();

        ////Console.ReadLine();
        //////***************************************************************************************************************
        ///
        ////Console.Write("ilkhız girin: ");
        ////double sonhız = Convert.ToInt32(Console.ReadLine());

        ////Console.Write("sonhız girin: ");
        ////double ilkhız = Convert.ToInt32(Console.ReadLine());

        ////Console.Write("sure girin: ");
        ////double sure = Convert.ToInt32(Console.ReadLine());

        ////Program prg = new Program();
        ////prg.HesapMakinası(sonhız, ilkhız, sure);

        ////Console.ReadLine();
        //}

        #endregion

        #region ConsolKey
        //static void Main(string[] args)
        //{
        //    Program pgr = new Program();
        //    //ConsolKey-KeyChar(Tuşlar ile işlem yapma)
        //    System.ConsoleKeyInfo gelentus = Console.ReadKey(true);

        //    if (gelentus.Key == ConsoleKey.Z)
        //    {
        //        pgr.deneme();
        //    }
        //    else
        //    {
        //        Console.WriteLine("yanlış tuş");
        //    }
        //    Console.ReadLine();
        //}
        //private void deneme()
        //{
        //    Console.WriteLine("Z basıldı");
        //}
        #endregion

        /*Public : tüm classlarda çağrılıp, kullanılabilir.
         * Global bir metot diye düşünülebilir.
         * Private : sadece bulundugu class da cagırılır.
         * Static: bulundugu classda metot adı le direkt cagırılır.
         * public-static: genel bir değişken tanımlaması olmasına rağmen başka classa gidemez sadece kendi clasında class
         * nesnesi tanımlanmadan kullanılabilir.
         * Private-static : prive calss özel tanımlama ve static ise classa ait değişken oldugundan dısarıdan cagırıldıgında erişilemez.
         */
         
        static void Main(string[] args)
        {

        }
    }
}


