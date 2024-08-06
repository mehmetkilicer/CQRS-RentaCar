# Vehicle Rental Management System

Bu proje, CQRS ve Mediator tasarım desenlerini kullanarak geliştirilmiş bir .NET Core MVC uygulamasıdır. Proje, araç kiralama hizmeti sunan bir sistemdir ve kullanıcıların araçları listeleyip, filtreleyerek gidiş-geliş lokasyon ve tarih bilgilerine göre uygun araçları görüntülemelerine olanak tanır.

## Özellikler

- Tüm araçları listeleyebilme
- Lokasyon ve tarih bilgilerine göre araçları filtreleyebilme
- Marka, Araç ve Araç Özellikleri olmak üzere birbirine bağlı 3 tablo yapısı


## Proje Mimarisi

Bu proje, CQRS ve MediatR tasarım desenlerini kullanarak geliştirilmiştir. Komutlar ve sorgular ayrı katmanlarda düzenlenmiş ve MediatR aracılığıyla yönetilmektedir. Bu yaklaşım, kodun daha modüler, ölçeklenebilir ve bakımının kolay olmasını sağlamaktadır.

### CQRS

CQRS (Command Query Responsibility Segregation), komutların (yani veri değiştiren işlemler) ve sorguların (yani veri okuma işlemleri) ayrılması prensibine dayanır. Bu projede, komutlar ve sorgular ayrı katmanlarda ele alınmıştır.

### MediatR

MediatR, komut ve sorguların yönetilmesini sağlayan bir kütüphanedir. Bu proje, MediatR kullanarak komut ve sorguların işlenmesini yönetir.

## Veritabanı Yapısı

Proje, CodeFirst yaklaşımı ile geliştirilmiştir. Üç ana tablo bulunmaktadır:

1. Marka (Brand)
2. Araç (Vehicle)
3. Araç Özellikleri (Vehicle Features)

Bu tablolar birbiriyle ilişkili olarak yapılandırılmıştır.

## Ekran Görüntüleri

### Ana Sayfa
![Screenshot_9](https://github.com/user-attachments/assets/52ffe10a-43d7-472b-a861-6b783d6cc019)


### Araç Listeleme
![Screenshot_1](https://github.com/user-attachments/assets/39e41b9a-45a3-41fb-91b3-18a7b1228ae4)


### Araç Filtreleme
![Screenshot_2](https://github.com/user-attachments/assets/7f66d111-2b5b-4149-aa7a-42e098c18efb)

