using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace G064H03D01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Break - Continue
            //1’den 50’ye kadar kurulan bir döngüde 30'lu sayıları hiç yazdırmayan, diğerlerini yazdıran kodu yazın.

            for (int i = 1; i <= 50; i++)
            {
                if (i >= 30 && i < 40)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //1’den 50’ye kadar kurulan bir döngüde 20'ye kadar olan sayıları (20 dahil) ekrana yazdıran kodu yazın

            //1.yol
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);

                if (i == 20)
                {
                    break;
                }
            }

            Console.WriteLine("------------");

            //2.yol
            for (int i = 1; i <= 50; i++)
            {
                if (i > 20)
                {
                    continue;
                }

                Console.WriteLine(i);

            }

            #endregion

            #region Görev Soruları

            #region Soru - 4
            //Kullanıcıdan kaç tane sayı girileceği istenecek. Kullanıcının istediği kadar sayı girişi alınacak.
            //Sayılar alındıktan sonra aşağıdaki çıktıyı veren C# konsol uygulamasını yapın.
            //Tek sayı adedi: x
            //Çift sayı adedi: y
            //En büyük sayı: z
            //En küçük say: t

            Console.Write("Girilecek sayı adedini girin: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int ciftSayiAdedi = 0;
            int tekSayiAdedi = 0;

            int enBuyuk = int.MinValue;
            int enKucuk = int.MaxValue;

            for (int i = 0; i < adet; i++)
            {
                Console.Write((i + 1) + ". sayıyı girin: ");

                int sayi = int.Parse(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    ciftSayiAdedi++;
                }
                else
                {
                    tekSayiAdedi++;
                }

                if (i == 0)
                {
                    enKucuk = sayi;
                    enBuyuk = sayi;
                }

                if (sayi > enBuyuk || i == 0)
                {
                    enBuyuk = sayi;
                }

                if (sayi < enKucuk || i == 0)
                {
                    enKucuk = sayi;
                }

            }

            Console.WriteLine("Tek sayı adedi: " + tekSayiAdedi);
            Console.WriteLine("Çift sayı adedi: " + ciftSayiAdedi);
            Console.WriteLine("En büyük sayı: " + enBuyuk);
            Console.WriteLine("En küçük say: " + enKucuk);


            #endregion

            #region Soru - 5
            //Kullanıcıdan 2 sayı istenecek. Bu iki değer arasındaki 3 ile tam olarak bölünebilen sayıların ortalamasını
            //ve bu sayıların kaç tane olduğunu veren C# konsol uygulamasını yapın.


            Console.Write("1. sayıyı girin: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı girin: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int ucleBolunenSayiAdedi = 0;
            int ucleBolunenSayilarToplami = 0;


            if (sayi1 > sayi2)
            {
                int temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }


            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 3 == 0)
                {
                    ucleBolunenSayiAdedi++;
                    ucleBolunenSayilarToplami += i;
                }
            }

            Console.WriteLine("3'le tam bölünen sayi adedi: " + ucleBolunenSayiAdedi);

            if (ucleBolunenSayiAdedi > 0)
            {
                double ortalama = (double)ucleBolunenSayilarToplami / ucleBolunenSayiAdedi;
                Console.WriteLine("Ortalama: " + ortalama);
            }
            #endregion

            #region Soru - 6
            //Furkan, bir romanın her gün bir önceki gün okuduğu sayfadan 5 sayfa fazlasını okumaktadır.
            //İlk gün 10 sayfa okuyarak başlayan Furkan' ın 1.000 sayfalık bir romanı kaç günde bitireceğini bulan programı C# dilinde kodlayınız.

            int gun = 0;
            int toplamOkunanSayfa = 0;
            int gunlukOkunanSayfa = 10;

            while (toplamOkunanSayfa <= 1000)
            {
                gun++;
                toplamOkunanSayfa += gunlukOkunanSayfa;

                Console.WriteLine(gun + ". gun okunan sayfa sayısı " + gunlukOkunanSayfa + " toplam: " + toplamOkunanSayfa);

                gunlukOkunanSayfa += 5;
            }

            Console.WriteLine(gun);


            //Oğuzun çözümü
            int toplam = 0;
            int sayac = 0;

            for (int ilkGun = 10; toplam < 1000; ilkGun = ilkGun + 5)
            {
                sayac = sayac + 1;
                toplam = toplam + ilkGun;
            }


            Console.WriteLine("Kitap " + sayac + " günde bitti.");

            #endregion

            #region Soru - 7
            //Girilen sayının asal olup olmadığını söyleyen C# konsol uygulamasını yapın.

            //boolean'lı çözüm
            Console.Write("Sayi girin: ");
            int sayi = int.Parse(Console.ReadLine());

            bool asalMi = true;

            if (sayi < 2)
            {
                asalMi = false;
            }

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }

            if (asalMi)
            {

                Console.WriteLine("Sayı asaldır");
            }
            else
            {
                Console.WriteLine("Sayı asal değildir");
            }




            //sayaçlı çözüm
            Console.Write("Sayi girin: ");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }

            if (sayac == 0)
            {

                Console.WriteLine("Sayı asaldır");
            }
            else
            {
                Console.WriteLine("Sayı asal değildir");
            }


            #endregion

            #region Soru - 8
            //Bir memur, ATM makinesinden para çekmek istemektedir. Makinede sadece 10, 20, 50 ve 100TL' lik banknotlar kalmıştır.
            //Büyük değerli banknotların sayısı maksimum olacak şekilde, çekilecek paranın kaç tane 100, 50, 20 ve 10 liralık banknottan
            //oluşacağını ekranda yazan C# konsol uygulamasını yapın.

            while (true)
            {
                Console.Write("Lütfen para miktarını giriniz :");
                int miktar = int.Parse(Console.ReadLine());


                if (miktar % 10 != 0)
                {
                    Console.WriteLine("En küçük 10 TL’ lik banknot mevcut..!  10'un katı bir değer girin.");
                    continue;
                }

                int yuzluk = miktar / 100;
                miktar %= 100; //miktar = miktar % 100;

                int ellilik = miktar / 50;
                miktar %= 50;

                int yirmilik = miktar / 20;
                miktar %= 20;

                int onluk = miktar / 10;


                if (yuzluk != 0)
                    Console.WriteLine(yuzluk + " adet 100 TL");

                if (ellilik != 0)
                    Console.WriteLine(ellilik + " adet 50 TL");

                if (yirmilik != 0)
                    Console.WriteLine(yirmilik + " adet 20 TL");

                if (onluk != 0)
                    Console.WriteLine(onluk + " adet 10 TL");

                break;
            }


            #endregion

            #region Soru - 9
            //1'den 999'a kadar olan tam sayılar içerisinden basamaklarının küp değeri toplamı kendisine eşit olan değerleri ekrana yazdıran C# programını yazın.


            for (int i = 1; i <= 999; i++)
            {
                int toplam = 0;

                int temp = i;

                while (temp != 0)
                {
                    int basamak = temp % 10;
                    toplam += basamak * basamak * basamak;
                    toplam += (int)Math.Pow(basamak, 7);
                    temp = temp / 10;
                }

                if (i == toplam)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #endregion

            #region Diziler

            //sayılar
            int[] sayilar = new int[5];

            sayilar[0] = 10;
            sayilar[1] = 25;
            sayilar[2] = 28;
            sayilar[3] = 30;
            sayilar[4] = 40;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            //isimler
            string[] isimler = new string[5];

            isimler[0] = "Ali Kemal";
            isimler[1] = "Oğuz";
            isimler[2] = "Burak";
            isimler[3] = "Yağmur";
            isimler[4] = "Fatime";

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[4]);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(isimler[i]);
            }


            //50 elemanlı bir dizi oluşturun

            int[] dizi = new int[50];

            //Bu dizinin elemanlarını rastgele sayılarla doldurun

            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(10, 100);
            }

            //Bu dizinin elemanlarını yan yana ekrana yazdırın

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }

            string s = Console.ReadLine();

            #endregion

            #region Örnek

            //Kullanıcıdan kaç tane isim gireceğini isteyin, bu değere göre oluşturduğunuz diziye kullanıcıdan istediğiniz isimleri ekleyin.
            //Tüm isimler girildikten sonra, aralarına virgül koyarak tek satırda bu isimleri ekrana yazdıran programın kodunu yazın.
            //Not 1: Her isim istendiğinde kaçıncı isim girişi yapıldığı da ekranda yazsın.


            Console.Write("Kaç isim girilecek: ");
            int adet = int.Parse(Console.ReadLine());

            string[] isimler = new string[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.Write((i + 1) + ". ismi girin: ");
                isimler[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write(isimler[i]);

                if (i != isimler.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            #endregion

            #region Haftanın Sorusu
            //Sayısal Loto oyunu: 
            // 1. Adım: Program kullanıcıdan 6 adet sayı girmesini isteyecek ve bu sayılar bir dizide tutulacak,
            // 2. Adım: 6 elemanlı, 1-49 arası rastgele sayılardan oluşturulmuş bir dizi oluşturacak. 
            // 3. Adım: Loto sayılarının olduğu dizi ve kullanıcı tahminlerinin olduğu dizi karşılaştırılarak eşleşen sayı adedi bulunacak.
            // 4. Adım: Oyuncu 3’ün altında bilmişse program “Kazanamadınız.” mesajı verecek. Diğer durumlarda “Tebrikler X adet sayı bildiniz” mesajı verecek. 
            // 5. Adım: Oyuncunun bildiği sayılar ekrana yazdırılacak.


            int[] tahminler = new int[6];
            int[] rastgeleSayilar = new int[6];

            int[] bilinenSayilar = new int[6];
            int bilinenSayiAdedi = 0;

            Random rnd = new Random();
            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                rastgeleSayilar[i] = rnd.Next(1, 50);
                Console.Write(rastgeleSayilar[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < tahminler.Length; i++)
            {
                Console.Write((i + 1) + ". sayıyı girin: ");
                tahminler[i] = int.Parse(Console.ReadLine());
            }

            #endregion
        }
    }
}