/*
 GÖKTUĞ HATİPOĞLU
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Console.Write("LİSTEYİ TEKRAR GÖZDEN GEÇİRMEK İSTİYOR MUSUNUZ?(E/H) ");
                    eh = Console.ReadLine();
                    if ((eh == "H") || (eh == "h")) bDevam = true;
            */
            /////////////
            //DEĞİŞKENLER
            int nDogumYili, nTus, nTaban, nYukseklik, nKisa, nUzun, nSyc5 = 0;
            bool bDevam;
            string eh;
            double dOrt5, dTop5 = 0;
            /////////////
            //BOOL ATAMASI
            bDevam = false;
            /////////////
            //WHILE BAŞLANGIÇ
            while (!bDevam)
            {
                ///////////// PROGRAM ÇAĞRI
                Console.Write("\n1- YAŞ HESAPLAMA\n2- ÜÇGENİN ALANINI BULMA\n3- DİKDÖRTGENİN ÇEVRESİNİ BULMA\n4- 5 SAYININ ORTALAMASINI ALMA\nLÜTFEN HANGİ PROGRAMI ÇAĞIRMAK İSTEDİĞİNİZİ TUŞLAYIN: ");
                nTus = int.Parse(Console.ReadLine());
                ///////////// 1 - YAŞ HESAPLAMA               
                if (nTus == 1) 
                {
                    Console.Write("LÜTFEN DOĞUM YILINIZI GİRİN!: ");
                    nDogumYili = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} YAŞINDASINIZ!", 2015 - nDogumYili);
                    Console.Write("LİSTEYİ TEKRAR GÖZDEN GEÇİRMEK İSTİYOR MUSUNUZ?(E/H) ");
                    eh = Console.ReadLine();
                    if ((eh == "H") || (eh == "h")) bDevam = true;
                }
                ///////////// 2 - ÜÇGENİN ALANINI BULMA
                else if (nTus == 2)
                {
                    Console.Write("LÜTFEN ÜÇGENİN TABAN UZUNLUĞUNU GİRİNİZ: ");
                    nTaban = int.Parse(Console.ReadLine());
                    Console.Write("LÜTFEN ÜÇGENİN YÜKSEKLİĞİNİ GİRİNİZ: ");
                    nYukseklik = int.Parse(Console.ReadLine());
                    Console.WriteLine("ÜÇGENİN ALANI = {0}", (nTaban * nYukseklik) / 2);
                    Console.Write("LİSTEYİ TEKRAR GÖZDEN GEÇİRMEK İSTİYOR MUSUNUZ?(E/H) ");
                    eh = Console.ReadLine();
                    if ((eh == "H") || (eh == "h")) bDevam = true;
                }
                ///////////// 3 - DİKDÖRTGENİN ÇEVRESİNİ BULMA
                else if (nTus == 3)
                {
                    Console.Write("LÜTFEN DİKDÖRTGENİN KISA KENARININ UZUNLUĞUNU GİRİNİZ: ");
                    nKisa = int.Parse(Console.ReadLine());
                    Console.Write("LÜTFEN DİKDÖRTGENİN UZUN KENARININ UZUNLUĞUNU GİRİNİZ: ");
                    nUzun = int.Parse(Console.ReadLine());
                    if ((nKisa == 0) || (nUzun == 0))
                    {
                        Console.Write("HATALI GİRDİNİZ!\nLİSTEYİ TEKRAR GÖZDEN GEÇİRMEK İSTİYOR MUSUNUZ?(E/H) ");
                        eh = Console.ReadLine();
                        if ((eh == "H") || (eh == "h")) bDevam = true;
                    }
                    else
                    {
                        Console.WriteLine("DİKDÖRTGENİN ÇEVRESİ = {0}", (nUzun + nKisa) * 2);
                        Console.Write("LİSTEYİ TEKRAR GÖZDEN GEÇİRMEK İSTİYOR MUSUNUZ?(E/H) ");
                        eh = Console.ReadLine();
                        if ((eh == "H") || (eh == "h")) bDevam = true;
                    }
                }
                ///////////// 4 - 5 SAYININ ORTALAMASINI ALMA
                else if (nTus == 4)
                {
                    for (nSyc5 = 0; nSyc5 < 5; nSyc5++)
                    {
                        Console.Write("LÜTFEN BİR SAYI GİRİNİZ: ");
                        dTop5 = dTop5 + int.Parse(Console.ReadLine());
                    }
                    dOrt5 = dTop5 / 5;
                    Console.WriteLine("ORTALAMA = {0}, SAYILARIN TOPLAMI = {1}",dOrt5, dTop5);
                    Console.Write("LİSTEYİ TEKRAR GÖZDEN GEÇİRMEK İSTİYOR MUSUNUZ?(E/H) ");
                    eh = Console.ReadLine();
                    if ((eh == "H") || (eh == "h")) bDevam = true;
                }
                //////////// 5- GİRİLEN SAYININ FAKTÖRİYELİ
            }
        }
    }
}
