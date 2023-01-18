Factory Method( Üretici Method)

Nesnelerin yaratılmaları soyutlamakta ve üretici method dediğimiz Factory metoduna havale etmektir.
Nesne yaratma sorumluğu Clientin üzerinden alınmış olur.
Factory method sayesinde, bir çok istemci tarafından yeniden kullanılaiblecek bir nesne oluşturma mantığını kapsar.


Facyory-I.png
Eğer Employe,manager hepsi için Constructer parametre sayısı aynı ise aynı factory intefacesini hepsi implemente edebilir.

Factory-II
Eğer Employe,manager hepsi için contrecter parametre sayısı farklı ise hepsi için ayrı ayrı EmployeFactory, ManagerFactory oluşturulması gerekir.


