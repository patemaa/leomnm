namespace G064H02D01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Görev Soru 1
            Console.Write("Fiyatını girin: ");
            double fiyat = double.Parse(Console.ReadLine());

            Console.Write("Kar oranını girin: ");
            double karOrani = double.Parse(Console.ReadLine());

            double satisFiyati = fiyat + fiyat * karOrani / 100;

            Console.WriteLine("Satış fiyatı: " + satisFiyati);
            #endregion

            #region Görev Soru 5
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            int kareFarki = x * x - y * y;

            Console.WriteLine("X ve Y değerlerinin kare farkı: " + kareFarki);
            #endregion

            #region Görev Soru 6
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            int sonuc = 2 * b - 4 * a * c;

            Console.WriteLine("2b - 4ac = " + sonuc);
            #endregion

            #region Görev Soru 7

            Console.Write("Doğum yılı: ");
            int dogumYili = int.Parse(Console.ReadLine());

            int yil = 2023;

            int yas = yil - dogumYili;

            if (yas > 17)
            {
                Console.WriteLine("Ehliyet alabilir");
            }
            else
            {
                Console.WriteLine("Ehilyet alamaz");
            }

            #endregion

            #region If Tekrar
            //Kullanıcıdan bir not alan kodu yazın. Bu not;
            //0 - 49 arasındaysa “Başarısız”, 
            //50 - 64 arasındaysa “Orta”, 
            //65 - 84 arasındaysa “İyi”, 
            //85 - 100 arasındaysa “Çok iyi” yazan programın kodunu yazın.
            //Not bu aralıkta değilse program "Hatalı giriş yapıldı" mesajını versin.

            

            //1. yöntem
            Console.Write("Not girin: ");
            int not = int.Parse(Console.ReadLine());

            if (not >= 0 && not <= 49)
            {
                Console.WriteLine("Başarısız");
            }
            else if (not >= 50 && not <= 64)
            {
                Console.WriteLine("Orta");
            }
            else if (not >= 65 && not <= 84)
            {
                Console.WriteLine("İyi");
            }
            else if (not >= 85 && not <= 100)
            {
                Console.WriteLine("Çok iyi");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yapıldı");
            }


            //2. Yöntem

            //Klavyenizde && tuşu çalışmıyor, sadece || tuşu çalışıyor olsaydı bu soruyu nasıl çözmek gerekirdi?

            //Console.Write("Not girin: ");
            //int not = int.Parse(Console.ReadLine());


            if (not < 0 || not > 100)
            {
                Console.WriteLine("Hatalı giriş yapıldı");
            }
            else if (not >= 85)
            {
                Console.WriteLine("Çok iyi");
            }
            else if (not >= 65)
            {
                Console.WriteLine("İyi");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Orta");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            #endregion

            #region While Döngüsü
            int sayi = 0;

            while (sayi < 20)
            {
                Console.WriteLine("Merhaba Halil");

                sayi = sayi + 1;
            }
            #endregion

            #region While - Soru 1
            //Soru 1
            //10’dan 1’e kadar olan sayıları alt alta ekrana yazdıran kodu yazın.

            int sayac = 10;

            while (sayac > 0)
            {
                Console.WriteLine(sayac);
                sayac = sayac - 1;
            }
            #endregion

            #region While - Soru 2
            //Soru 2
            //10’dan 1’e kadar sayıları yan yana ve aralarına boşluk koyarak ekrana yazdıran kodunu yazın.

            int sayac = 10;

            while (sayac > 0)
            {
                Console.Write(sayac + " ");
                sayac = sayac - 1;
            }
            #endregion

            #region While - Soru 3
            //Soru 3
            //0 ile 100 arasındaki sayıları while döngüsü ile toplayan ve bu değeri ekrana yazdıran kodu yazın.

            int sayac = 0;
            int toplam = 0;

            while (sayac <= 100)
            {
                toplam = toplam + sayac;
                sayac = sayac + 1;
            }
            Console.WriteLine(toplam);
            #endregion

            #region While - Soru 4
            //Soru 4
            //0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren kodu while döngüsü
            //kullanarak yazın. (2 farklı yöntem kullanarak ayrı ayrı )

            //1.Çözüm
            int sayac = 0;
            int toplam = 0;

            while (sayac <= 100)
            {
                if (sayac % 2 == 1)
                {
                    toplam = toplam + sayac;
                }

                sayac = sayac + 1;
            }

            Console.WriteLine(toplam);

            //2.Yöntem
            sayac = 1;
            toplam = 0;

            while (sayac <= 100)
            {
                toplam = toplam + sayac;
                sayac = sayac + 2;
            }
            Console.WriteLine(toplam);
            #endregion

            #region Faktöriyel Örnek

            //5! = 5 * 4 * 3 * 2 * 1 = 120

            Console.Write("Bir sayi girin: ");

            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;


            while (sayi >= 1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi = sayi - 1;
            }
            Console.WriteLine(faktoriyel);

            #endregion

            #region While - Soru 5
            //Program kullanıcıdan sürekli sayı girişi isteyecektir.
            //Kullanıcının girdiği sayı 0(Sıfır) olana kadar tekrar tekrar
            //kullanıcıdan sayı girişi alan programın kodunu while döngüsü kullanarak yazın.

            int sayi;

            Console.Write("Sayi girin: ");
            sayi = int.Parse(Console.ReadLine());

            while (sayi != 0)
            {
                Console.Write("Sayi girin: ");
                sayi = int.Parse(Console.ReadLine());

            }
            #endregion

            #region Do-While Döngüsü
            //Do - while döngüsü

            int sayi;
            do
            {
                Console.Write("Sayi girin: ");
                sayi = int.Parse(Console.ReadLine());

            } while (sayi != 0);
            #endregion

            #region Do-While Soru 1
            //Soru 6
            //Program kullanıcıdan sürekli sayı girişi isteyecektir.

            //1.adım
            //Kullanıcının girdiği sayıların toplamı 100'den küçük olduğu sürece 
            //kullanıcıdan sayı istemeye devam eden kodu do -while döngüsü kullanarak yazın
            //2.adım
            //Sonunda sayıların toplamını ekrana yazdırın.
            //3.adım
            //Sonunda kaç deneme yapıldığını ekrana yazdırın.
            //4.adım
            //Her sayı girişinde kaçıncı sayı istendiğini yazsın.Örnek: 1.Sayıyı girin

            int sayi;
            int toplam = 0;
            int sayac = 0;
            do
            {
                sayac = sayac + 1;
                Console.Write(sayac + ".Sayıyı girin: ");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;

            } while (toplam < 100);

            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Girilen sayı adedi : " + sayac);
            #endregion
        }
    }
}