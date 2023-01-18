Factory Method tek bir nesne yaratmaktan sorumludur.Yaratılacak nesne bir değil birden çok ise 
yapılacak şey birden fazla Factory Method kullanmaktır.

Elimizde Button,List ve Table gibi componentlerimiz var.Bunların arasında bir ilişki henüz sezmedik.
Bunları yaratan GuiFactory isimli bir interface var. ve bunun üzerindeki create metodunu override eden
ButtonFactory,ListFactory,ButtonFactory gibi yapılarımız var ve bunlarla objeyi oluşturuyoruz.
Yukarıda anlattığımız yapı tamda factory metodun tanımıdır.