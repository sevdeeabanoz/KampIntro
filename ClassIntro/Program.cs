// See https://aka.ms/new-console-template for more information

string adi = "Sevde";
int yas = 22;

Kurs kurs1=new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Sevde A.";
kurs1.IzlenmeOrani = 58;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Python";
kurs2.Egitmen = "Kerem";
kurs2.IzlenmeOrani = 68;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Java";
kurs3.Egitmen = "Engin";
kurs3.IzlenmeOrani = 91;

//Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.IzlenmeOrani);


Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + "; " + kurs.Egitmen + "; "+ kurs.IzlenmeOrani);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}