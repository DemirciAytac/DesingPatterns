Bir banka uygulaması yazıyoruz ve burada deposit, witdraw ve transfer işlemleri yapılabiliyor olacak

Burada deposit ve witdraw metodları Account sınıfın içerisine eklenmiştir.
Bu metotlar çağırıldıkları anda bakiyeyi değiştiren para yatırma ve para çekme işlevlerine sahiptirler.
Bazen işlevleri hemen yürütmek istemeyebiliriz.
Bir kuyruğa yazılarak ayrı olarak yapılmasını istediğimiz işlerde Command Patterni kullanabiliriz.
Command Nesneleri bir kuruğa eklenebilir ve muhtemelen farklı bilgisayarlarda çalışan birden çok Invoker nesnesi tarafından handle edilebilir.
Bu programı daha scalable hale getirmenin bir yoludur.
