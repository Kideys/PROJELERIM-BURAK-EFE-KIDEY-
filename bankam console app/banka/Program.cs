int Bakiye = 22104;

Console.Write("İsim/Soyİsim: ");
string isim = Console.ReadLine();
Console.Write("Şifreniz: ");
int şifre = Convert.ToInt32(Console.ReadLine());

if (şifre == 1293)
{
    Console.WriteLine("HOŞGELDİNİZ 8)");
    Console.WriteLine("1. Para Yükleme");
    Console.WriteLine("2. Para çekme");
    Console.WriteLine("3. Kredi Çek");
    Console.WriteLine("Yapmak istediginiz işlem: ");
    int işlem = Convert.ToInt32(Console.ReadLine());

    if (işlem == 1)
    {
        Console.Write("Yüklüyeceğiniz para miktari: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x < 50)
        {
            Console.WriteLine("Üzgünüm 50 TL Alti İşlemleri Kabul Etmiyouz.");
        }
        else if (x > 10000)
        {
            Console.WriteLine("üzgünüm 10000 TL Yukari İşlemleri Kabul Etmiyoruz.");
        }
        else if (x > 50 && x < 10000)
        {
            Console.WriteLine("Yeni Bakiyeniz: " + (Bakiye + x));
        }

    }


    else if (işlem == 2)
    {
        Console.Write("Çekeceğiniz para miktari: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if (y < 50)
        {
            Console.WriteLine("Üzgünüm 50 TL Alti İşlemleri Kabul Etmiyoruz ");
        }
        else if (y > 10000)
        {
            Console.WriteLine("Üzgünüm 10000 TL Üstü İşlemleri Kabul Etmiyoruz");
        }
        else if (y > 50 && y < 10000)
        Console.WriteLine("Yeni Bakiyeniz: " + (Bakiye - y));
        
    }


    else if (işlem == 3)
    {
        Console.WriteLine("1: 10000");
        Console.WriteLine("2: 25000");
        Console.WriteLine("3: 40000");
        Console.WriteLine("4: 50000");
        Console.Write("Hangi kredi tutarini istersiniz: ");
        int işlem2 = Convert.ToInt32(Console.ReadLine());
        if (işlem2 == 1)
        {
            Console.WriteLine("Kredi İşleminiz Başari ile Gerçekleşmiştir 8)");
            Console.Write("Yeni Bakiyeniz: ");
            Console.WriteLine(Bakiye + 10000);
        }
        else if (işlem2 == 2)
        {
            Console.WriteLine("Kredi İşleminiz Başari ile Gerçekleşmiştir 8)");
            Console.Write("Yeni Bakiyeniz: ");
            Console.WriteLine(Bakiye + 25000);
        }
        else if (işlem2 == 3)
        {
            Console.WriteLine("Kredi İşleminiz Başari ile Gerçekleşmiştir 8)");
            Console.Write("Yeni Bakiyeniz: ");
            Console.WriteLine(Bakiye + 40000);
        }
        else if (işlem2 == 4)
        {
            Console.WriteLine("Kredi İşleminiz Başari ile Gerçekleşmiştir 8)");
            Console.Write("Yeni Bakiyeniz: ");
            Console.WriteLine(Bakiye + 50000);
        }
    }
    else if (işlem > 3)
    {
        Console.WriteLine("HATA!!!");
    }
}


if (şifre != 1293)
{
    Console.WriteLine("Üzgünüm Şifreniz Yanliştir.");
}

Console.WriteLine("İYİ GÜNLER DİLERİZ SAYIN " + isim);
