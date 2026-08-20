using System.IO;
using System.Linq.Expressions;


Dictionary<string, int> elektronik = new Dictionary<string, int>()
{
    {"İphone 17",120000},
    {"Bilgisayar",40000},
    {"Dyson Süpürge",30000},
    {"Kulaklik",5000},
    {"Saç Kurutma Makina",10000},
    {"Klavye",4000},
    {"Mouse",3000},
    {"Monitör",7000},
    {"Kahve Makinasi",5000},
    {"Aklli Saat",8000}

};
Dictionary<string, int> giyim = new Dictionary<string, int>()
{
    {"Mont",5000},
    {"Tişört",750},
    {"Pantolon",1000},
    {"Ayakkabi",3000},
    {"Krampon",500},
    {"Mayo",500},
    {"Kolej Ceket",1500},
    {"Gömlek",1000},
    {"İç Çamaşari",100},
    {"Çorap",50 },
    {"Şapka",150},
    {"Hirka",500}
};
Dictionary<string, int> Yiyecek = new Dictionary<string, int>()
{
    {"Hamburger",300},
    {"Pizza",250},
    {"Kokoreç",300},
    {"Döner",150},
    {"Chiki wiki",400 },
    {"Lahmacun",100},
    {"Pide",100},
    {"Kumpir",300},
    {"Tavuk Pilav",150},
    {"Tost",100 },
    {"Dondurma",50},
    {"Künefe",250},
    {"Katmer",300},
    {"Sütlaç",100},
    {"Süt Misir",70 }
};
Dictionary<string, int> taki = new Dictionary<string, int>()
{
    {"Kolye",500},
    {"Saat",3000},
    {"Gözlük",2000},
    {"Bilezik",500},
    {"Yüzük",500},
    {"Küpe",300},
    {"Telefon Kilifi",300}
};
Dictionary<string, int> temzilikürünü = new Dictionary<string, int>()
{
    {"Sabun",100},
    {"Bulaşik Deterjani",150},
    {"Arap Sabunu",150 },
    {"Tuz Ruhu",200},
    {"Lavabo Açici",250},
    {"Çamaşir suyu",300 },
    {"Şampuan",200},
    {"Duş jeli",250},
    {"Diş Macunu",150}
};
Dictionary<string, int> sepet = new Dictionary<string, int>();



