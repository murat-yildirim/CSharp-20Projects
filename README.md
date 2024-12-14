<h2>💻 C# ile 20 Proje Uygulamaları</h2>
Murat Yücedağ hocamın eğitmenliğinde gerçekleştirilen "C# ile 20 Derste 20 Proje" kursunda geliştirdiğim 19 projeyi sunuyorum. Proje içerikleri ve açıklamaları şu şekildedir:

<h3>1.Proje : ADO.NET ile Müşteri ve Şehir Yönetim Uygulaması</h3>
ADO.NET kullanılarak bir Müşteri Formu ve bir Şehir Formu oluşturulmuştur. Her iki formda da CRUD işlemleri yapılmıştır. Ayrıca Stored Procedure kullanılarak müşteri kayıtları listelenmiş ve Inner Join ile müşteri bilgileri ile şehir bilgileri birleştirilmiştir.

<h3>2.Proje : Entity Framework ile DB-First Müşteri Uygulaması</h3>
Entity Framework kullanılarak Database-First yaklaşımı ile bir uygulama geliştirilmiştir. Uygulama Kategori ve Ürün olmak üzere iki form içerir. Kategoriler ve ürünler için CRUD işlemleri yapılmış ve ürünler kategorilere göre yönetilmiştir. Ayrıca LINQ sorguları kullanılarak ürünlerde listeleme ve arama işlemleri gerçekleştirilmiştir.

<h3>3.Proje : Entity Framework Metotları ile İstatistik Uygulaması</h3>
Projede Entity Framework kullanılarak hazırlanan bir veritabanı üzerinden istatistiksel veri analizi yapıldı.<br><br>
<li>20 farklı sorgu hazırlandı.</li>
<li>Veriler Entity Framework metotları ile dinamik olarak forma taşındı.</li>
<li>LINQ Sorguları ile farklı koşullarda veri filtreleme listeleme ve hesaplama işlemleri gerçekleştirildi.</li>
<li>SQL sorguları ile doğrudan ve LINQ tabanlı sorgularla performans farkları test edildi.</li>

<h3>4.Proje : Code First ile Film ve Dizi Kayıt Uygulaması</h3>
Bu projede Entity Framework Code First yaklaşımı kullanılarak bir film ve dizi kayıt sistemi geliştirilmiştir.<br><br>
<li>Projede Film Kategorileri ve Filmler olmak üzere iki ayrı form bulunmaktadır.</li>
<li>Her iki formda da CRUD işlemleri yapılmaktadır.</li>
<li>Kategoriye göre eklenen filmlerin takibi yapılmaktadır.</li>
<li>İlişkili tabloların bulunması sebebiyle, listeleme işlemleri gerçekleştirilirken LINQ sorguları ile Join işlemi uygulanarak tablolar birleştirilmiş ve ilişkilendirilmiş veriler dinamik şekilde listelenmiştir.</li>

<h3>5.Proje : Dapper ile Ürün-Kategori Uygulaması</h3>
Bu projede Dapper ORM kullanılarak ürün ve kategori işlemleri gerçekleştirilmiştir. <br><br>
<li>Microsoft tarafından sunulan örnek Northwind veritabanı kullanılmıştır.</li>
<li>Veritabanı modellerini temsil eden DTO (Data Transfer Object) sınıfları oluşturulmuştur.</li>
<li>Dapper ile veritabanı üzerinde CRUD işlemleri yapılmıştır.</li>
<li>Performansı artırmak ve asenkron programlama desteği sağlamak için tüm veritabanı işlemleri async metotlarla gerçekleştirilmiştir.</li>

<h3>6.Proje : API ile Hava Durumu Uygulaması</h3>
Bu projede ASP.NET Core API kullanılarak şehirlere ait hava durumu bilgileri sağlanmıştır.<br><br>
<li>API üzerinde HttpGet, HttpPost, HttpPut ve HttpDelete metotları kullanılarak CRUD işlemleri gerçekleştirilmiştir.</li>
<li>Veritabanı tasarımı için Entity Framework Core'un Code First yöntemi kullanılmıştır.</li>

<h3>7.Proje : API Consume Projesi</h3>
Bu proje bir Console Uygulaması olarak geliştirilmiştir ve bir API'yi tüketerek(Consume) çeşitli işlemler gerçekleştirmektedir.<br><br>
<li>Verileri listeleme, yeni şehir ekleme, silme ve güncelleme işlemleri yapılmıştır.</li>
<li>API ile HttpClient kullanılarak veritabanı üzerinde CRUD işlemleri gerçekleştirilmiştir.</li>

<h3>8.Proje : Rapid API ile Güncel Döviz Kurları</h3>
Bu projede Rapid API kullanılarak anlık döviz kur değerleri alınmış Dolar,Euro,Sterlin para birimlerinden Türk Lirası'na dönüşüm yapabilmesi sağlanmıştır.<br><br>

<h3>9.Proje : MongoDb Sipariş Projesi</h3>
MongoDb veri tabanı kullanılarak sipariş kayıt uygulaması geliştirilmiştir<br><br>
<li>Order koleksiyonu üzerinden CRUD işlemleri gerçekleştirilmiştir</li>
<li>MongoDb’nin NoSQL yapısı sayesinde verilerin hızlı ve esnek bir şekilde yönetilmiştir.</li>

<h3>10.Proje : PostgreSQL ToDoList Projesi</h3>
Bu projede PostgreSQL veri tabanı kullanılarak bir ToDoList uygulaması geliştirilmiştir.Uygulamada kategori işlemleri ve ToDoList işlemleri için iki ayrı form bulunmaktadır.<br><br>
<li>Kategoriler ve görevler arasındaki ilişkiyi yönetmek için Inner Joın kullanılarak tablolar birleştirilip listeleme işlemleri yapılmıştır.</li>
<li>Her görev tamamlandı veya devam ediyor olarak işaretlenebilir bu sayede görevlerin durumu takip edilebilir.</li>

