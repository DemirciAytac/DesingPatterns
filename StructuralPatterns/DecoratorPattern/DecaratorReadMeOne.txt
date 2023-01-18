Decorator Pattern

Decorator tasarım deseninin amacı nesnelere dinamik olarak özellik eklemektir ve nesne kendisi de eklenen özelliklerden habersiz 
ve ayrı bir konumda olmalıdır. Yani kodun belli kısımlarında nesnelere belli özellikler kazandırmak istiyorsak 
ve bunu nesnenin kendi classından ayrıştırılmış bir şekilde yapmak istiyorsak decorator tasarım desenini kullanmalıyız.

Bir nesneye ek sorumlulukları dinamik olarak eklememizi sağlar.
Decoratörler fonksiyonelliği genişletmek için mirasa esnek bir altenatif sağlarlar.
Decoratörler, bezeyicidir.Farklı decoratörler nesneyi sırayla bezeyerek ona yeni sorumluluklar kazandırır.

Problem-I
Sıklıkla, yeni sorumluluğu tüm sınıfa değil, nesnelere eklemek isteriz.
Sorumlulukları sınıfa eklemek için tipik olarak mirası kullanırız.
Sınıflara yetkinlik eklemek için miras kullanmanın en temel sorunu, mirasın bir derleme zamanı yapısı olmasıdır.
- Her yeni yetkinklik için kod değişikliği ve tekrar derleme gerekir.

NOT : Nesneye yeni bir özellik kazndırmak için tek yol miras değildir. Decorator pattern sayesinde miras dısında da nesneye özellik kazandırabiliyoruz.

Çözüm
- Miras ile is-a ilişkisi yerine nesne bileşimi ile has-a ilişkisini kullanmaktır.
- Yeni sorumlulukları yeni alt sınıflarla yerine getirmektense, alt sınıf ihtiyacını doğuran şeyi bir dekorasyon/bezeme malzemesi
olarak görmek ve sınıfın nesnelerine eklemek daha sağlıklıdır.
- Bu şekilde nesnenin en basit halinden başlayarak farklı dekorasyonlar uygulamak mümkün olacaktır.

Sonuçlar
- Decorator kalıbı, sınıf mirasından daha esnek bir yapı sağlar.
- Çünkü bir nesnenin sahip olabileceği özellikleri-sorumlulukları önceden öngörerek sınıfa eklemek yerine, çalışma zamanında
isteğe bağlı olarak nesneye eklenmesine izin verir.
- En negatif yanı ise pek çok ufak Decorator nesnesine sahip olmamızdır.
- Esas nesne dekore edildiğinin farkında değildir.  Yani dekoratör ile eklenen özellikler aslında kendi classı içerisinde barındırdığı özellikler değildir.
- Esas nesnenin classı tüm gerekli gereksiz opsiyonları içerisinde barındıran büyük bir class halinden çıkmış olur.
- Tüm decorator classları birbirinden bağımsızdır.


NOT:
Decorator kalıbının Compositeden farkı,Decoratorde sorumluluk decorator nesnelerinde iken Compositede sorumluluk composite nesnededir.
Bu yüzden Decoratorde bütün-parça ilişkisi yoktur. nesnenin süreç içerisinde benzemesi söz konusudur.

Decorator adaptördende farklıdır çünkü decorator nesnenin arayüzünü değiştirmez, sadece sorumluluk ekler.
Adapter ise uyumsuz nesneye tamamen yeni bir arayüz sağlar
