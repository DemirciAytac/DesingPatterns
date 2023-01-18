Chain Of Responsibility

Davranışsal(Behavioral) kalıplardan olan Chain of Responsibility deseni, 
ortak bir mesaj veya talebin(Request), birbirlerine zayıf bir şekilde bağlanmış(Loosly Coupled) nesneler arasında gezdirilmesi
ve bu zincir içerisinde asıl sorumlu olanı tarafından ele alınması gerektiği vakalarda kullanılmaktadır.

İstemci, işlenmesini istediği bilgiyi bu zincirin en başında yer alan nesneye gönderir.
Zincir içerisinde yer alan nesne örnekleride söz konusu içeriği asıl işleneceği yere kadar göndererirler

CoR bir amaca yönelik bir dizi işlemi gerçekleştiren nesnelerin birbirlerinden bağımsız bir şekilde çalışmasını ve her bir nesnenin sadece kendisine
tanımlı işleri yapmasını sağlayan bir design patterindır. Sorumluluk zinciri ismi de burdan gelmektedir.
Bu nesneler arasındaki tek bağlantı mesaj(request) yapısıdır. Bütün nesneler bu mesaj yapısını kullanarak işlerini gerçekleştirir.
Bu nesneler, çalışma yapısı olarak aynı işi yapmalarına rağmen birbirlerinden haberdar olmamaları loosly coupled (gevşek bağlı) nesneler
olarak anılmalarına sebep olmaktadır. 
CoR deseni daha çok bolca if-else blokları geçen yerlerde kullanılmalıdır. Yoksa belli bir süre sonra kodlar kontrolden çıkabilir.

Örnek
bir satın alma sürecinde, ödeme onayının kim tarafından verileceğinde de bu desen göz önüne alınabilir.
Bu senaryoda ödeme talimatını onaylayabilecek olan yetkililer bulunur. 
Ancak gelen ödeme talebinin tutarına göre ilk yetkili personel, talebi bir üst yetkiliye iletmek zorunda olabilir. 
Bu durumda yetkililerin bir sorumluluk zincirinin parçası oldukları düşünülebilir. 
Burada en alt yetkiliye gelen ödeme talebi, gerektiğinde zincirin sonunda yer alan en üst yetkiliye kadar gidebilmelidir. 
Ayrıca bu yetkililerin her biri, birbirlerine sadece bu ödeme talepleri kapsamında bağlı olarak düşünülebilir. 
Bir başka deyişle ödeme onayı için her biri kendi sorumluluklarına sahip iken, farklı işlerde birbirlerinden tamamen bağımsızlardır.