Console.WriteLine("MAGZAMIZA HOŞGELDİNİZ 8)");
bool AnaMenü = true;
while (AnaMenü)
{
    Console.Clear();
    Console.WriteLine("1. Kategorileri görüntüle: ");
    Console.WriteLine("2. Sepeti Görüntüle: ");
    Console.WriteLine("3. Çikiş");
    int eylem = Convert.ToInt32(Console.ReadLine());
    switch (eylem)
    {
        case 1:
            bool kategoriMenü = true;
            while (kategoriMenü)
            {
                Console.Clear();
                Console.WriteLine("1. Elektronik");
                Console.WriteLine("2. Giyim");
                Console.WriteLine("3. Yiyecek");
                Console.WriteLine("4. Taki");
                Console.WriteLine("5. Temizlik Ürünleri");
                Console.WriteLine("6. çikiş");
                int eylem2 = Convert.ToInt32(Console.ReadLine());

                switch (eylem2)
                {
                    case 1:
                        bool elektronikmenü = true;
                        while (elektronikmenü)
                        {
                            Console.Clear();
                            int a = 1;
                            foreach (var ürün in elektronik)
                            {
                                Console.WriteLine(a + ". " + ürün.Key + " - " + ürün.Value);
                                a++;
                            }
                            Console.WriteLine(a + ". çikiş");
                            int işlem2 = Convert.ToInt32(Console.ReadLine());
                            if (işlem2 == a)
                            {
                                elektronikmenü = false;
                            }
                            else
                            {
                                sepet.Add(elektronik.ElementAt(işlem2 - 1).Key, elektronik.ElementAt(işlem2 - 1).Value);
                            }
                        }
                        break;
                    case 2:
                        bool giyimmenü = true;
                        while (giyimmenü)
                        {
                            Console.Clear();
                            int a = 1;
                            foreach (var ürün in giyim)
                            {
                                Console.WriteLine(a + ". " + ürün.Key + " - " + ürün.Value);
                                a++;
                            }
                            Console.WriteLine(a + ". çikiş");
                            int işlem3 = Convert.ToInt32(Console.ReadLine());
                            if (işlem3 == a)
                            {
                                giyimmenü = false;
                            }
                            else
                            {
                                sepet.Add(giyim.ElementAt(işlem3 - 1).Key, giyim.ElementAt(işlem3 - 1).Value);
                            }
                        }
                        break;
                    case 3:
                        bool Yiyecekmenü = true;
                        while (Yiyecekmenü)
                        {
                            Console.Clear();
                            int a = 1;
                            foreach (var ürün in Yiyecek)
                            {
                                Console.WriteLine(a + ". " + ürün.Key + " - " + ürün.Value);
                                a++;
                            }
                            Console.WriteLine(a + ". çikiş");
                            int işlem4 = Convert.ToInt32(Console.ReadLine());
                            if (işlem4 == a)
                            {
                                Yiyecekmenü = false;
                            }
                            else
                            {
                                sepet.Add(Yiyecek.ElementAt(işlem4 - 1).Key, Yiyecek.ElementAt(işlem4 - 1).Value);
                            }
                        }
                        break;
                    case 4:
                        bool takimenü = true;
                        while (takimenü)
                        {
                            Console.Clear();
                            int a = 1;
                            foreach (var ürün in taki)
                            {
                                Console.WriteLine(a + ". " + ürün.Key + " - " + ürün.Value);
                                a++;
                            }
                            Console.WriteLine(a + ". çikiş");
                            int işlem5 = Convert.ToInt32(Console.ReadLine());
                            if (işlem5 == a)
                            {
                                takimenü = false;
                            }
                            else
                            {
                                sepet.Add(taki.ElementAt(işlem5 - 1).Key, taki.ElementAt(işlem5 - 1).Value);
                            }
                        }
                        break;
                    case 5:
                        bool temzilikürünümenü = true;
                        while (temzilikürünümenü)
                        {
                            Console.Clear();
                            int a = 1;
                            foreach (var ürün in temzilikürünü)
                            {
                                Console.WriteLine(a + ". " + ürün.Key + " - " + ürün.Value);
                                a++;
                            }
                            Console.WriteLine(a + ". çikiş");
                            int işlem6 = Convert.ToInt32(Console.ReadLine());
                            if (işlem6 == a)
                            {
                                temzilikürünümenü = false;
                            }
                            else
                            {
                                sepet.Add(temzilikürünü.ElementAt(işlem6 - 1).Key, temzilikürünü.ElementAt(işlem6 - 1).Value);
                            }
                        }
                        break;
                    case 6:
                        kategoriMenü = false;
                        break;
                }
            }
            break;
        case 2:

            bool sepetmenü = true;
            while (sepetmenü)
            {
                Console.Clear();
                int fiyat = 0;
                int b = 1;
                foreach (var ürün in sepet)
                {

                    Console.WriteLine(b + ". " + ürün.Key + " - " + ürün.Value);
                    b++;
                    fiyat = fiyat + ürün.Value;
                }
                Console.WriteLine(b + ". " + "Sepeti Onaylamak İçin Basiniz ");

                Console.WriteLine(b + 1 + ". " + "Çikiş");

                Console.WriteLine("Çikartmak İçin Ürünün Numarasini Giriniz");

                Console.WriteLine("Toplam Sepet Fiyati: " + fiyat);
                int işlem7 = Convert.ToInt32(Console.ReadLine());
                if (işlem7 == b + 1)
                {
                    sepetmenü = false;

                }
                else if (işlem7 == b)
                {
                    sepet.Clear();
                    sepetmenü = false;
                    Console.WriteLine("ALLAH'A EMANET YİGİDO");
                    return;
                }
                else
                {
                    sepet.Remove(sepet.ElementAt(işlem7 - 1).Key);


                }

            }

            break;
        case 3:
            Console.WriteLine("ALLAH'A EMANET YİGİDO");
            return;
    }
}
