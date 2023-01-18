Strategy Pattern

Bir algoritma ailesi tanımla, algoritmaların her birini sarmala ve onları birbirleri yerine geçebilecek hale getir.
Strateji, algoritmanın onu kullanan istemcilerden bağımsız olarak değişebilmesini sağlar

Problem - I
Yazılım geliştirirken sıklıkla işi yapmadanın birden fazla yolunun olduğu durumlarla karşılaşırız.
 - İş kuralları süreçleri yönlendirir ve süreçlerde dallanmalar olur.
        örn : 18 yaşından küçükse şöyle hesapla, 18 yaşından büyükse böyle hesapla
              0 ile 10 arasındaysa böyle yap, 50 ile 1000 arasında şöyle yap, 100 den büyükse şöyle yap
 - Bu farklı yollar bazen tanımlı algoritmalar olarak karşımıza çıkar bazen ise basitçe farklı yöntemler olur.
  

- Banka sisteminde farklı hesap türlerinin farklı ücret algoritmaları, zamana göre değişen EFT vb. ücretleri vardır.
- Bir veriyi doğrulamanın farklı yolları olabilir.

Yukarıda 1 den fazla yöntemin her birisini If-Else nin bir dalı olarak algoritma ailesini gerçekleştirmek doğru bir çözüm değildir.Değişmeyi göze almaz
Böyle bir yapı SRPyi hemde OCPyi bozar.Birden fazla algoritmayı tek bir yerde tutmak öldürücür.

Sonuç
Ne zaman bir şeyi hesaplamanın farklı yollarıyla karşılaşırsanız, bir iş kuralının bir faktöre göre değişem şekilleri vs. varsa Strategy kalıbını kullanın