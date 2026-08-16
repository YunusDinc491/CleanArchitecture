Bu proje, Backend Developer olma hedefiyle .NET ekosistemini ve modern backend geliştirme pratiklerini öğrenmek amacıyla geliştirilmiştir. Projenin geneli, çevrimiçi eğitim içerikleri takip edilerek, adım adım uygulamalı olarak inşa edilmiştir; dolayısıyla burada yer alan tasarım kararlarının tamamı bana ait özgün kararlar değildir. Amacım sıfırdan bağımsız bir mimari kurgulamak değil, izlediğim kaynağı takip ederek her adımın ne işe yaradığını ve neden o şekilde uygulandığını anlamaya çalışmaktı.

Bu süreçte konuların bir kısmını sağlam bir şekilde kavradığımı, bir kısmını ise henüz yüzeysel düzeyde anladığımı belirtmek isterim. Yine de bu proje boyunca edindiğim kazanımları aşağıda paylaşıyorum ve bunları ilerleyen projelerimde daha bağımsız ve bilinçli bir şekilde uygulamayı hedefliyorum.

Bu Proje Boyunca Öğrendiklerim

- Katmanlı mimari (layered architecture) ve Clean Architecture yaklaşımının, sorumlulukların Domain, Application, Infrastructure, Persistence ve Presentation katmanları arasında nasıl ayrıştırıldığını öğrendim.
- Bağımlılıkların her zaman dış katmanlardan iç katmanlara (Domain'e) doğru akması gerektiğini, Domain katmanının hiçbir dış pakete bağımlı olmaması gerektiği prensibini kavradım.
- Nesne tabanlı programlamanın temel kavramlarını (soyutlama, kalıtım, çok biçimlilik) uygulamalı olarak deneyimleme fırsatı buldum.
- Sıkça kullanarak başımızın tatlı belası Dependency Injection pratiği yapmış oldum.
- CQRS yaklaşımını, Query ve Command işlemlerinin ayrı sorumluluklar olarak ele alınmasını öğrendim.
- MediatR kütüphanesi ile controller'ların doğrudan servis çağırmak yerine istekleri bir aracı üzerinden ilgili işleyicilere yönlendirmesinin sağladığı avantajları gördüm.
- Entity Framework Core ile Code-First yaklaşımını, migration oluşturma ve veritabanına uygulama sürecini tekrar pekiştirmiş oldum.
- Authentication  ile Authorization kavramları arasındaki farkı öğrendim. (Her zaman Authentication Authorizationdan önce gelir!) 
- ASP.NET Core Identity ile kullanıcı ve rol yönetiminin temellerini, JWT (JSON Web Token) tabanlı kimlik doğrulamanın çalışma mantığını öğrendim.
- FluentValidation kütüphanesi ile gelen isteklerin iş kurallarına göre nasıl doğrulanabileceğini öğrendim.
- AutoMapper ile nesneler arası dönüşümlerin nasıl otomatikleştirildiğini gördüm.
- Uygulama hatalarının veritabanına kaydedilmesi gibi temel izlenebilirlik pratiklerine dair fikir edindim.
- Bağlantı dizeleri ve gizli anahtarlar gibi hassas bilgilerin kaynak kodun içinde tutulmaması, bunun yerine User Secrets gibi mekanizmalarla yönetilmesi gerektiğini öğrendim.

Kullanılan Teknolojiler

- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- MediatR
- FluentValidation
- AutoMapper
- ASP.NET Core Identity ve JWT
- MailKit
- Swagger / OpenAPI

Bu projenin, ilgili alanın tamamına hakim olduğumu değil, öğrenme sürecimde attığım adımlardan birini yansıttığının bilincindeyim. Burada edindiğim kazanımları zaman içinde daha derinlemesine öğrenip, ilerleyen projelerimde daha özgün ve bağımsız bir şekilde uygulamayı hedefliyorum. Geri bildirimlere her zaman açığım.
