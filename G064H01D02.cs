namespace G064H01D02
{
    internal class Program
    {
        static void Main()
        {
            #region Değişken Belirleme
            
            string mesaj = "Merhaba G064";

            //Console.WriteLine("elma");
            Console.WriteLine(mesaj);

            double sayi1 = 10;
            double sayi2 = 17;
            double sonuc; 

            sonuc = sayi1 + sayi2; 
            
            Console.WriteLine(sonuc);

            sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);

            double sonuc2 = sayi1 * sayi2;
            Console.WriteLine(sonuc2);

            int tamSayi = 7 + 4; 

            int sayi3;

            sayi3 = 13;
            sayi3 = 12 - 3;

            int sayi4 = 13;

            sayi4 = 25;

            Console.WriteLine(sayi4);
            #endregion

            #region Örnek 1
            //"yil" adında bir değişken oluşturun ve değerine bulunduğumuz yılı atayın,            
            //"dogumYili" adında bir değişken oluşturun, değerine doğum yılınızı atayın.
            //"yas" adında bir değişkende bu verilerle yaşınızı hesaplatın.
            //"yas" değişkenini ekrana yazdırın.



            int yil = 2023;
            int dogumYili = 2002;
            int yas = yil - dogumYili;
            Console.WriteLine(yas);

            if (yas >= 25)
            {
                Console.WriteLine("Kişi kamyon ehliyeti alabilir");
            }
            else if (yas >= 18)
            {
                Console.WriteLine("Kişi araba ehliyeti alabilir");
            }
            else if (yas == 16)
            {
                Console.WriteLine("Kişi motor ehliyeti alabilir");
            }
            else
            {
                Console.WriteLine("Kişi ehliyet alamaz");
            }

            Console.WriteLine("Uygulama Bitti");
            #endregion

            #region Örnek 2
            //Bir değişkendeki sayının pozitif mi, negatif mi ya da nötr mü olduğunu ekrana yazdıran kodu yazın.

            int sayi5 = 0;
            if (sayi5 > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if (sayi5 < 0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Nötr");
            }
            #endregion

            #region Örnek 3
            //Bir değişkendeki sayının tek mi çift mi olduğunu bulan kodu yazın.
            //Sayı tek ise ekrana “Tektir” yazsın, değilse ekrana “Çifttir” yazsın.

            int sayi6 = 4;

            if (sayi6 % 2 == 0)
            {
                Console.WriteLine("Çifttir");
            }
            else if (sayi6 % 2 != 0)
            {
                Console.WriteLine("Tektir");
            }
            #endregion

            #region Ve / Veya
            int sayi7 = 3;

            if (sayi7 > 5 && sayi7 % 2 == 0) // ve bağlacı
            {
                Console.WriteLine("Sayi 5'ten büyük ve çifttir");
            }
            else
            {
                Console.WriteLine("1. Koşul sağlanmadı");
            }

            if (sayi7 > 5 || sayi7 % 2 == 0) // veya bağlacı
            {
                Console.WriteLine("Sayi 5'ten büyük veya çifttir");
            }
            else
            {
                Console.WriteLine("2. Koşul sağlanmadı");
            }
            #endregion

            #region En Büyüğü Bulma Algoritması 1.Yöntem
            int a = 60;
            int b = 300;
            int c = 110;
            int d = 2342;

            if (a > b && a > c && a > d)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c)
            {
                Console.WriteLine(d);
            }

            #endregion

            #region En Büyüğü Bulma Algoritması 2.Yöntem
            int a = 60;
            int b = 300;
            int c = 110;
            int d = 2342;

            // c > b > a
            // b > c > a
            // b > a > c
            
            int enBuyuk = a;
            
            if (b > enBuyuk)
            {
                enBuyuk = b;
            }
            if (c > enBuyuk)
            {
                enBuyuk = c;
            }
            if (d > enBuyuk)
            {
                enBuyuk = d;
            }

            Console.WriteLine(enBuyuk);
            #endregion

            #region String Birleştirme
            int a = 3 + 5 + 7;

            string isim1 = "Ali";
            string isim2 = "Kemal";

            string isim = isim1 + " " + isim2;
            Console.WriteLine("Merhaba " + isim);
            #endregion

            #region Konsoldan Veri Okuma
            Console.Write("İsminizi girin: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Merhaba " + isim);

            Console.Write("Sayı 1: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Sayı 2: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
            #endregion

            //Kullanıcıdan istenen vize ve final notu ile,
            //öğrencinin geçip geçmediğini hesaplayan programın kodunu yazın.

            //Vize: _
            //Final: _

            //Öğrencinin geçme notu hesaplanır.
            //Bunun için vizenin % 40’ı, finalin % 60’ı toplanır. (vize * 0.4)

            //Not: X

            //Öğrencinin geçip geçmediğini ekrana yazdırın.
            //Geçme notu en az 50 ve final notu en az 60 olmak zorundadır.

            Console.Write("Vize: ");
            double vize = double.Parse(Console.ReadLine());

            Console.Write("Final: ");
            double final = double.Parse(Console.ReadLine());

            double gecmeNotu = (vize * 0.4) + (final * 0.6);

            Console.WriteLine("Not: " + gecmeNotu);

            if (gecmeNotu >= 50 && final >= 60)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }

        }
    }
}