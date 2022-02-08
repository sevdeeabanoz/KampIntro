// See https://aka.ms/new-console-template for more information

int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

// int, bool, decimal, double, floot değer tip olduğundan sayi1 30 değerini alır. Değer tipler stack belleğinde gerçekleşir.

int[] sayilar1 = new int[] { 10, 20, 30};
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
Console.WriteLine(sayilar1[0]); 

// arrayler, classlar ve interfareler referans tipi olduğundan sayilar1[0] 999 değerini alır. Referans tipler heap belleğinde gerçekleşir.
// new heapte yeni bir adres oluştur demektir. yukarıdaki ilk örnekte diyoruz ki sayilar1'in yeni adresi sayilar2' nin yeni adresi olsun. Biz adresin içinde yani heapin içinde değişiklik yaptığımızda kodları en başından itibaren değiştirir.
