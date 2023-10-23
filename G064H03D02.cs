using System.Data;
using System;

namespace G064H03D02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Parametresiz Metotlar
            Console.ReadLine(); //Parametresiz metot
            Dize1();
            Dize1();
            Dize2();
            Dize2();
            Dize3();
            Dize1();
            Dize2();
            Dize2();
            Dize3();
            #endregion

            #region Parametreli Metotlar

            Console.WriteLine("Merhaba");
            SelamVer("Serpil", "Yüksel");

            SelamVer("Mehmet", "Görmüş");

            #endregion

            #region Örnek

            //YasYazdir adında bir metot yazın.
            //Bu metot parametreden int türünde dogumYili bilgisini alsın.
            //Metot çağrıldığında yaş bilgisini ekrana yazsın.

            YasYazdir(2002); // 21
            YasYazdir(1995); // 28

            int yil = 2005;
            YasYazdir(yil); //18
            #endregion

            #region MyRegion

            UzaklikYaz(3, 5);
            UzaklikYaz(8, 10);

            int v = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());

            UzaklikYaz(v, t);

            #endregion

            SelamVer2("Tansu", "Kıtay", 7);

            #region Değer Döndüren Metotlar
            Random rnd = new Random();
            int sayi = rnd.Next(100); //Geriye değer döndüren bir metot (return'lü)

            int sonuc = Topla(5, 7);
            Console.WriteLine(sonuc);

            ToplaVoid(5, 8);

            int sonuc = ToplaReturn(5, 8);

            #endregion

            #region Hesap Makinesi
            HesapMakinesi();
            #endregion

            #region Method Overload
            Console.WriteLine("elma");
            Console.WriteLine();

            Topla(2, 3);
            Topla(2, 3, 5);
            Topla(2, 3, 5, 8);


            int sayi = Rastgele();
            sayi = Rastgele(10);
            sayi = Rastgele(5, 10);
            #endregion

            #region Görev 3 Gruplar
            GrupBelirle();
            #endregion

        }

        static void GrupBelirle()
        {
            string[] isimler = {
            "SELİN DİNÇMAN",
            "BERK AKOL",
            "AKIN TAŞLI",
            "İSMAİL EVREN ALIM",
            "NİHAT BERKAY KURALAY",
            "GÜL ALPAYCI",
            "AYCAN EROL",
            "ALPEREN ÖZBAYOĞLU",
            "ÖZGÜR SİNAN BEKİŞ",
            "FERİT ESER",
            };

            int sayac = 0;
            while (sayac < isimler.Length)
            {
                int index = Rastgele(isimler.Length);

                if (isimler[index] != "x")
                {
                    int grup = sayac / 2 + 1;
                    string isim = isimler[index];
                    Console.WriteLine(grup + ". grup: " + isim);
                    isimler[index] = "x";
                    sayac++;
                }

            }
        }

        static int Rastgele()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }

        static int Rastgele(int maxDeger)
        {
            Random rnd = new Random();
            return rnd.Next(maxDeger);
        }

        static int Rastgele(int minDeger, int maxDeger)
        {
            Random rnd = new Random();
            return rnd.Next(minDeger, maxDeger);
        }



        //Method overloading
        static int Topla(short sayi1, short sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }


        //Değer döndüren metotlar

        static void HesapMakinesi()
        {
            Console.Write("1. sayıyı girin: ");
            int s1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı girin: ");
            int s2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplama için 1'e basın");
            Console.WriteLine("Çıkartma için 2'ye basın");
            Console.WriteLine("Çarpma için 3'e basın");
            Console.WriteLine("Bölme için 4'e basın");
            Console.WriteLine();

            double sonuc = 0;


            while (true)
            {
                Console.Write("Seçiminiz: ");
                int secim = int.Parse(Console.ReadLine());

                if (secim < 1 || secim > 4)
                {
                    Console.WriteLine("Hatalı seçim yapıldı, tekrar deneyin!");
                    continue;
                }

                if (secim == 1)
                {
                    sonuc = Topla(s1, s2);
                }
                else if (secim == 2)
                {
                    sonuc = Cikar(s1, s2);
                }
                else if (secim == 3)
                {
                    sonuc = Carp(s1, s2);
                }
                else if (secim == 4)
                {
                    sonuc = Bol(s1, s2);
                }

                break;
            }



            Console.WriteLine("İşlem sonucu: " + sonuc);
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        static double Bol(int sayi1, int sayi2)
        {
            return (double)sayi1 / sayi2;
        }


        //Çıkartma, Çarpma, Bölme işlemlerini parametreden aldığı iki değer ile işlem yaparak döndüren metodları ayrı ayrı yazın.
        static void ToplaVoid(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;

            Console.WriteLine(toplam);
        }

        static int ToplaReturn(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;

            return toplam;
        }

        static int MaxBul(int[] dizi)
        {
            int max = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > max)
                    max = dizi[i];
            }

            return max;
        }


        static void SelamVer2(string isim, string soyisim, int saat)
        {
            //SelamVer2() metodunu yazin. isim, soyisim ve saat parametrelerini alsın.
            //Saat 12'den büyükse "İyi akşamlar Kemal Uysal" saat 12'den küçükse "Günaydın Kemal Uysal" yazsın.

            if (saat > 12)
            {
                Console.WriteLine("İyi akşamlar " + isim + " " + soyisim);
            }
            else
            {
                Console.WriteLine("Günaydın " + isim + " " + soyisim);
            }
        }


        //Parametreli metotlar
        static void SelamVer(string isim, string soyisim)
        {
            Console.WriteLine("Merhaba " + isim + " " + soyisim);
        }

        static void YasYazdir(int dogumYili)
        {
            int yas = 2023 - dogumYili;
            Console.WriteLine("Yaşınız: " + yas);
        }

        static void UzaklikYaz(int hiz, int zaman)
        {
            //UzaklikYaz adında bir metot yazalım
            //Bu metot parametreden hız ve zaman bilgilerini alsın
            //Bu metodu çağırdıktan sonra ekranda uzaklık bilgisi yazılmış olsun
            //uzaklık = hız * zaman

            int uzaklik = hiz * zaman;
            Console.WriteLine("Uzaklık: " + uzaklik);
        }

        //Parametresiz metotlar
        static void Dize1()
        {
            Console.WriteLine("Senden kalan tek anı bu    ");
            Console.WriteLine("Solgun sayfadaki güller    ");
            Console.WriteLine("Alır beni götürürler       ");
            Console.WriteLine("Sevgi dolu yıllara         ");
        }

        static void Dize2()
        {
            Console.WriteLine("Ne kadar güzeldi o günler  ");
            Console.WriteLine("Acının kucağındaki düşler  ");
            Console.WriteLine("O sıcak eğlenceli günler   ");
            Console.WriteLine("Şimdi arkadaş oldu bana    ");
        }

        static void Dize3()
        {
            Console.WriteLine("Senden kalan tek anı bu ahh");

        }

        //Metotu tanımlamak
        static void MerhabaDe()
        {
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Merhaba Dünya");
        }


    }
}