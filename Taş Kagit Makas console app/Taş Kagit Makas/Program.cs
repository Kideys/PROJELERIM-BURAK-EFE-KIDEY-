int bizimskor = 0;
int rakipskor = 0;
string hamle;
int robot;

bool oyunbitti = false;
Random sayi = new Random();

Console.WriteLine("TAŞ KAGIT OYUNUNA HOŞGELDİNİZ 8)");

while (oyunbitti == false)
{
    Console.Write("Hamlenizi Yapin: ");
    hamle = Console.ReadLine();
    robot = sayi.Next(1, 3);
    switch (hamle)
    {
        case "taş":
            switch (robot)
            {
                case 1:
                    Console.WriteLine("Taş");
                    Console.WriteLine("Berabere");
                    break;
                case 2:
                    Console.WriteLine("Kagit");
                    Console.WriteLine("Rakip 1 Puan Kazandi");
                    rakipskor++;
                    break;
                case 3:
                    Console.WriteLine("Maakas");
                    Console.WriteLine("1 Puan Kazandin");
                    bizimskor++;
                    break;
            }
            break;
        case "kagit":
            switch (robot)
            {
                case 1:
                    Console.WriteLine("Taş");
                    Console.WriteLine("1 Puan Kazandin");
                    bizimskor++;
                    break;
                case 2:
                    Console.WriteLine("Kagit");
                    Console.WriteLine("Berabere");
                    break;
                case 3:
                    Console.WriteLine("Makas");
                    Console.WriteLine("Rakip 1 Puan Kazandi");
                    rakipskor++;
                    break;
            }
            break;
        case "makas":
            switch (robot)
            {
                case 1:
                    Console.WriteLine("Taş");
                    Console.WriteLine("Rakip 1 Puan Kazandi");
                    rakipskor++;
                    break;
                case 2:
                    Console.WriteLine("Kagit");
                    Console.WriteLine("1 Puan Kazandin");
                    bizimskor++;
                    break;
                case 3:
                    Console.WriteLine("Makas");
                    Console.WriteLine("Berabere");
                    break;
            }
            break;

    }

    if (bizimskor == 3)
    {
        Console.WriteLine("TEBRİKLER KAZANDINIZ 8)");
        oyunbitti = true;
    }
    else if (rakipskor == 3)
    {
        Console.WriteLine("ÜZGÜNÜM MALESEF KAYBETTİN 8(");
        oyunbitti = true;
    }
    Console.WriteLine(bizimskor + " / " + rakipskor);
    
}



