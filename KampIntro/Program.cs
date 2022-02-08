//See https://aka.ms/new-console-template for more information

// type safety -- tip güvenliği
String kategorietiketi = "kategori";
int ogrencisayisi = 32000;
double faizorani = 1.45;
bool sistemegirisyapmismi = true;
double dolardun = 7.55;
double dolarbugun = 7.45;

if (dolardun>dolarbugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolardun<dolarbugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}

if (sistemegirisyapmismi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}
    Console.WriteLine(kategorietiketi);
