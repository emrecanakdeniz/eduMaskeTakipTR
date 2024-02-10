using Business.Somut;
using Entities.Somut;

Vatandas vatandas1 = new Vatandas();
vatandas1.Ad = "Emre Can";
vatandas1.Soyad = "Akdeniz";
vatandas1.DogumYili = 2001;
vatandas1.TcNo = 123;

Vatandas vatandas2 = new Vatandas();
vatandas2.Ad = "Jale";

PttManager pttManager = new PttManager(new VatandasManager());
pttManager.MaskeVer(vatandas1);


SelamVer(isim:"Emre");
SelamVer(isim:"Jale");
SelamVer();

Topla(55,60);

//Diziler /Arrays
string ogrenci1 = "Engin";
string ogrenci2 = "Emre";
string ogrenci3 = "Jale";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Emre";
ogrenciler[2] = "Jale";

ogrenciler=new string[4];
ogrenciler[3] = "Jale";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Amed" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler = new List<string> { "Ankara 1", "Istanbul 1", "Izmir 1" };
yeniSehirler.Add("Adana 1");

foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}

Console.ReadLine();

//resharper
static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}
static int Topla(int s1=2, int s2=3)
{
    int sonuc=s1 + s2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}