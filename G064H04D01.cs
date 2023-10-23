using System.Diagnostics.Metrics;

namespace G064H04D01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }

        #region String Metotları
        static void ToUpper()
        {
            string s = "Siliconmade";
            string a = s.ToUpper();
            Console.WriteLine(a);
        }

        static void ToLower()
        {
            string s = "Siliconmade";
            string a = s.ToLower();
            Console.WriteLine(a);
        }

        static void Substring()
        {
            string s = "Siliconmade";
            string a;
            Console.WriteLine(s);

            a = s.Substring(7);
            Console.WriteLine(a);

            a = s.Substring(3, 4);
            Console.WriteLine(a);

            a = s.Substring(0, 7);
            Console.WriteLine(a);

        }

        static void Ornek1()
        {
            string metin = "merHaBa";

            string c = metin.ToUpper().Substring(2).ToLower() + "zzzzz";

        }

        static string IlkHarfiBuyut(string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }

        static void IndexOf()
        {
            string s = "Siliconmade";
            int index = 0;
            index = s.IndexOf('l'); 
            index = s.IndexOf('x'); 
            index = s.IndexOf('i'); 
            index = s.LastIndexOf('i'); 

            index = s.IndexOf("made"); 
            string s2 = s.Substring(index);

            Console.WriteLine(index);
            Console.WriteLine(s2);
        }

        static void Trim()
        {
            string s = "         siliconmade       ";
            string a = s.Trim();

            Console.WriteLine(s);
            Console.WriteLine(a);

            s = "*********siliconmade********";
            a = s.Trim('*');

            Console.WriteLine(s);
            Console.WriteLine(a);


            s = "       *********siliconmade********        ";
            a = s.Trim().Trim('*');

            Console.WriteLine(s);
            Console.WriteLine(a);
        }

        static void Replace()
        {
            string s = "siliconmade";
            string a = s.Replace("made", "X");

            Console.WriteLine(s);
            Console.WriteLine(s);
        }

        static void Split()
        {
            string url = "www.siliconmade.com";
            Console.WriteLine(url);

            string[] elemanlar = url.Split(".");

            for (int i = 0; i < elemanlar.Length; i++)
            {
                Console.WriteLine(elemanlar[i]);
            }

        }

        static void SplitOrnek()
        {
            //Klavyeden girilen bir metnin kelimelerini satır satır ekrana yazdıran kodu yazın.

            //Yazdırdığınız kelimeleri, (önceki soruda hazırladığınız metodu kullanarak) 
            //ilk harfini büyük diğer harfini küçük olacak şekilde, yan yana ekrana yazdırın.

            Console.Write("Metin girin: ");
            string metin2 = Console.ReadLine();

            string[] kelimeler = metin2.Split(" ");

            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine(IlkHarfiBuyut(kelimeler[i]));
            }
        }
        #endregion

        #region Math Metotları
        static void MathMetotlari()
        {
            int a = 4;
            int b = 8;
            float c = 15.3f;
            double d;

            d = Math.Max(a, b); 
            d = Math.Min(a, b); 
            Console.WriteLine(d);

            d = Math.Ceiling(c); 
            d = Math.Ceiling(7.4); 

            d = Math.Floor(c);
            d = Math.Floor(7.4); 

            d = Math.Round(c); 
            d = Math.Round(7.4); 
            d = Math.Round(7.5); 
            d = Math.Round(7.6); 


            d = Math.Abs(a); 
            d = Math.Abs(-15); 

            d = Math.Pow(a, b); 
            d = Math.Pow(2, 3); 

            d = Math.Sqrt(a); 
            d = Math.Sqrt(4); 


            d = Math.Pow(2, 3); 
            Console.WriteLine(d);
        }
        #endregion

        #region Char veri tipi
        static void CharVeriTipi()
        {
            string isim = "kemal";

            char h1 = 'k';

            char[] isim2 = { 'k', 'e', 'm', 'a', 'l' };


            char[] isim3 = new char[5];

            isim3[0] = 'k';
            isim3[1] = 'e';
            isim3[2] = 'm';
            isim3[3] = 'a';
            isim3[4] = 'l';


            Console.WriteLine(isim);
            Console.WriteLine(isim2);
            Console.WriteLine(isim3);


            Console.WriteLine(h1);
            Console.WriteLine((int)h1);

            //İsminizi, her satırda 1 harf olacak şekilde ekrana yazdırın.

            string isim4 = "ali kemal";

            for (int i = 0; i < isim4.Length; i++)
            {
                Console.WriteLine(isim4[i]);
            }

            char c1 = 'ü';
            Console.WriteLine((int)c1);

            //Bir değişken içindeki isminizi, for döngüsü kullanarak tersten ekrana yazdırın
            for (int i = isim4.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(isim4[i]);
                }
        }
        #endregion

        #region Görev 3.1 Çözümler
        static void Soru3()
        {
            //20 elemanlı bir tam sayı dizisine 7’den itibaren 7’nin katlarını ekleyen ve bu sayıları yan yana ekrana yazdıran void metodu yazın kodunu yazın.

            int[] dizi = new int[20];

            int a = 7;

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = a;
                a += 7;
            }


            DiziYazdir(dizi);

        }

        static void Soru4()
        {
            //15 elemanlı bir diziyi en küçük asal sayıdan itibaren, asal sayılar ile dolduran kodu yazın.
            int[] asalSayilar = new int[15];

            int index = 0;
            int sayi = 0;

            while (index < asalSayilar.Length)
            {
                bool asalMi = AsalMi(sayi);
                if (asalMi) //(sonuc == true)
                {
                    asalSayilar[index] = sayi;
                    index++;
                }

                sayi++;
            }

            DiziYazdir(asalSayilar);

        }

        static void Soru5()
        {
            //Rastgele değerde 10 elemanlı bir sayı dizisi oluşturun.Bu dizi içerisindeki tek sayıları başka bir diziye ekleyip, çift sayıları da bambaşka bir diziye ekleyen programı yazın.
            //Bir dizinin elemanını aralarına boşluk koyarak yan yana yazdıran metodu yazın.Bu metot ile bu sorudaki 3 diziyi de ekrana yazdırın.

            int[] rastgeleSayilar = RastgeleSayiDizisiOlustur(10);

            int[] tekSayilar = new int[TekCiftSayiAdediGetir(rastgeleSayilar, "tek")];
            int[] ciftSayilar = new int[TekCiftSayiAdediGetir(rastgeleSayilar, "cift")];

            int tekIndex = 0;
            int ciftIndex = 0;

            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                if (rastgeleSayilar[i] % 2 == 1)
                {
                    tekSayilar[tekIndex] = rastgeleSayilar[i];
                    tekIndex++;
                }
                else
                {
                    ciftSayilar[ciftIndex] = rastgeleSayilar[i];
                    ciftIndex++;
                }
            }

            Console.WriteLine("Rastgele Sayılar: ");
            DiziYazdir(rastgeleSayilar);

            Console.WriteLine("Tek Sayılar: ");
            DiziYazdir(tekSayilar);

            Console.WriteLine("Çift Sayılar: ");
            DiziYazdir(ciftSayilar);


        }


        static int TekCiftSayiAdediGetir(int[] dizi, string tip)
        {
            int tekSayiAdedi = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 1)
                {
                    tekSayiAdedi++;
                }
            }

            if (tip == "tek")
            {
                return tekSayiAdedi;
            }
            else
            {
                return dizi.Length - tekSayiAdedi;
            }
        }

        static int[] RastgeleSayiDizisiOlustur(int uzunluk)
        {
            int[] rastgeleDizi = new int[uzunluk];

            Random r = new Random();

            for (int i = 0; i < rastgeleDizi.Length; i++)
            {
                rastgeleDizi[i] = r.Next(10, 100);
            }

            return rastgeleDizi;
        }

        static bool AsalMi(int sayi)
        {
            bool asalMi = true;

            if (sayi <= 1)
            {
                asalMi = false;
                return false;
            }

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    return false;
                }
            }

            return asalMi;
            return true;
        }

        static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();
        }

        static void DiziYazdir(string[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();
        }

        #endregion

    }
}