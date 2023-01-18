Observer Pattern

Nesneler arsında bire-çoklu bir bağımlılık tanımla öyle ki bir nesnenin durumunda değişiklik olduğunda, 
tüm bağımlı nesneler haberdar edilsin ve otomatik olarak gümcellensin.

Problem
Zaman zaman bir nesnenin durumundaki değişiklikleri takip etmek ve onlardan haberdar olmak isteriz.
Bunu yapmanın bir belli aralıklarla nesnenin durumunu sorgulamaktır.
Bu yaklaşım hem etkili değildir çünkü gereksiz yere devamlı sorgulama gerektirir hem de değişikliklerden anında haberdar olunamaz bir gecikme yaşanır.
