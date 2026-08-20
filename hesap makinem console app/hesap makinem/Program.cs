Console.Write("1. sayiyi giriniz: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sayiyi giriniz: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("yapmak istediğiniz işlemi giriniz: ");
char işlem = Convert.ToChar(Console.Read());

double sonuc;


if (işlem == '+')
{
    Console.WriteLine(x + y);
}
else if (işlem == '-')
{
    Console.WriteLine(x - y);
}
else if (işlem == '/')
{
    sonuc = x / y;
    Console.WriteLine(sonuc);
}
else if (işlem == '*')
{
    Console.WriteLine(x * y);
}


