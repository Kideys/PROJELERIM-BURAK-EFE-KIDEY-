using System.Formats.Asn1;
using System.IO;
string etkinlikler = "etkinlik.txt";
if (!File.Exists(etkinlikler))
{
    File.WriteAllText(etkinlikler, "");
}
List<string> takvim = new List<string>(File.ReadAllLines(etkinlikler));
List<string> etkinliklist = new List<string>();
List<int> etkinlikgünleri = new List<int>();

başlangic:


Console.Clear();
Console.WriteLine("1. Tavkim'i Görüntüle");
Console.WriteLine("2. Etkinlik Oluştur");
Console.WriteLine("3. Etkinlikleri Görüntüle");
Console.WriteLine("4. Etkinligi Silme ");
Console.WriteLine("5. Çikiş");
int işlem = Convert.ToInt32(Console.ReadLine());

switch (işlem)
{
    case 1:
        foreach (string b in takvim)
    {
        etkinliklist = new List<string>(b.Split(' '));
        if (etkinliklist.Count > 0)
        {
        
            etkinlikgünleri.Add(Convert.ToInt32(etkinliklist.ElementAt(0)));
        }
    }

        Console.Clear();
        Console.WriteLine("Kasim 2025");
        Console.WriteLine("");
        Console.Write("|    |    |    |    |    ");
        for (int i = 1;i < 31;i++)
        {

            if (etkinlikgünleri.Contains(i))
            {
                Console.Write("|!" + i + "!");
            }
            else
            {
                Console.Write("| " + i + " ");


                if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30)
                {
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________");

                }
                else if (i < 10)
                {
                    Console.Write(" ");
                }                
            }               
        }
        Console.WriteLine(" ");
        Console.WriteLine("Ana Menüye Dönmek İçin 1'e Basiniz: ");
        int AnaMenü = Convert.ToInt32(Console.ReadLine());

        if (AnaMenü == 1)
        {
            goto başlangic;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 2:
        tekrar:
        Console.Clear();
        Console.Write("İstediginiz Gün: ");
        int gün = Convert.ToInt32(Console.ReadLine());
        etkinlikgünleri.Add(gün);
        
        if (gün > 30)
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
        Console.Write("Etkinliginizi Yainiz: ");
        string ekleneceketkinlik = Console.ReadLine();
        
        takvim.Add(gün + " Kasim : " + ekleneceketkinlik);
        File.WriteAllLines(etkinlikler, takvim);
        
        Console.WriteLine("Daha Falza Etkinlik Oluşturmak İçin 1'e Basiniz.");        
        Console.WriteLine("Ana Menüye Dönmek İçin 2'ye Basiniz: ");
        int eylem = Convert.ToInt32(Console.ReadLine());

        if (eylem == 1)
        {
            goto tekrar;
        }
        else if (eylem == 2)
        {
            goto başlangic;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
        

    case 3:
        Console.Clear();
        foreach (string etkinlik in takvim)
        {
            Console.WriteLine(etkinlik);
        }
        Console.WriteLine("Ana Menüye Dönmek İçin 1'e Basiniz: ");
        AnaMenü = Convert.ToInt32(Console.ReadLine());

        if (AnaMenü == 1)
        {
            goto başlangic;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 4:
        Console.Clear();
        Console.WriteLine("Silmek İstediginiz Etkinlik:");
        string silinecek = Console.ReadLine();
        if (takvim.Contains(silinecek))
        {
            takvim.Remove(silinecek);
            File.WriteAllLines(etkinlikler, takvim);
        }
        Console.WriteLine("Başka Silmek İstediginiz Etkinlik Varsa 1'e Basiniz");
        Console.WriteLine("Ana Menüye Dönmek İçin 2'ye Basiniz");
        AnaMenü = Convert.ToInt32(Console.ReadLine());
        
        if (AnaMenü == 1)
        {
            goto tekrar;
        }
        else if (AnaMenü == 2)
        {
            goto başlangic;
        }
        else
        {
            Console.WriteLine("!!!HATA!!!");
            return;
        }
    case 5:

        break;
}