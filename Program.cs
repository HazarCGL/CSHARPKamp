// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

#region VERI TIPLERI VE KULLANICIDAN VERI ALMA

// C# TEMEL VERI TIPLERI
/*
String = Metinleri Tutmaya yarayan veri tipi
Char = Tek bir metin karakterini tutmaya yarar ayrica ASCII alfabesinde harflere karsilik gelen sayilar ile harfler yazdirilabilir
int = ondaliksiz dogal sayilari tutmaya yarayan veri tipidir
double = ondalikli sayilar icin (64 bit)
decimal = para tipleri icin (128 bit)
float = virgulden sonra tekrar eden sayilarda f kullanmak icin matematikte ust cizgi gibi (32 bit)
bool = true veya false olabilen (true = 1 false = 0 yerinede gecebilir) veri tipidir.
short = int a gore daha kucuk bir range i kapsayan veri tipidir (int -2,147,483,648 ile 2,147,483,647 arasinda, short -32,768 ile 32,767 arasindadir.)
*/
int yas = 11; // bu sekilde yada
string isim;
isim = ("Muhammed Hazar Caglayan"); // bu sekilde tanimlanabilir.
char H_HarfiMetin = 'H'; // yada bu sekilde sadece H harfide yazilabilir.
double ondalikli = 1.79; // sadece ondalikli sayilar icin
float pi = 3.1415928f; // virgulden sonra sonsuza kadar devam eden sayilar icin
decimal Dolar = 15; // para birimleri gibi verileri belirtirken kullanilmak icin
bool Dogru = true; // bool da dogruyu tanimlamak icin kullanim
bool Yanlis = false; // bool da yanlisi tanimlamak icin kullanim
short ShortA = 32767;

//KULLANICIDAN VERI ALMA
string KullaniciAdi;
Console.Write("Lutfen Kullanici Adinizi Giriniz: ");
KullaniciAdi = Console.ReadLine();
Console.WriteLine("Merhaba " + KullaniciAdi);
//Ayni zamanda string veri tipini int veri tipine donusturebiliriz.
Console.Write("Yasinizi Giriniz: ");
string YasGiris = Console.ReadLine();
int YasDonusum = Convert.ToInt32(YasGiris);
// bu donusumlere Su gibi ornek durumlarda ihtiyacimiz olabilir
/*
Mesela Kullanicidan Yas bilgisini aldik ve yazdirmak istiyoruz
ama kod bunun metin olarak yazilacagini bilmedigi icin 
bir sayi ile metini toplamaya calistigimizi dusunerek hata vericektir
*/
int ArtiOnYil = YasDonusum + 10;
Convert.ToString(ArtiOnYil);
Console.Write("10 yil sonraki yasiniz: " + ArtiOnYil);
#endregion 