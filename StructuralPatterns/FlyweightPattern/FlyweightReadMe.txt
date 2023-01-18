Flyweight
Sistemde çok sayıda oluşturulan küçük nesnelerin ortak kullanılarak sistem kaynaklarının daha az tüketilmesini sağlar. 
Birçok kez oluşturulan nesnelerin tekrar kullanılarak çok sayıda nesne oluşturulması önlenir.

Problem -I
Bazen çözümlermizde ufak-tefek olan çok sayıda nesne kullanmak zorunda kalırız.
- Örneğin, bir kitabın modellenmesinde kullanılabilecek sayfa, paragraf, satır, kelime ve harf nesneleri bu cinstendir.
- Bir kitabp 500 sayfadan oluşuyorsa bizim 500 tane sayfa nesnesi mi oluşturmamız gerekir ? yada 8.000 adet paragraf nesnesi ? 
- Tek bir sayfa nesnesi oluşturup bu sayfa nesnesini reuse edebiliriz. her sayfa geçişinde içini sayfanın içini boşaltıp yeniden doldurmak

Prototype Patternde var olan objeyi refereans alarak yeni bir obje yaratıyoruz.
Flyweightte ise var olan objeleri tekrar kullanıyoruz. Yani yeni bir obje yaratmak yerine var olan objenin üzerinde değişiklip yapıyoruz.

ÖRNEK, Bir oyun yazıyorsak eğer bir asker bir bağlam da Türk askeri olarak gözüküyorken bir başka bağlamda Türk subayı olarak gözükebilir.
Burada aynı nesne üzerinde sadece görüntüyü değiştiriyoruz. Temel nesne aynıdır.
Yada bir asker bir yerde karacı gözükürken başka yerde havacı gözükebilir. Bizim sıfırdan yeni bir havacı nesne yaratmamız yerine
var olan karacı nesnesini alıp içinde bulunduğu bağlamdan dolayı denizci giysisi giydirmemiz çok daha az masraflı olabilir..

ÖRNEK, harf nesnemiz olsun. Bu harf nesnemiz satır başındayken herzaman büyük olsun gibi bir kuralımız olabilir.
Aynı nesne satır başındayken büyük, satır ortasındayken küçük olur.

Yani Flyweight nesne, içinde bulunduğu bağlam ile ilgili bir bilgiyi edinebilir ve buna göre davranışını değiştirebilir.(Paragraf başındaysa harfin büyük başlaması)

Bu noktada Flyweight bir nesnenin durumu ile ilgili şu ayrım yapılabilir.
- içsel yada asıl durum (intrinsic state) : Konumundan ve contextinden bağımsız bu obje gerçekten ne objesidir. Bu obje a harfi objesi. Bu obje asker objesi.
-Dışsal ya da ikincil/arizi durum(extrinsic state) : Bu da bağlamsal durumdur. Mesela bir harfin satır başında mı yoksa satır ortasında mı olduğu bağlamsal
durumdur. Bu bağlamsal duruma göre ya büyük yada küçük olacaktır.