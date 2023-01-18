Command Pattern

isteyen ile isteği yerine getiren arasındaki bağımlılığı azaltmak ve isteği nesne olarak ifade etmek istediğimizde Command kalıbını kullanırız.

Command nesneleri, isteği metot olarak soyutlamak yerine daha yetkin bir şekilde sınıf olarak soyutlayan nesnelerdir.

Strategy, bir algoritmayı soyutlarken Command bir isteği soyutlamaktadır.
Strategyde algoritmanın ismi bellidir ama implementasyonlar farklılaşmaktadır.
Command'de algoritmanın ismi de belli değildir bu yüzden execute gibi genel bir isim kullanmaktadır.
