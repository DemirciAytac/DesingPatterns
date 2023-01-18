Factory Method( Üretici Method)

Nesnelerin yaratılmaları soyutlamakta ve üretici method dediğimiz Factory metoduna havale etmektir.
Nesne yaratma sorumluğu Clientin üzerinden alınmış olur.
Factory dmethod sayesine, bir çok istemci tarafından yeniden kullanılabilecek bir nesne oluşturma mantığını kapsar.
----------------------------------------------------------------------------------------------------------------------------------
1. Static Factory Method
Nesnelerin yaratılması Constructer ile yapıldığında birden fazla constructerın olduğu bir sınıfın nesnesini 
yaratmak zor olacaktır.Her biri çok parametre alan constructerlar varsa clientin hangi constructerin seçileceğini bilmek gerekir.

Her bir nesne yaratımının özelliği neyse ona göre static factory method ismi verilerek daha az parametreli ve
daha anlaşılır bir yapı kurulmuş olur. Burada önemli olan parametre sayısını azaltıp bu bilgiyi static metod ismine yüklemek.

-----------------------------------------------------------------------------------------------------------------------------------
2. Asynchronous Factory Method
Constructer ile nesne oluşturdugumuz zaman async keywordünü kullanamayız. Nesneyi asenkron bir şekilde 
oluşturmamız gerektiğinde  Asynchronous Factory Method ile yapabiliriz.

-----------------------------------------------------------------------------------------------------------------------------------
3. Parameterized Factory Method
Parametreli bir factory method, bir girdi parametresine dayalı olarak belirli bir nesne türü oluşturur ve döndürür.

Bir parametre alıp bu parameye göre control yapıldığı zaman her yeni eklenen özellik için yeni bir  if-else yada switch bloğu
eklenir böyle olduğu içinde Open Closed Prensibine aykırılık oluşturuyor. Ve Bir sınıf içinde birden çok nesne türünün 
üretimi olduğu için de Single Responsibility prensibine aykırılık oluşuyor.

-----------------------------------------------------------------------------------------------------------------------------------
4. Inner FactoryFabrika yöntemlerinin nereye yerleştirileceğine karar vermek söz konusu olduğunda kullanabileceğimiz 
çeşitli seçenekler vardır.

******In the original class******
En basit yaklaşım factory metodları doğrudan oluşturdukları sınıfa koymaktır.
Bu yaklaşım genellikle statik factory metodları fabrika yöntemleri basit olduğunda ve birkaç satır kod içerdiğinde seçilir.

Statik fabrika yöntemlerini orijinal sınıfa koymanın dezavantajı, tek sorumluluk ilkesini ihlal etmesidir, 
çünkü sınıf - birincil sorumluluğuna ek olarak - kendini nasıl yaratacağını bilir.

Avantajı yüksek kohezyondur. Fabrika yöntemleri, somutlaştırdıkları sınıfa mümkün olduğunca yakın yerleştirilir.

******In a separate class******
Statik Factory Method için başka bir konum ayrı bir sınıftır.
Bu yaklaşım, tek sorumluluk sorununu çözer, ancak başka, daha ciddi bir sorun ortaya çıkar. 
Term sınıfının constructerı artık public olmalıdır. Aksi takdirde, fabrika yöntemleri Term örneğini oluşturamaz.

Hem public constructerlara hem de factory metodlara  sahip olmak, sınıfı somutlaştırması gereken istemcilerin
kodu doğru kullanmasını zorlaştırır çünkü mevcut iki seçenek arasında seçim yapmak zorunda kalırlar.Hem clasın contructerindan
hemde factory sınıfının statik metodundan oluşturulabilir.

Hem Termfactory üzerinden Term nesnesi oluşturulabilir hem de Term sınıfının constructeri üzerinden nesne oluşturulabilir.
Client için 2 yöntem vardır ve bu da kafa karıştırabilir.

******In the inner class******
inner factory, önceki iki yaklaşımın dezavantajlarını azaltmaya yardımcı olur.

Inner Factory, dış sınıfın private constructerına  erişebilen bir iç statik sınıftır,
bu nedenle artık bir public constructera  gerek yoktur.

inner factory, .NET built-in type da kullanılır. Örneğin, yeni bir görev başlatma seçeneklerinden biri şöyle görünür:

await Task.Factory.StartNew(() =>
{
    //Code
});

