
# **JUGA Clean Architecture Solution Template 💪**

![Clean Architecture](https://codeopinion.com/wp-content/uploads/2021/07/image.png)


🏗️ **Clean Architecture Proje Template**

📌 **Kullanım Durumları**

- Büyük ve Karmaşık Projeler: Projeniz büyüdükçe ve karmaşıklaştıkça, kodun bakımı ve yönetimi zorlaşır. Clean Architecture, kodunuzu modüler hale getirerek bu zorlukları azaltır.
- Test Edilebilirlik: Birim testleri ve entegrasyon testleri yazmak istiyorsanız, Clean Architecture bu süreci kolaylaştırır.
- Uzun Vadeli Projeler: Projenizin uzun vadede sürdürülebilir olmasını istiyorsanız, Clean Architecture, kodunuzu daha esnek ve değişikliklere karşı dayanıklı hale getirir.
- Ekip Çalışması: Farklı ekip üyelerinin aynı projede çalışmasını kolaylaştırır. Herkes kendi modülünde çalışabilir ve bağımsız olarak geliştirme yapabilir.

🎯 **Faydaları**


- **Modülerlik:** Kodunuzu farklı katmanlara ayırarak, her bir katmanın sorumluluklarını net bir şekilde belirler. Bu, kodun daha anlaşılır ve yönetilebilir olmasını sağlar.
- **Bağımsızlık:** İş mantığı, veri erişimi ve kullanıcı arayüzü gibi bileşenler birbirinden bağımsız hale getirilir. Bu, bir bileşende yapılan değişikliklerin diğer bileşenleri etkilememesini sağlar.
- **Test Edilebilirlik:** Kodunuzu daha kolay test edilebilir hale getirir. Birim testleri ve entegrasyon testleri yazmak daha basit olur.
- **Esneklik ve Ölçeklenebilirlik:** Projenizin gereksinimleri değiştikçe, kodunuzu kolayca güncelleyebilir ve ölçeklendirebilirsiniz.
- **Bakım Kolaylığı:** Kodunuzu daha kolay bakım yapılabilir hale getirir. Yeni özellikler eklemek veya mevcut özellikleri güncellemek daha az zaman alır.

⚙️ **CQRS ve Domain-Driven Design (DDD)**

CQRS, sistemin okuma ve yazma işlemlerini ayrı modellerle ele alarak performans ve ölçeklenebilirlik sağlar. CQRS’in başlıca faydaları şunlardır:

- **Performans:** Okuma ve yazma işlemleri ayrı modellerle yönetildiği için, her iki işlem de optimize edilebilir.
- **Ölçeklenebilirlik:** Okuma ve yazma işlemleri bağımsız olarak ölçeklendirilebilir.
- **Bakım Kolaylığı:** Kodun sorumlulukları net bir şekilde ayrıldığı için, bakım ve geliştirme süreçleri daha kolay hale gelir.

**Domain-Driven Design (DDD)**
DDD, karmaşık iş problemlerini çözmek için kullanılan bir yazılım geliştirme yaklaşımıdır. DDD’nin başlıca faydaları şunlardır:

- **Ubiquitous Language:** Tüm ekip üyelerinin aynı dili konuşmasını sağlar, bu da iletişimi ve iş birliğini artırır.
- **Bounded Contexts:** İş problemlerini bağımsız alanlara böler, bu da kodun daha anlaşılır ve yönetilebilir olmasını sağlar.
- **Esneklik:** İş gereksinimleri değiştikçe, kodunuzu kolayca güncelleyebilir ve adapte edebilirsiniz.

**🔗 Clean Architecture, CQRS ve DDD İlişkisi**

Clean Architecture, CQRS ve DDD birlikte kullanıldığında, yazılım geliştirme sürecini daha verimli ve sürdürülebilir hale getirir. 

- Clean Architecture: Kodunuzu katmanlara ayırarak, bağımsız ve modüler hale getirir. Bu, DDD ve CQRS’in uygulanması için sağlam bir temel oluşturur.
- DDD: İş mantığını ve domain modellerini tanımlayarak, Clean Architecture’ın iç katmanlarını zenginleştirir. DDD, domain mantığını merkezde tutarak, iş gereksinimlerine odaklanmayı sağlar.
- CQRS: Okuma ve yazma işlemlerini ayırarak, Clean Architecture’ın katmanlarını daha işlevsel hale getirir. CQRS, performans ve ölçeklenebilirlik sağlar, bu da Clean Architecture ve DDD’nin avantajlarını pekiştirir.
Bu üç yaklaşım birlikte kullanıldığında, yazılım projelerinin daha esnek, ölçeklenebilir ve sürdürülebilir olmasını sağlar.


## Başlarken 🏃

### Adım 1: Projeyi Klonla

Komut:
```bash
git clone 

```

⚠️ NOT: Projeyi indirdikten sonra ana klasör ismini **CleanArchitecture** yapmayı unutmayın.
### Adım 2:  Şablonu Yükle
Kök dosyada aşağıdaki komutu çalıştırın:
```bash
dotnet new install . --force

```
Artık dotnet new juga-clean-arch komutunu tanımladınız.🙏

### Adım 3:  Proje Oluşturma
Projeyi oluşturmak istediğiniz dizinde aşağıdaki komutu yazın:
```bash
dotnet new juga-clean -o Projeİsmi --force

```
Projeniz bu komutla birlikte oluştu. Örnek projeyi ayağa kaldırıp swagger üzerinden test edebilirsiniz. 💪
### Adım 4:  Ayarları Yapılandırma
⚠️ appsettings.json dosyasında;

 - Keycloak,
 - Cache (Redis,InMemory),
 - Connectionstring,
 - Logs,
 - Audit Logs,
 - Secret,
 - Zamanlanmış Görevler,
 - Telemetrik Verilerin Yönetimi,
 - Masstransit ve RabbitMQ ile kuyruk yönetimi,
 - CQRS,
 - Swagger,
 - Backend,
 - Authorization,
 - Elastic Search,
 - Open Telemetry,
 - Health Check,
 - Rate Limiting,
 - Veri tabanı  (Sql Server, Postgres, Mongo Elastic)
 - ve diğer ayarlamaları yapın.

### Adım 5:  Entity ve DbContext Ayarları
Entity ve DbContext ayarlarını tamamlayın.

Veri şeması src/RentACar.sql dosyasında bulunmaktadır. Migration oluşturabilir ya da EF Core Power Tools ile entity ve DbContext oluşturabilirsiniz. 

ConnectionString bilginizi veriyi oluşturduğunuz veri tabanına göre ayarlayınız. 

### Adım 6:  Katkıda Bulunma
Her türlü katkıya açığız!

"# cleanarc" 
