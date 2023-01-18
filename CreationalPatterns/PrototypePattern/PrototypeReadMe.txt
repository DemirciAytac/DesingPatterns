Prototype Kalıbı

Factory ve Absract factory nesnenin NEREDE yaratılacağını, Prototype ve Builder ise nesnenin NASIL yaratılacağını belirler.
Prototip bir nesneyi kullanarak yaratılacak nesneleri belirlemek ve yeni nesneleri , prototipi kopyalayarak oluşturmak.

Problem-I
- Uygulamalarda sıklıkla iş alanı(businesss domain) sınıflarında nesneler oluştururuz.
- Bu nesneler zaman zaman yüksek karmaşıklıkta olurlar. Yani constructera cok fazla parametre geçmek gerekiyorsa karmaşıklaşır.
- Nesnelerin karmaşık olması, durumlarının(state) karmaşık olması demektir.

Constracteri karmaşık olan nesleri yaratmak maliyetlidir. Bu maliyetten kurtulmak static olan tek bir nesneyi önceden hazırlayıp  daha sonra bu nesneyi kopyalayarak
buna benzer bir nesneler oluşturabiliriz
Shallow Copy : Nesnenin birebir aynısı referansıda aynı.
Deep Copy : tamamen farklı bir nesne oluşturmak. Referansıda farklı


