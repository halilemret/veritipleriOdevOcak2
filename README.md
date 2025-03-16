# C#'ta kullanılan temel veri tipleri
C#'ta çeşitli veri tipleri bulunmaktadır. Bunlar şu kategorilere ayrılabilir:
## Tam Sayı Tipleri
byte: 0 ile 255 arası değerler, 1 byte bellek kullanır
sbyte: -128 ile 127 arası değerler, 1 byte bellek kullanır
short: -32,768 ile 32,767 arası değerler, 2 byte bellek kullanır
ushort: 0 ile 65,535 arası değerler, 2 byte bellek kullanır
int: -2,147,483,648 ile 2,147,483,647 arası değerler, 4 byte bellek kullanır
uint: 0 ile 4,294,967,295 arası değerler, 4 byte bellek kullanır
long: -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arası değerler, 8 byte bellek kullanır
ulong: 0 ile 18,446,744,073,709,551,615 arası değerler, 8 byte bellek kullanır
## Ondalıklı Sayı Tipleri
float: Yaklaşık ±1.5 × 10^-45 ile ±3.4 × 10^38 arası değerler, 4 byte bellek kullanır
double: Yaklaşık ±5.0 × 10^-324 ile ±1.7 × 10^308 arası değerler, 8 byte bellek kullanır
decimal: ±1.0 × 10^-28 ile ±7.9 × 10^28 arası değerler (daha yüksek hassasiyet), 16 byte bellek kullanır
## Karakter ve Metin Tipleri
char: Tek bir Unicode karakter, 2 byte bellek kullanır
string: Unicode karakter dizisi, değişken uzunlukta bellek kullanır
## Mantıksal Tip
bool: true veya false değerler, 1 byte bellek kullanır
## Diğer Temel Tipler
object: Tüm tiplerin base sınıfı
DateTime: Tarih ve zaman bilgisi, 8 byte bellek kullanır

# Değişkenlerin bellek kullanımı karşılaştırması
## int x = 5;
Bellek kullanımı: 4 byte (32 bit)
Değer tipidir (stack'te saklanır)
## double y = 5.2;
Bellek kullanımı: 8 byte (64 bit)
Değer tipidir (stack'te saklanır)
int tipinden 2 kat daha fazla bellek kullanır
Ondalık sayıları saklayabilir ve daha geniş bir değer aralığı sunar
## string name = "Mehmet";
Bellek kullanımı:
String referansı için 4 byte (32-bit sistemde) veya 8 byte (64-bit sistemde)
"Mehmet" içeriği için 12 byte (6 karakter × 2 byte/karakter)
Toplam yaklaşık 16-20 byte
Referans tipidir (referans stack'te, içerik heap'te saklanır)
Değişken uzunlukta veri saklayabilir
