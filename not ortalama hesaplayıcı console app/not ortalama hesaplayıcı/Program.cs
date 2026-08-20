using System.Runtime.CompilerServices;

int edebiyat1;
int edebiyat2;
int edebiyat3;
int edebiyat4;
int edebiyatort;

int mat1;
int mat2;
int mat3;
int mat4;
int matort;

int biyo1;
int biyo2;
int biyo3;
int biyo4;
int biyoort;

int kimya1;
int kimya2;
int kimya3;
int kimya4;
int kimyaort;

int fizik1;
int fizik2;
int fizik3;
int fizik4;
int fizikort;

int ing1;
int ing2;
int ing3;
int ing4;
int ingort;

int cografya1;
int cografya2;
int cografya3;
int cografya4;
int cografyaort;

int beden1;
int beden2;
int beden3;
int beden4;
int bedenort;

int GENELORTALAMA;

Console.Write("Edebiyat dersinin birinci sinav notunu giriniz: ");
edebiyat1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Edebiyat dersinin ikinci sinav notunu giriniz: ");
edebiyat2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Edebiyat dersinin üçüncü sinav notunu giriniz: ");
edebiyat3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Edebiyat dersinin dördüncü sinav notunu giriniz: ");
edebiyat4 = Convert.ToInt32(Console.ReadLine());

edebiyatort  =  (edebiyat1 + edebiyat2 + edebiyat3 + edebiyat4) / 4;
Console.WriteLine("Edebiyat Dersi Ortalaman: " + edebiyatort);

if (edebiyatort >= 70 && edebiyatort < 100)
{
    Console.WriteLine("Tebrikler dersi gectin.");
}
else if (edebiyatort < 50)
{
    Console.WriteLine("Üzüzgünüm malesef dersi gecemedin.");
}
else if (edebiyatort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}


Console.Write("Matematik dersinin birinci sinav notunu giriniz: ");
mat1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Matematik dersinin ikinci sinav notunu giriniz: ");
mat2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Matematik dersinin ücüncü sinav notunu giriniz: ");
mat3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Matematik dersinin dördüncü sinav notunu giriniz: ");
mat4 = Convert.ToInt32(Console.ReadLine());

matort = (mat1 + mat2 + mat3 + mat4) / 4;
Console.WriteLine("Matematik Dersi Ortalaman: " + matort);

