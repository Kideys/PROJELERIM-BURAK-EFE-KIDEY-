bool kazandi = false;
Random randomnumbers = new Random();
int sayi = randomnumbers.Next(1, 100);

Console.WriteLine("SAYI TAHMİN OYUNUNA HOŞGELDİNİZ 8)");

while (kazandi == false)
{
    Console.Write("Bir Sayi Giriniz: ");
    int yazi = Convert.ToInt32(Console.ReadLine());
    if (sayi > yazi)
    {
        Console.WriteLine("Bilemedin Daha Yüksek ^");
    }
    else if (sayi < yazi)
    {
        Console.WriteLine("Bilemedin Daha Düşük v");
    }
    else if (sayi == yazi)
    {
        Console.WriteLine("Tebrikler Bildin 8)");
        kazandi = true;
    }

}

    










