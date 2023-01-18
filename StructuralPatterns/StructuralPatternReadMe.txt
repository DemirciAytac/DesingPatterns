Yapısal Kalıplar, sınıflar ve nesnelerin daha büyük yapılar oluşturmak üzere nasıl bir araya geldikleriyle ilgilidir.
- Kalıtım(inheritance yada is-a), yapısal bir ilişkidir.
- Birleştirme(composition ya da has-a), yapısal bir ilişkidir.

Yapısal kalıplarda var olan interfaceleri,classları ve objeleri, kalıtım ve birleştirme yoluyla bir araya getirerek yeni fonksiyonel yapılar oluşturulur.

Adaptör 
Adaptör kalıp sadece bir sınıfa (class) özel olan arayüzleri diğer sınıflarla uyumlu arayüzler haline getirir. 
Adaptörler uyumlu olmayan arayüzler sebebiyle birbirleri ile çalışamayan sınıflara da birbirleri ile çalışma imkanı sunarlar.
Third party libraryleri projeye ekleme
--------------------------------------------------
Bridge: Soyutlama ile gerçekleştirmesini birbirinden ayırmak.
Köprü kalıp soyutlamayı (abstraction) uygulamadan (implementation) ayırarak ikisinin birbirinden bağımsız çalışmasını sağlar. 
Bunu yaparken katmanlı yapı (encapsulation), toplama (aggregation) ve de kalıtımı kullanarak programın görevlerini birbirlerinden farklı sınıflara aktarırlar.
-----------------------------------------------------
Composite: Bütün-parça ilişkisi kurgulamak.
Bileşik kalıp birbirilerinden farklı olan bir grup nesnenin sanki tek bir bütün nesneymiş gibi davranmalarını sağlarlar. 
Bileşik kalıpların görevleri nesneleri bir ağaç yapısında birleştirip uygulamanın genelindeki parça bütün ilişkisini yeniden düzenleyip şekillendirmektir.
---------------------------------------------------
Decorator: Nesneye dinamik olarak yeni özellikler kazandırmak.
Dekoratör kalıp uygulamada runtime esnasında bir sınıfın işlevlenebilirliğinin genişletilmesini veya başka bir deyişle yeniden dekore edilebilmesini mümkün kılar. 
Bunu yaparken dekoratör kalıpları orjinal sınıfları kapsayan yeni dekorator sınıfları üreterek yaparlar.
Logging, Caching
---------------------------------------------------
Façade: Karmaşık alt sistemi kullanmayı kolaylaştırmak.
Vitrin kalıp çok geniş boyutlardaki kod parçalarını onlara göre çok daha sadeleştirilmiş arayüzlere indirgenilmesini sağlar. 
Sınıf kütüphaneleri (class library) bu tür kalıplar için verilebilecek en iyi örnekleridir.
---------------------------------------------------
Flyweight: Nesneleri paylaşarak, nesne sayısını azaltmak.
Sineksıklet kalıp hafıza kullanımını en aza indirebilmek için verileri kendisine benzer olan nesnelerle mümkün olduğu kadar paylaşan nesnelerdir. 
Başka bir deyişle çok sayıda aynı türden nesneler yaratılacağına tek bir nesneden görsel nesneler yaratarak kalabalık bir nesne yapısı kurulmasına olanak sağlar.
---------------------------------------------------
Proxy: Bir nesneye erişimi kontrol etmek.
Vekil kalıp internet bağlantıları, yüksek miktarda hafıza kullanımları, dosyalar veya başka türlü tüm karmaşık pahalı 
ve yapım aşaması zorlayıcı olan nesnelerin tek bir arayüz tarafından kullanılmalarını olası kılar
veriye erişimi kontrol etmek

