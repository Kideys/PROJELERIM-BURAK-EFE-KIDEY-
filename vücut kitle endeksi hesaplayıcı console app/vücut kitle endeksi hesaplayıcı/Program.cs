Console.Write("Kilonuzu Yaziniz: ");
int kg = Convert.ToInt32(Console.ReadLine());

Console.Write("Boyunuzu cm Cinsinden Yaziniz: ");
int boy = Convert.ToInt32(Console.ReadLine());

Console.Write("Vücut Kitle Endeksiniz Şu Şekildedir: ");
double endeks = (double)kg / (((double)boy / 100) * ((double)boy / 100));
Console.Write(endeks);

if (endeks < 18.5)
{
    Console.WriteLine(" Kilonuz: Cok Zayif");
}
else if (endeks >= 18.5 && endeks < 25)
{
    Console.WriteLine(" Kilonuz: Normal");
}
else if (endeks >= 25 && endeks < 30)
{
    Console.WriteLine(" Kilonuz: Fazla Kilolu");
}
else if (endeks >= 30 && endeks < 40)
{
    Console.WriteLine(" Kilonuz: Obez");
}
else if (endeks >= 40)
{
    Console.WriteLine(" Kilonuz: Aşiri Obez");
} 