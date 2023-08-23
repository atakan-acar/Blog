# Blog Uygulamasý

Bu proje, basit bir blog uygulamasýný tasarlamak ve geliþtirmek için yapýlandýrýlmýþtýr. Markdown formatýnda yazýlmýþ blog gönderilerini yönetmek için bir API sunmaktadýr.

## Baþlangýç

Aþaðýdaki adýmlarý izleyerek projeyi yerel geliþtirme ortamýnýza kurabilirsiniz.

### Gereksinimler

- .NET Core SDK
- Bir veritabaný (örneðin, SQL Server)

### Kurulum

1. Projeyi bilgisayarýnýza kopyalayýn:

   ```sh
   git clone https://github.com/atakan-acar/Blog.git


## Domain-Driven Design (DDD) Yaklaþýmý

Bu proje, Domain-Driven Design (DDD) prensiplerini temel alarak tasarlanmýþtýr. 
DDD, karmaþýk yazýlým projelerini anlamak, tasarlamak ve uygulamak için bir yaklaþýmdýr. 
Bu yaklaþým, iþ mantýðýný daha iyi yansýtan, sürdürülebilir ve geniþletilebilir kod tabanlarý oluþturmayý amaçlar.

### Anahtar Kavramlar

Projemizde DDD yaklaþýmýný temsil eden bazý anahtar kavramlar:

- **Entity:** Veritabaný nesnelerini temsil eden sýnýflardýr. Örneðin, `BlogPost` sýnýfý bir entitydir.
- **Value Object:** Kimliði olmayan ve sadece deðerleri temsil eden nesnelerdir. Örneðin, `Title` ve `Content` gibi alanlar bir value object olabilir.
- **Aggregate:** Ýliþkili entity ve value object'lerin bir araya getirildiði kök nesnedir. Bu proje içinde `BlogPost` aggregate'ini görüyoruz.
- **Repository:** Veritabaný iþlemlerini soyutlama katmanýdýr. Veritabaný eriþimini saklar ve iþ mantýðýnýn veritabaný iþlemlerinden baðýmsýz olmasýný saðlar.

### Proje Yapýsý

Proje yapýsýnda, domain modelleri, servisler ve repository arayüzü ile uygulamasý olmak üzere DDD yaklaþýmýna uygun katmanlar yer alýr. 
Veritabaný iþlemleri ve iþ mantýðý ayrý tutularak, kodun daha modüler ve anlaþýlýr olmasý hedeflenir.

DDD prensiplerine uygun olarak, iþ mantýðýný ve domain yapýlarýný temsil eden sýnýflar ayrý katmanlarda yer alýr. 
Domain nesneleri ve servisleri, API ve veritabaný iþlemlerinden baðýmsýzdýr ve böylece uygulama daha sürdürülebilir hale gelir.

## Daha Fazla Bilgi

Eðer Domain-Driven Design hakkýnda daha fazla bilgi edinmek isterseniz, Eric Evans'ýn "Domain-Driven Design: 
Tackling Complexity in the Heart of Software" kitabýný inceleyebilirsiniz. Bu kitap, DDD prensiplerini derinlemesine anlatmaktadýr.