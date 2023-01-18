Absract Factory

Amaç: Birbirleriyle ilgili yada bağımlı nesne ailelerini, nesnelerin somut sınıflarını belirtmeden yaratmak için bir 
arayüz sağlanır.

Absract Factory tek bir nesne yerine, nesne ailesi oluşturmak için kullanılan bir kalıptır.

Abstract Factory bir sınıf, Factory Method ise bir methodtur.
Factory Method tek bir nesnenin, Absract Factoy ise birden fazla nesnenin yaratılmasını soyutlar.
Bu amaçla Absract Factory birden fazla factory metoda sahiptir.

Normalde Absract Factory ve factory method tek bir kalıptır. Factory Method, Absract factorinin özel bir halidir.

Factory metodla  bir nesne oluştururuz. Absract Fctory ile ise birden fazla ilişkili nesne varsa ve 
bunları birlikte oluşturmamız gerekirse her bir factory metodun bir araya getirildiği bir sınıfta oluşturmamızı sağlar.

*************************************************************************************************************************
EXAMPLE-I

Factory Method tek bir nesne yaratmaktan sorumludur.Yaratılacak nesne bir değil birden çok ise 
yapılacak şey birden fazla Factory Method kullanmaktır.

Elimizde Button,List ve Table gibi componentlerimiz var.Bunların arasında bir ilişki henüz sezmedik.
Bunları yaratan GuiFactory isimli bir interface var. ve bunun üzerindeki create metodunu override eden
ButtonFactory,ListFactory,ButtonFactory gibi yapılarımız var ve bunlarla objeyi oluşturuyoruz.
Yukarıda anlattığımız yapı tamda factory metodun tanımıdır.

*************************************************************************************************************************
EXAMPLE-II

Elimizdeki nesneler, bir nesne ailesi oluşturuyorlarsa yani bu nesneler birbirleriyle ilgili nesnelerse,
her birisi için ayrı ayrı oluşturulan ve farklı sınıflara konan Factory Metodların bir sınıfta toplanması makuldur.

Böylece bir sınıfta toplanan factory metodlar kohezyonu düşürmez.

işte yukarıda anlatılan sınıf absract factorydir.

Absract factory bir sınıf, factory method ise bir metoddur.
Abscract factory, birden fazla factory method bir araya getirilerek oluşturulur.

****************************************************************************************************************************
Example-III
Eğer bir nesne ailesi değilde birden çok nesne ailesi varsa  her aile için farklı bir Absract Factory ve hiyerarşisi olur.