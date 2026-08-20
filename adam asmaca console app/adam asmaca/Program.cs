using System.IO;
using System.Linq.Expressions;
List<string> kelimeler = new List<string>();
List<char> kullanilmisharfler = new List<char>();
List<char> yanlisharfler = new List<char>();
Random randomsayi = new Random();

string dosya = "kelimeler.txt";
if (!File.Exists(dosya))
{
    File.WriteAllText(dosya, "");
}


kelimeler = new List<string>(File.ReadAllLines(dosya));



char harf;
int hatasayisi = 0;

string randomkelime = kelimeler.ElementAt(randomsayi.Next(0, kelimeler.Count() - 1));

başlangiç:
while (true)
{
    Console.Clear();
    switch (hatasayisi)
    {
        case 0:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|_");
            break;
        case 1:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          O");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|_");
            break;
        case 2:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          O");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |");
            Console.WriteLine("_|_");
            break;
        case 3:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          O");
            Console.WriteLine(" |         /|");
            Console.WriteLine(" |");
            Console.WriteLine("_|_");
            break;
        case 4:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          O");
            Console.WriteLine(" |         /|\\");
            Console.WriteLine(" |");
            Console.WriteLine("_|_");
            break;
        case 5:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          O");
            Console.WriteLine(" |         /|\\");
            Console.WriteLine(" |         /");
            Console.WriteLine("_|_");
            break;
        case 6:
            Console.WriteLine("  __________");
            Console.WriteLine(" |          |");
            Console.WriteLine(" |          O");
            Console.WriteLine(" |         /|\\");
            Console.WriteLine(" |         / \\");
            Console.WriteLine("_|_");
            Console.WriteLine("         GAME OVER 8(");
            Console.WriteLine("");
            Console.WriteLine(randomkelime);
            Console.WriteLine("");
            
            Console.WriteLine("Oyunu Sonlandirmak İçin 1'e Basiniz: ");
            int eylem = Convert.ToInt32(Console.ReadLine());
            
            /*burada oyunu sonlandırmak için 1 e basamıyorum kendiliğinden bitiyor*/
            if (eylem == 1)
            {
                Console.Clear();
                Console.WriteLine("ALLAH'A EMANET YİGİGO");

                return;
            }
            break;
            //burada oyun bitecek   
    }
    foreach (char karakter in randomkelime)
    {
        if (kullanilmisharfler.Contains(karakter))
        {
            Console.Write(karakter + " ");
        }
        else
        {
            Console.Write("_ ");
        }
    }
    Console.WriteLine(" ");
    Console.Write("Yanliş Harfler: ");
    foreach (char karakter in yanlisharfler)
    {
        Console.Write(karakter);
    }
    Console.WriteLine(" ");
    Console.Write("Harf Giriniz: ");
    string giris = Console.ReadLine();
    if (string.IsNullOrEmpty(giris))
        continue;
    harf = giris[0];
    if (kullanilmisharfler.Contains(harf))
    {

    }
    else 
    {
        if (randomkelime.Contains(harf))
        {
            kullanilmisharfler.Add(harf);
            continue;
        }
        else
        {
            kullanilmisharfler.Add(harf);
            yanlisharfler.Add(harf);
            hatasayisi = hatasayisi + 1;
            continue;
        }
    }
    
}
// oyun bitince dogru cevabı yazsın