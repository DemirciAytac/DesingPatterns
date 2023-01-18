Memento Pattern(Hatırat, muhafız)

Sarmalamayı bozmadan bir nesnenin iç durumunu yakala ve dışarıya çıkar öyleki nesne bu duruma daha sonra dönebilsin.

Problem
Bazen bir nesnenin durumunu kaydetme ihtiyacı duyulur.
Özellikle bir nesnenin durumu sıklıkla değişiyor ve zaman zaman bu değişiklikleri geri almak(undo) yada geçmişteki bir noktaya dönmek(checkpoint)
söz konusu ise bu ihtiyaç çok daha açık hale gelir.


Çözüm
Memento bir nesnedir ve durumu saklanacak nesnenin bir andaki(snapshot) durumu için muhafızlık yapar.
Memento,gerektiğinde durumu değişen nesnenin durumunu sakladığı hale geri getirmek için kullanılır.
Memento, nesnenin sadece durumu saklanma ihtiyacı duyulan kısmını gereken derinlikte saklar