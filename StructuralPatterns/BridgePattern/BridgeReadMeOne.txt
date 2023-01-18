Bridge Pattern(Köprü Kalıbı)

- Değişen ile değişmeyen kısımları ayırmak
- Bileşimi, kalıtıma tercih et

PROBLEM
- Normalde soyutlamalar(interfaceler) ile gerçekleştirmeleri(implementation) birbirinden ayrı değildir aralarında kalıtım yani is-a ilişkisi vardır.
- Soyutlama arayüzün(interfaceler) farklı alt tipleri  ise arayüzün farklı gerçekleştirmelerini belirler.
- Fakat bu durum soyutlama ile alt tipleri arasında ciddi bir bağımlılığa sebep olur.

AType <-------------------ASubType
(Soyutlama)               (Gerçekleştirme)

- Soyutlama ile gerçekletirme arasındaki bağımlılık arayüz seviyesinde kalmaz, gerçekleştirmeye de bağımlılık söz konusudur.
   - Kalıtımda gerçekleştirme, soyutlamadan hem arayüz hemde gerçekleştirme devralabilir.(hem interface hemde abstrac class - içi boş metot ve içi dolu metot)
   - Soyutlamalar ile gerçekleştirmeleri arasındaki ilişki is-a olarak ifade edildiğinde iki tarafı da kısıtlayan bir durum oluşur.
   - Kalıtım, en temel nesne mekanizmalarından olmasına rağmen yüksek bağımlılık oluşturduğu için bazen kaçınılması gerekir.

Ana Fikir: 
   Soyutlamalar ile onların implementasyonşarı arasındaki ilişki her zaman is-a olarak yapılmak zorunda değildir.
   Bu ilişki bazen has-a ile de gösterilebilir.
   Ve bu durumda yüksek bağımlılığın getirdiği negatif etkiler aşılabilir.


ÇÖZÜM
Bridge kalıbı, soyutlamalar ile onların gerçekleştirmeleri arasında tabi durumda var olan is-a ilişkisini, has-a ilişkisine çevirir.
Bu durumda soyutlamalar ve gerçekleştirmeleri ayrı hiyerarşilerde tutulur.
Aralarında has-a ilişkisi olur.
Bu şekilde iki taraf arasındaki bağımlılığın azalması hedeflenir.

Sonuçlar:

