using Metodlar;

Urun urun1 = new Urun();  // int, string gibi yeni değişkenler tanımladık gibi...
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("----------------------");
}

Console.WriteLine("------------Metodlar------------");

// class örneği oluşturmak
// encapsulation
SepetManager sepetmanager = new SepetManager();
sepetmanager.Ekle(urun1);
sepetmanager.Ekle(urun2);

sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 58);
sepetmanager.Ekle2("Elma", "Yeşil Elma", 12, 20);
sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 58);