<h3>11.Proje : MongoDb Sipariş Projesi</h3>
Bu proje Console uygulaması olarak geliştirilmiş ve SQL Trigger (tetikleyici) kullanılarak ürünler üzerinde işlem yapılmıştır.<br><br>
<li>Ürünler üzerinde alış veya satış işlemi gerçekleştiğinde ürün stoğu otomatik olarak güncellenmesi sağlanmıştır.</li>
<li>Linq sorgusu kullanılarak ürünler üzerinde CRUD işlemleri yapılmıştır.</li>

<h3>12.Proje : JSON Web Token (JWT) Projesi</h3>
Bu projede JSON Web Token (JWT) kullanarak kullanıcı doğrulama işlemleri gerçekleştirilmiştir.<br><br>
<li>Kullanıcı bilgileri ile JWT token oluşturulmuştur. Oluşturulan token ile kullanıcı doğrulama yapılmış ve doğru ise veritabanındaki veriler başka bir formda listeleme işlemi gerçekleştirilmiştir.</li>

<h3>13.Proje : RapidApi Hava Durumu Kartı Projesi</h3>
Bu projede RapidAPI üzerinden hava durumu verileri çekilerek bir hava durumu kartı uygulaması geliştirilmiştir.<br><br>
<li>RapidAPI kullanılarak gerçek zamanlı hava durumu verileri elde edilmiştir.</li>
<li>Kullanıcıya hava durumu verilerini görsel bir kart şeklinde sunan bir uygulama oluşturulmuştur.</li>
<li>Hava durumu verileri gerçek zamanlı olarak güncellenmektedir.</li>

<h3>14.Proje : SQL ilişki Türleri Uygulaması</h3>
SQL veri tabanında Bire Bir , Bire Çok , Çoka Çok ilişkileri üzerinde çeşitli sorgular yapılmıştır.İlişkili tablolarda veri çekme ve ilişki türlerine göre sorgulama işlemleri yapılmıştır.<br><br>

<h3>15.Proje : Akaryakıt Fiyatları ve Simülasyon Projesi</h3>
Bu projede RapidAPI kullanılarak güncel benzin, motorin ve LPG yakıt fiyatları çekilmiştir. Kullanıcı, yakıt türünü seçip yakıt miktarını girerek ödenecek tutarı hesaplayan bir uygulama geliştirilmiştir.<br><br>

<h3>16.Proje : Mail Gönderme ve Hesap Aktivasyonu Uygulaması</h3>
Bu projede MailKit paketi kullanılarak bir aktivasyon sistemi geliştirilmiştir. Kullanıcılar, kayıt formunu doldurduktan sonra, verdikleri e-posta adresine gönderilen doğrulama kodunu sisteme girerek doğrulama işlemini tamamlarlar.<br><br>
<li>Kullanıcılar kayıt formu üzerinden gerekli bilgilerini girer ve sisteme kaydolurlar.</li>
<li>Kayıt işleminin ardından, kullanıcıya gönderilen aktivasyon kodu ile doğrulama yapılır.</li>
<li>MailKit paketi kullanılarak doğrulama kodu e-posta üzerinden kullanıcıya iletilir.</li>

<h3>17.Proje : Kaggle ile Dataset Uygulaması</h3>
Kaggle sitesi üzerinden Netflix, Pizzas Sales, Superstore veri setleri indirilip veri tabanına import işlemi gerçekleştirilmiştir ve datasetleri üzerinde çalışılmıştır.<br><br>

<h3>18.Proje : SuperStore Dashboard Projesi</h3>
Kaggle sitesinden indirilen SuperStore veri seti kullanılarak çeşitli chart ve widget uygulamaları geliştirilmiştir. Veri seti üzerinden yapılan analizlerle, veriler görselleştirilmiş ve kullanıcıya sunulmuştur.<br><br>
<li>Veri seti üzerinden toplam ürün sayısı widget olarak gösterilmiştir.</li>
<li>Sipariş verilen şehirler analiz edilerek görselleştirilmiştir.</li>
<li>Türkiye'den yapılan siparişler özel olarak çekilmiştir ve görselleştirilmiştir.</li>
<li>Toplam sipariş sayısı da widget olarak sunulmuştur.</li>
<li>Veri seti üzerinde yapılan analizlerle, ilgili veriler detaylı şekilde incelenmiştir.</li>
<li>Ülkeler bazında satışların görselleştirildiği bir grafik oluşturulmuştur.</li>
<li>Siparişlerin öncelik durumu bazında bir grafik tasarlanmıştır.</li>
<li>Verilerin görselleştirilmesi için çeşitli chart'lar (grafikler) kullanılmıştır.</li>

<h3>19.Proje : Anlık Dinamik Restoran Masa Durumu Uygulaması</h3>
Bu projede bir restoranın masa durumu dinamik olarak takip edilmektedir. Veri tabanı üzerinden masaların durumu kontrol edilerek her bir masa için dinamik butonlar oluşturulmuştur. Masaların boş veya dolu olma durumu butonların durumunu etkileyerek kullanıcıya anlık geri bildirim sağlar.<br><br>
<li>Restoranın masa bilgileri ve durumu bir veri tabanı üzerinden yönetilmektedir.</li>
<li>Masa sayısı kadar dinamik butonlar oluşturulmuş, her butonun durumu masa durumuna göre değişmektedir.</li>
<li>Butonlar masaların boş veya dolu durumuna göre aktif veya inaktif hale gelir.</li>
<li>Masaların durumu anlık olarak takip edilip, butonlar dinamik bir şekilde güncellenmektedir.</li>