if (matort >= 50 && matort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (matort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (matort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}

Console.Write("Biyoloji dersinin birinci sinav notunu giriniz: ");
biyo1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Biyoloji dersinin ikinci sinav notunu giriniz: ");
biyo2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Biyoloji dersinin üçüncü sinav notunu giriniz: ");
biyo3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Biyoloji dersinin dördüncü sinav notunu giriniz: ");
biyo4 = Convert.ToInt32(Console.ReadLine());

biyoort = (biyo1 + biyo2 + biyo3 + biyo4) / 4;
Console.WriteLine("Biyoloji Dersi Ortalaman: " + biyoort);

if (biyoort >= 50 && biyoort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (biyoort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (biyoort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}

Console.Write("Kimya dersinin birinci sinav notunu giriniz: ");
kimya1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kimya dersinin ikinci sinav notunu giriniz: ");
kimya2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kimya dersinin üçüncü sinav notunu giriniz: ");
kimya3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kimya dersinin dördüncü sinav notunu giriniz: ");
kimya4 = Convert.ToInt32(Console.ReadLine());

kimyaort = (kimya1 + kimya2 + kimya3 + kimya4) / 4;
Console.WriteLine("Kimya Dersi Ortalaman: " + kimyaort);

if (kimyaort >= 50 && kimyaort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (kimyaort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (kimyaort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}


Console.Write("Fizik dersinin birinci sinav notunu giriniz: ");
fizik1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Fizik dersinin ikinci sinav notunu giriniz: ");
fizik2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Fizik dersinin üçüncü sinav notunu giriniz: ");
fizik3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Fizik dersinin dördüncü sinav notunu giriniz: ");
fizik4 = Convert.ToInt32(Console.ReadLine());

fizikort = (fizik1 + fizik2 + fizik3 + fizik4) / 4;
Console.WriteLine("Fizik Dersi Ortalaman: " + fizikort);

if (fizikort >= 50 && fizikort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (fizikort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (fizikort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}


Console.Write("İngilizce dersinin birinci sinav notunu giriniz: ");
ing1 = Convert.ToInt32(Console.ReadLine());
Console.Write("İngilizce dersinin ikinci sinav notunu giriniz: ");
ing2 = Convert.ToInt32(Console.ReadLine());
Console.Write("İngilizce dersinin üçüncü sinav notunu giriniz: ");
ing3 = Convert.ToInt32(Console.ReadLine());
Console.Write("İngilizce dersinini dördüncü sinav notunu giriniz: ");
ing4 = Convert.ToInt32(Console.ReadLine());

ingort = (ing1 + ing2 + ing3 + ing4) / 4;
Console.WriteLine("İngilizce Dersi Ortalaman: " + ingort);

if (ingort >= 50 && ingort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (ingort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (ingort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}


Console.Write("Cografya dersinin birinci sinav notunu giriniz: ");
cografya1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Cografya dersinin ikinci sinav notunu giriniz: ");
cografya2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Cografya dersinin üçüncü sinav notunu giriniz: ");
cografya3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Cografya dersinin dördüncü sinav notunu giriniz: ");
cografya4 = Convert.ToInt32(Console.ReadLine());

cografyaort = (cografya1 + cografya2 + cografya3 + cografya4) / 4;
Console.WriteLine("Cgorafya Dersi Ortalaman: " + cografyaort);

if (cografyaort >= 50 && cografyaort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (cografyaort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (cografyaort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}


Console.Write("beden dersinin birinci sinav notunu giriniz: ");
beden1 = Convert.ToInt32(Console.ReadLine());
Console.Write("beden dersinin ikinci sinav notunu giriniz: ");
beden2 = Convert.ToInt32(Console.ReadLine());
Console.Write("beden dersinin üçüncü sinav notunu giriniz: ");
beden3 = Convert.ToInt32(Console.ReadLine());
Console.Write("beden dersinin dördüncü sinav notunu giriniz: ");
beden4 = Convert.ToInt32(Console.ReadLine());

bedenort = (beden1 + beden2 + beden3 + beden4) / 4;
Console.WriteLine("Beden Dersi Ortalaman: " + bedenort);
if (bedenort >= 50 && bedenort < 100)
{
    Console.WriteLine("tebrikler dersi geçtin.");
}
else if (bedenort < 50)
{
    Console.WriteLine("üzgünüm malesef dersi gecemedin.");
}
else if (bedenort > 100)
{
    Console.WriteLine("HATA!!!");
    return;
}


GENELORTALAMA = (edebiyatort + matort + biyoort + kimyaort + fizikort + ingort + cografyaort + bedenort) / 8;

if (GENELORTALAMA >= 50)
{
    Console.WriteLine("tebrikler sinifi gectin.");
}
else
{
    Console.WriteLine("malesef sinifi gecemedin");
}

Console.WriteLine("liste yapmami ister misin?");
string liste = Console.ReadLine();


if (liste == "isterim") 
{
    Console.WriteLine("Edebiyat: " + edebiyatort);
    Console.WriteLine("Matematik: " + matort);
    Console.WriteLine("Biyoloji:" + biyoort);
    Console.WriteLine("Kimya: " + kimyaort);
    Console.WriteLine("Fizik: " + fizikort);
    Console.WriteLine("İngilizce: " + ingort);
    Console.WriteLine("Cografya: " + cografyaort);
    Console.WriteLine("Beden: " + bedenort);
    Console.WriteLine("GENEL ORTALAMA: " + GENELORTALAMA);
    Console.WriteLine("İYİ GÜNLER DİLERİZ 8)");
}
else
{
    Console.WriteLine("İYİ GÜNLER DİLERİZ 8)");
}

