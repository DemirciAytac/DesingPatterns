Builder Pattern

Sıklıkla nesneler dolayısıylada yaratılmaları karmaşıktır.
Bir nesnenin karmaşık olduğunun en temel göstergesi, çok parametre alan constructerlarının olmasıdır.
Böyle karmaşık nesneleri constructerla yaratmak yerine süreç içerisinde yaratılmasını yani teker teker eklenerek inşa edilmesini önerir.

En basit haliyle Builder, nesnenin varsayılan constructırını çağırıp sonrasında SET metotlarıyla nesneyi bina eder ve oluşan nesneyi istemciye geri döndrürür.

Builder kalıbının amacı, karmaşık olan nesne yaratma sürecini yönetmektir.
Factory Method ve Abstract Factory kalıpları ise sadece nesne yaratma sorumluluğunu devir almak içindir. Nesne tabanlı programlamanın özü sınıflara dayanır. 
Sınıflardan nesneler yaratırız. Bunu yapmak için de constructorları kullanırız. 
Sınıfımızda bulunan field sayısı fazla olursa bundan dolayı birden çok constructora ihtiyaç duyabiliriz. 
Haliyle her bir field eklendiğinde yeni bir constructor ekleme ihtiyacı hissedebiliriz. 
Çünkü nesneyi oluştururken hangi field başta atama yapılacak ya da yapılmayacak bilemeyebiliriz. 
İşte bu uzayıp giden parametre sayısından, karmaşık constructorlardan kurtarmak için Builder Pattern güzel bir çözüm sunuyor

