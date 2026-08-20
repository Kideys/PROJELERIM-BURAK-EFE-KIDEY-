using System.IO;

string dosya = "finans.txt";
if (!File.Exists(dosya))
{
    File.WriteAllText(dosya, "");
}
List<string> sistem = new List<string>(File.ReadAllLines(dosya));

başlangiç:
Console.Clear();
Console.WriteLine("1. Yeni Gelir Ekle  "); //
Console.WriteLine("2. Yeni Gider Ekle  ");
Console.WriteLine("3. Tüm Kayitlari Listele  ");
Console.WriteLine("4. Bakiye Göster  ");
Console.WriteLine("5. Çikiş");
int işlem = Convert.ToInt32(Console.ReadLine());

switch (işlem)
{
    case 1:
        gelir:
        Console.Clear();
        Console.Write("Tarih:");
        string tarih = Console.ReadLine();

        Console.Write("Açiklama: ");
        string açiklama = Console.ReadLine();

        Console.Write("Tutar: ");
        int tutar = Convert.ToInt32(Console.ReadLine());
        
        sistem.Add("gelir|" + tarih + "|" + açiklama + "|+" + tutar);
        File.WriteAllLines(dosya, sistem);

        Console.WriteLine("1. Daha Fazla Gider Yazmak");
        Console.WriteLine("2. AnaMenü'ye Dönmek ");
        int eylem = Convert.ToInt32(Console.ReadLine());
        if (eylem == 1)
        {
            goto gelir;
        }
        else if (eylem == 2)
        {
            goto başlangiç;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 2:
        gider:
        Console.Clear();
        Console.Write("Tarih:");
        string tarih2 = Console.ReadLine();

        Console.Write("Açiklama: ");
        string açiklama2 = Console.ReadLine();

        Console.Write("Tutar: ");
        int tutar2 = Convert.ToInt32(Console.ReadLine());
        
        sistem.Add("gider|" + tarih2 + "|" + açiklama2 + "|-" + tutar2);
        File.WriteAllLines(dosya, sistem);

        Console.WriteLine("1. Daha Fazla Gider Yazmak");
        Console.WriteLine("2. AnaMenü'ye Dönmek ");
        int eylem2 = Convert.ToInt32(Console.ReadLine());
        if (eylem2 == 1)
        {
            goto gider;
        }
        else if (eylem2 == 2)
        {
            goto başlangiç;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 3:
        kayitlar:
        Console.Clear();
        foreach (string finans in sistem)
        {
            Console.WriteLine(finans);
        }

        Console.WriteLine("1. Daha Fazla Gider Yazmak");
        Console.WriteLine("2. AnaMenü'ye Dönmek ");
        int eylem3 = Convert.ToInt32(Console.ReadLine());
        if (eylem3 == 1)
        {
            goto kayitlar;
        }
        else if (eylem3 == 2)
        {
            goto başlangiç;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 4:
        int Bakiye = 0;
        foreach(string eleman in sistem)
        {
            var x = eleman.Split('|');
            Bakiye += Convert.ToInt32(x.ElementAt(3));    
        }
        Console.Clear();        
        Console.WriteLine("Bakiyeniz: " + Bakiye );
        Console.WriteLine("1. Daha Fazla Gider Yazmak");
        Console.WriteLine("2. AnaMenü'ye Dönmek ");
        int eylem4 = Convert.ToInt32(Console.ReadLine());
        if (eylem4 == 1)
        {
            goto kayitlar;
        }
        else if (eylem4 == 2)
        {
            goto başlangiç;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 5:
        break;
    
}