# Blog Uygulamas�

Bu proje, basit bir blog uygulamas�n� tasarlamak ve geli�tirmek i�in yap�land�r�lm��t�r. Markdown format�nda yaz�lm�� blog g�nderilerini y�netmek i�in bir API sunmaktad�r.

## Ba�lang��

A�a��daki ad�mlar� izleyerek projeyi yerel geli�tirme ortam�n�za kurabilirsiniz.

### Gereksinimler

- .NET Core SDK
- Bir veritaban� (�rne�in, SQL Server)

### Kurulum

1. Projeyi bilgisayar�n�za kopyalay�n:

   ```sh
   git clone https://github.com/atakan-acar/Blog.git


## Domain-Driven Design (DDD) Yakla��m�

Bu proje, Domain-Driven Design (DDD) prensiplerini temel alarak tasarlanm��t�r. 
DDD, karma��k yaz�l�m projelerini anlamak, tasarlamak ve uygulamak i�in bir yakla��md�r. 
Bu yakla��m, i� mant���n� daha iyi yans�tan, s�rd�r�lebilir ve geni�letilebilir kod tabanlar� olu�turmay� ama�lar.

### Anahtar Kavramlar

Projemizde DDD yakla��m�n� temsil eden baz� anahtar kavramlar:

- **Entity:** Veritaban� nesnelerini temsil eden s�n�flard�r. �rne�in, `BlogPost` s�n�f� bir entitydir.
- **Value Object:** Kimli�i olmayan ve sadece de�erleri temsil eden nesnelerdir. �rne�in, `Title` ve `Content` gibi alanlar bir value object olabilir.
- **Aggregate:** �li�kili entity ve value object'lerin bir araya getirildi�i k�k nesnedir. Bu proje i�inde `BlogPost` aggregate'ini g�r�yoruz.
- **Repository:** Veritaban� i�lemlerini soyutlama katman�d�r. Veritaban� eri�imini saklar ve i� mant���n�n veritaban� i�lemlerinden ba��ms�z olmas�n� sa�lar.

### Proje Yap�s�

Proje yap�s�nda, domain modelleri, servisler ve repository aray�z� ile uygulamas� olmak �zere DDD yakla��m�na uygun katmanlar yer al�r. 
Veritaban� i�lemleri ve i� mant��� ayr� tutularak, kodun daha mod�ler ve anla��l�r olmas� hedeflenir.

DDD prensiplerine uygun olarak, i� mant���n� ve domain yap�lar�n� temsil eden s�n�flar ayr� katmanlarda yer al�r. 
Domain nesneleri ve servisleri, API ve veritaban� i�lemlerinden ba��ms�zd�r ve b�ylece uygulama daha s�rd�r�lebilir hale gelir.

## Daha Fazla Bilgi

E�er Domain-Driven Design hakk�nda daha fazla bilgi edinmek isterseniz, Eric Evans'�n "Domain-Driven Design: 
Tackling Complexity in the Heart of Software" kitab�n� inceleyebilirsiniz. Bu kitap, DDD prensiplerini derinlemesine anlatmaktad�r.