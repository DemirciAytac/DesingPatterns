Proxy Pattern(Vekil)

Ona olan erişimi kontrol etmek amacıyla bir başka nesne için geçiş ya da ara nesne(gerçeği yerine geçem sahte nesne) sağla.

Problem - I
Farklı sebeplerden dolayı bir nesneye olan erişimi kontrol etmek gerekebilir.
Bu sebepler, güvenlik, maliyet, teknik kısıtlar vs. olabilir.
Güvenlik : Nesnenin kendisinin de nesneye ulaşması tehlikeli olabilir.
Maliyet : Nesneyi oluşturmayı ihtiyaç anına kadar geciktirmek

Problem-II
Teknik kısıtlar : Nesne Erişim dışında olabilir.
	- Nesne uzak nesnedir, dışarıdan yalıtılmıştır,nesne thread-safe değildir.
Katma değerli hizmetler : Nesneye ulaş ama doğrudan ulaşma. Nesneye erişim öncesinde ve sonrasında farklı işler yapmak gerekebilir-
	- Erişim isteklerini saymak istiyor olabiliriz, Nesneye erişimi düzenlemek ve bir kuyruğa sokmak isteyebiliriz, Ulaşımla ilgili loglar tutmak istiyor olabiliriz.
	- Nesnenin işi uzun sürmektedir ve bu sebeple senkron yerine asenkrom erişim söz konusudur.

Problem - III
Nesneye erişimin kontrol sebebi durumları, nesne üzerinde gidermeye çalışmak nesnenin kohezyonunu düşürür. örn. nesnenin erişim sayısını bulmak için
nesnenin içine count isminde field koyup arttırırız. Buda doğru bir çözüm değildir.

Bu kısıtları istemciden yalıtmak gerekir.
	- istemci olabildiğince kısıtlardan haberdar olmamalı, sanki asıl nesneyle çalışıyormuş gibi normal çalışmasına devam etmelidir.
	- Şu durumda önemlidir. İstemci önceden asıl nesneye doğrudan ulaşıyordur ama sonrasında katma değerler devreye girmiştir ve istemcide hiç bir
	  değişiklik yapmadan önlem almak gerekir.


Diğer Kalıplarla ilişkisi
Proxy ile adapter arasındaki fark, proxynin sakladığı nesne ile aynı arayüzde olmasına karşın Adapter farklı arayüzdedir