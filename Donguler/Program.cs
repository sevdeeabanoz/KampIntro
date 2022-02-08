// See https://aka.ms/new-console-template for more information

//string kurs1 = "Yazılım geliştirici yetiştirme kampı";
//string kurs2 = "Programlamaya başlangıç için temel kurs";
//string kurs3 = "Java";

// array -- dizi her defasında yeni bir kurs için string oluşturmak yerine kullanılır => string[] 

string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs",
"Java", "Pyhton", "C#", "C++"};

for (int i = 0; i < kurslar.Length; i++) // length bütün elemanları kapsıyor, kurslar uzunluğu kadar gibi...
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar) // dizi temelli yapıları tek tek göster -- dizilerde genellikle bu kullanılır.
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu - footer");