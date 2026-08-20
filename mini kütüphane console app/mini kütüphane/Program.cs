using System.IO;
string dosya = "liste.txt";
if (!File.Exists(dosya))
{
    File.WriteAllText(dosya,"");
}


List<string> kutuphane = new List<string>(File.ReadAllLines(dosya));


while (true)
{
    Console.Clear();
    Console.WriteLine("KÜTÜPHANEYE HOŞGELDİNİZ 8)");
    Console.WriteLine("1: Kitap ekleme");
    Console.WriteLine("2: Kitap çikarma");
    Console.WriteLine("3: Kitaplari listele");
    Console.WriteLine("4: Çikiş");
    Console.Write("Yapmak İstediginiz İşlemi Yaziniz: ");
    int işlem = Convert.ToInt32(Console.ReadLine());

    switch (işlem)
    {
        case 1:
            Console.Clear();
            Console.Write("Eklemek İstediginiz Kitap Adini Yaziniz: ");
            string eklenecek = (Console.ReadLine());
            if (!kutuphane.Contains(eklenecek))
            {
                kutuphane.Add(eklenecek);
                File.WriteAllLines(dosya,kutuphane);
            }
            break;
        case 2:
            Console.Clear();
            Console.Write("Çikartmak İstedigniz Kitap Adini Yaziniz: ");
            string çikarilacak = Console.ReadLine();
            if (kutuphane.Contains(çikarilacak))
            {
                kutuphane.Remove(çikarilacak);
                File.WriteAllLines(dosya, kutuphane);
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("!!!⚠HATA⚠!!!");
                Console.Write("Ana Menüye Dönmek İçin Herhangi Bir Tuşa Basiniz");
                Console.ReadLine();
            }
          
            break;
        case 3:
            Console.Clear();
            foreach (string kitap in kutuphane)
            {
                Console.WriteLine(kitap);
            }
            Console.Write("Ana Menüye Dönmek İçin Herhangi Bir Tuşa Basiniz");
            Console.ReadLine();
            break;
        case 4:
            return;


        default:
            Console.Clear();
            Console.WriteLine("!!!⚠HATA⚠!!!");
            Console.Write("Ana Menüye Dönmek İçin Herhangi Bir Tuşa Basiniz");
            Console.ReadLine();
            break;
    }
}