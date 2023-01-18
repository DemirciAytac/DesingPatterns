Part Of Command Pattern

Receiver
Commandden eylemi alan business nesnesidir. Command nesneleri çalıştırıldığında propertyleri değiştirilir.
Bu örnekdte Receiver class Account sınıfıdır.Command nesnesi Account nesnesinin balancesini değiştirecektir.

Command class interface
Command nesnelerimiz, Account nesneleri üzerinde bir function execute eder.
Para eklemek için Deposit clası, para silmek için Withdraw clası ve para aktarmak içinde Transfer classlarına sahibiz.
Tüm command classlarımız(Deposit,Withdraw,Transfer) ITransaction interfacesini implemente edecek.

Command : Receiver üzerindeki bir eylemi yürüten sınıf.
Deposit,transfer,witdraw


Invoker 
TransactionManagerç
Command nesnelerinin tutar ve Client tüm command nesnelerini işlemesini istediğinde her birinde executeyi çalıştırır.

Client : Diğer bölümleri kullanan ana program