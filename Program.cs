// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] renkler = new string[5];

string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi;
dizi = new int[5];

renkler[0] = "mavi";
Console.WriteLine(hayvanlar[0]);
dizi[3] = 10;

Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

Console.WriteLine("dizinin eleman sayısı: ");
int diziUz = int.Parse(Console.ReadLine());
int[] sayıDizisi = new int[diziUz];

for (int i = 0; i < diziUz; i++)
{
    Console.Write("{0}. sayıyı giriniz:", i + 1);
    sayıDizisi[i] = int.Parse(Console.ReadLine());
}


int top = 0;
foreach (int sayi in sayıDizisi)
    top += sayi;
Console.WriteLine("ortalama = " + top/diziUz);
Console.ReadLine();