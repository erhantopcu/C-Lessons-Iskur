using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_22
{
    internal class Program
    {
        public void Komisyon()
        {
            double komisyonMiktarı=0, toplam = 0;


            for (int i = 0; i < 5; i++)
            {
                try
                {

                    Console.WriteLine("lütfen   degeri giriniz");

                    double ürün = Convert.ToDouble(Console.ReadLine());

                    if (ürün < 60)
                    {
                        komisyonMiktarı = ürün / 100 * 3;
                        toplam += komisyonMiktarı;
                    }
                    else if (ürün>60)
                    {

                        komisyonMiktarı = ürün / 100 * 2;
                        toplam += komisyonMiktarı;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış");
                            i--;
                    }
                    Console.WriteLine("{0} Komisyon : {1} ", i + 1, komisyonMiktarı);
                    toplam += komisyonMiktarı;

                }

                catch (Exception)
                {
                    i--;
                    
                }

                Console.WriteLine(" ");

                Console.WriteLine("Toplam Komisyon : {0}", toplam);

                Console.ReadLine();
            }
        }

            static void Main(string[] args)
            {
                // bir komisyoncusattıgı mallardan fiyatı 60Tl kadar olanlardan yüzde 3 , daha fazla olanlardan ise yüzde 2 komisyon almaktadır.
                //klavyede teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve toplamı yazdıran program kodları

                Program prg = new Program();
                prg.Komisyon();
            }
        }
    }