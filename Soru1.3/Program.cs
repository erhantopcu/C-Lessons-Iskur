using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1._3
{
    internal class Program
    {
        public void Islem()
        {
            int satır;      //kullanıcı tarafından girilen satır ve sutun
            int sutun;

            Console.WriteLine("sutun");
            sutun = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("satır");             //kullanıcı tarafından girilen degerler
            satır = Convert.ToInt16(Console.ReadLine());

            int[,] dizi = new int[satır, sutun]; //dizi tanımla


            for (int i = 0; i < satır; i++) //satır sutun degeri bellekte tutuyoruz
            {
                for (int j = 0; j < sutun; j++)
                {

                    try
                    {
                        Console.WriteLine("satır {0}x{1} sutun", i+1 , j+1 );
                        dizi[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hatali giriş");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < satır; i++) // bellekte bulunan degerleri ekrana yazdırıyoruz
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                try
                {
                    dizi[satır, sutun] = satır + sutun;
                    Console.WriteLine(" " + dizi[satır, sutun]);
                }
             
                 catch (Exception ex)
                {
                    Console.WriteLine("Hatali giriş");
                }
            }

                Console.ReadLine();
        }
            static void Main(string[] args)
            {
             Program prg = new Program();
            prg.Islem();
            }
        }
    }
