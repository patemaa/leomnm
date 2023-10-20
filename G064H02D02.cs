using System.Runtime.ConstrainedExecution;

namespace G064H02D02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Haftanın Sorusu Çözüm
            //Soru 7

            //1.Adım
            //Önceden sabit olarak girilmiş bir sayıyı,
            //kullanıcının kaç kerede tahmin ettiğini gösteren tahmin oyununun kodunu yazın.

            //2.Adım
            //Her sayı istediğinde kaçıncı sayıyı istediğini de yazsın.

            //3.Adım
            //Kullanıcı, sayıyı bulması için yönlendirilsin;
            //Sabit sayıdan daha büyük bir sayı girilmişse “Daha küçük bir sayı girin” yazsın.
            //Sabit sayıdan daha küçük bir sayı girilmişse “Daha büyük bir sayı girin” yazsın.


            //4.Adım
            //7 tahminde sayıyı bilemezse oyun bitsin.

            Random rastgeleSayiUretici = new Random();

            int sabit = rastgeleSayiUretici.Next(100);
            int tahmin;
            int sayac = 0;
            int hak = 7;

            do
            {
                sayac = sayac + 1;
                Console.Write(sayac + ". sayıyı girin: ");
                tahmin = int.Parse(Console.ReadLine());


                if (tahmin > sabit && sayac != hak)
                {
                    Console.WriteLine("Daha küçük bir sayı girin");
                }
                else if (tahmin < sabit && sayac != hak)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                }
                else if (tahmin == sabit)
                {
                    Console.WriteLine("Tebrikler! " + sayac + " tahminde doğru bildiniz.");
                }
                else if (sayac == 7)
                {
                    Console.WriteLine("Bilemediniz, sayı: " + sabit);
                }

            } while (tahmin != sabit && sayac < hak);


            #endregion


            #region For Döngüsü

            int sayac = 0;
            while (sayac < 10)
            {
                Console.WriteLine(sayac);
                sayac = sayac + 1;
            }

            Console.WriteLine("------------");


            for (int sayac2 = 0; sayac2 < 10; sayac2 = sayac2 + 1)
            {
                Console.WriteLine(sayac2);
            }

            int toplam = 0;
            for (int i = 1; i <= 10; i = i + 1)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);

            #endregion

            #region For Örnek - 1
            //20’den 1’e kadar olan sayıları alt alta ekrana yazdıran kodu yazın.

            for (int i = 20; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region For Örnek - 2
            //20’den 1’e kadar sayıları yan yana ve aralarına virgül işareti( , )
            //koyarak ekrana yazdıran kodu yazın. (En sonda veya en başta virgül işareti kalmasın.)

            for (int i = 20; i >= 1; i = i - 1)
            {
                Console.Write(i);
                if (i != 1)
                {
                    Console.Write(", ");
                }
            }
            #endregion

            #region For Örnek - 3
            //0 ile 20(dahil) arasındaki çift sayıları toplayarak sonucu ekranda gösteren
            //programın kodunu for döngüsü kullanarak yazın. (iki farklı yöntem kullanarak yapın)

            //1.yöntem
            int toplam = 0;

            for (int i = 0; i <= 20; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                }
            }
            Console.WriteLine(toplam);

            //2. yöntem
            toplam = 0;

            for (int i = 0; i <= 20; i = i + 2)
            {
                toplam = toplam + i;
            }

            Console.WriteLine(toplam);
            #endregion

            #region For Örnek - 4

            //1 + 4 + 9 + … +100 = X
            //Yukarıdaki ifadede yer alan  sayı örüntüsü anlaşılıp arada  bulunan ve görünmeyen boşluktaki sayıların da örnekte görüldüğü
            //gibi yatay ve aralarında artı(+ ) olacak şekilde, döngüler ile yazılması ve sonuna eşittir ifadesi( = ) konması sağlanır.
            //Görünen işlemin sonucu da “X” ifadesinin yerine yazılır.

            //İpucu
            //Önce 1’den 10’a kadar olan sayılar yan yana ekrana yazdırın.
            //Döngüdeki sayıların kareleri ekrana yazdırın.
            //Bu sayıları, aralarına artı(+ ) işareti koyularak yan yana yazdırın.
            //Ekranda yazdırdığınız değerleri bir değişkenin içine ekleyin.

            int toplam = 0;
            for (int i = 1; i <= 10; i = i + 1)
            {
                int karesi = i * i;

                toplam = toplam + karesi;

                Console.Write(karesi);
                if (i != 10)
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(" = " + toplam);
                }
            }
            #endregion


            #region Döngüler Örnek - 1
            //1.Adım
            //Kullanıcıdan kaç tane sayı gireceğini isteyin,
            //Kullanıcının yazdığı adet kadar sayı girişi alın,

            //2.Adım
            //Her sayı istendiğinde kaçıncı sayı girişi yapıldığı ekranda yazsın.

            //3.Adım
            //Bu sayılardan kaç tanesinin 50′den büyük olduğunu ekrana yazdırın, 
            //50’den büyük sayıların ortalamasını ekrana yazdırın.

            double ellidenBuyukSayiAdedi = 0;
            double ellidenBuyukToplam = 0;

            Console.Write("Kaç sayı gireceksiniz: ");
            int adet = int.Parse(Console.ReadLine());

            for (int i = 1; i <= adet; i = i + 1)
            {
                Console.Write(i + ". sayıyı girin: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi > 50)
                {
                    ellidenBuyukSayiAdedi = ellidenBuyukSayiAdedi + 1;
                    ellidenBuyukToplam = ellidenBuyukToplam + sayi;
                }

            }

            double ortalama = ellidenBuyukToplam / ellidenBuyukSayiAdedi;

            Console.WriteLine("50'den büyük sayı adedi: " + ellidenBuyukSayiAdedi);
            Console.WriteLine("50'den büyük sayıların ortalaması: " + ortalama);
            #endregion

            #region Döngüler Örnek - 2
            //Bir sayının kaç basamaklı olduğunu ekrana yazdıran kodu yazın.
            
            int sayi = 1213;
            int sayac = 0;
            while (sayi != 0)
            {
                sayi = sayi / 10;
                sayac = sayac + 1;
            }
            Console.WriteLine("Basamak sayısı: " + sayac);
            #endregion

            #region Döngüler Örnek - 3
            //Klavyeden girilen bir sayının kaç basamaklı olduğunu ekrana yazdıran kodu yazın.
            //Bu sayının rakamları toplamını ekrana yazdıran kodu yazın.

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;
            while (sayi != 0)
            {
                int birlerBasamagi = sayi % 10;
                toplam = toplam + birlerBasamagi;

                sayi = sayi / 10;
                sayac = sayac + 1;
            }
            Console.WriteLine("Basamak sayısı: " + sayac);
            Console.WriteLine("Rakamları toplamı: " + toplam);
            #endregion


            #region Bool değişken
            int a = 5;
            bool uctenBuyukMu = a > 3;

            bool b = false;

            if (uctenBuyukMu)
            {

            }
            bool devam = true;

            while (devam)
            {
                if (a == 3)
                {
                    devam = false;
                }
            }
            #endregion


            #region İç İçe Döngüler Örnek - 1
            //00000
            //00000
            //00000
            //00000
            //00000

            for (int satir = 1; satir <= 5; satir = satir + 1)
            {
                for (int sutun = 1; sutun <= 5; sutun = sutun + 1)
                {
                    Console.Write(0);
                }
                Console.WriteLine();
            }
            #endregion

            #region İç İçe Döngüler Örnek - 2
            // ----------
            //| 00000000 |
            //| 00000000 |
            //| 00000000 |
            //| 00000000 |
            //| 00000000 |
            //| 00000000 |
            //| 00000000 |
            //| 00000000 |
            // ----------

            for (int satir = 1; satir <= 10; satir = satir + 1)
            {
                for (int sutun = 1; sutun <= 10; sutun = sutun + 1)
                {
                    if (satir == 1 || satir == 10)
                    {
                        Console.Write("-");
                    }
                    else if (sutun == 1 || sutun == 10)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region İç İçe Döngüler Örnek - 3

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********


            for (int satir = 1; satir <= 10; satir = satir + 1)
            {
                for (int sutun = 1; sutun <= satir; sutun = sutun + 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion


        }
    }
}