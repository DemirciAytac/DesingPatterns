Composite Pattern
Parça-Bütün ilişkisini göstermek için nesneleri ağaç yapılarınada ifade et.
Bileşik nesne, istemcilerin tekil nesneleri ve bu nesnelerin bileşiklerini aynı şekilde işlmesine izin verir.

Problem-I
Sıklıkla parçaların bir araya gelerek, bir bileşik(composite) oluşturduklarını görürüz.
Bileşik nesne(composite object) parçalardan oluşur.
Böyle durumlarda, tek olan parçalarla, bütün olan bileşik nesne arasındaki ilişkiyi yönetmemiz gereklidir.
Ayrıca istemcilerin tek olan parçalarla, bütün olan bileşik nesneleri aynı şekilde kullanabilmelerini isteriz.
Bu şekilde, bileşik nesneyi kullanmanın istemciye fazladan yük getirmemesini sağlarız

Çözüm - I
Composite kalıbında, Öncelikle parçalar ile bütünün ortak bir arayüze sahip olması sağlanır.
- Böylece istemci bileşik nesneyi de parçaları da aynı şekilde kullanır.
Sonrasında, bileşik nesne ile parçalar arasındaki ilişki düzenlenir.
 - Bu amaçla bileşik nesnenin bir torba(Collection) arayüzüne sahip olması sağlanır.
Dolayısıyla istamci, bütün-parça ilişkisinin karmaşıklığından uzak tutulur ve parçalar ile uğraşmayıp, sadece bütün ile iletişimde bulunur.
