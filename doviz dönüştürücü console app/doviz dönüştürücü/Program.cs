double tl ;
double euro = 48.45;
double dolar = 42.11;
double sterlin = 55.02;
double kuveytdinari = 137.06;
double Para = 0;



Console.WriteLine("1. Türk Lirasi");
Console.WriteLine("2. Euro");
Console.WriteLine("3. Dolar");
Console.WriteLine("4. Sterlin");
Console.WriteLine("5. Kuveyt Dinari");
Console.Write("elinizdeki para birimi: ");
int komut1 = Convert.ToInt32(Console.ReadLine());


switch (komut1)
{
    case 1:
        Console.Write("ne kadar TL'ye sahipsiniz: ");
        Para = Convert.ToDouble(Console.ReadLine());
        break;
    case 2:
        Console.Write("ne kadar Euro'ya sahipsiniz: ");
        Para = Convert.ToDouble(Console.ReadLine());
        Para = euro * Para;
        break;
    case 3:
        Console.Write("ne kadar Dolar'a sahipsiniz: ");
        Para = Convert.ToDouble(Console.ReadLine());
        Para = dolar * Para;
        break;
    case 4:
        Console.Write("ne kadar Sterlin'e sahipsiniz: ");
        Para = Convert.ToDouble(Console.ReadLine());
        Para = sterlin * Para;
        break;
    case 5:
        Console.Write("ne kadar Kuveyt Dinari'na sahipsiniz: ");
        Para = Convert.ToDouble(Console.ReadLine());
        Para = kuveytdinari * Para;
        break;
    default:
        Console.WriteLine("HATA!!!");
        break;


}



Console.WriteLine("1. Türk Lirasi");
Console.WriteLine("2. Euro");
Console.WriteLine("3. Dolar");
Console.WriteLine("4. Sterlin");
Console.WriteLine("5. Kuveyt Dinari");
Console.Write("hangi para birimine çevireceksiniz: ");
int komut2 = Convert.ToInt32(Console.ReadLine());


switch (komut2)
{
    case 1:
        break;
    case 2:
        Para = Para / euro;
        break;
    case 3:
        Para = Para / dolar;
        break;
    case 4:
        Para = Para / sterlin;
        break;
    case 5:
        Para = Para / kuveytdinari;
        break;
    default:
        Console.WriteLine("HATA!!!");
        break;
}

Console.WriteLine("Paraniz: " + Para);
Console.WriteLine("İşleminiz Başari ile Gerçekleşmiştir 8)");