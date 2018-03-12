# Sample Razor

Razor Nedir?
Asp.Net Mvc 3** sürümü ile  gelen **razor view engine** görüntüleme biçimidir. **Razor syntax** aracılıyla ana makine kısmında ( server side ) çalışacak kodların ayrımını ' **@** ' işareti aracılıyla yapmaktayız.
```
<!-- Basit biçimde bir değişken tanımladık. -->
@{ var ileti = "Selam Razor"; }
<!-- Şİmdide kullanalım. -->
<p>İletiniz: @ileti</p>`
```
[Ayrıntısı için güzel bir açıklama](http://www.aspmvcnet.com/tr/m/razor/asp-net-mvc-razor-nedir-.html)

# MVC Nedir?
_ASP.NET MVC_, MVC pattern’ini ASP.NET’e eklemek için Microsoft’un geliştirdiği framework’tür.
_MVC_, Model , View , Controller kelimelerinin baş harflerinden oluşur ve her kelime MVC’nin farklı bir katmanını ifade eder.
Şemasal olarak MVC yapısı.;
![alt text](http://www.borakasmer.com/wp-content/uploads/2014/07/MVC_01-285x300.png "MVC Yapısı ")
Bunlar ile ilgili ayrıntıya devam etmek için Bora hocam çok güzel bir yazı yazmış [devamı için](http://www.borakasmer.com/asp-net-mvc-nedir-ne-ise-yarar/)
[Başka bir anlatım](https://youtu.be/1IsL6g2ixak)

Şimdi gelelim bir MVC projesi oluşturmaya. 

## Bir MVC Projesi Oluşturmak. 

Kurum içerisinde visual sutudio 2015 ve 2015 ile uyumlu birkaç eklenti kullanılmakta 
> Örneğin: # Entity Framework Power Tools Beta 4
- Öncelikle VS15 açalım.
-  File > New > Project > Visual C# > Web > ASP .Net Web Application.
- Sonrasındaki ekranda "Select a Template" sekmesinden MVC seçiyoruz ve "OK" diyoruz. 
- Karşımız projemiz ve bizim için ürettiği dosyalar gelitor peki bunlar nedir ne işe yarar. 
- 

| View       | MVC View’lerininbulunduğu klasördür. HTML, Razorveya Webformformatında olabilirler.                                                                                                                                                                                       |
|------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Model      | Model class’larınınbulunduğuklasördür. Örneğin: Müşteri sınıfı ve validasyonları.                                                                                                                                                                                         |
| Controller | Action’larasahip Controller’larınyer aldığı klasördür. İstemciden request’ialır,uygun action’ıtetikler, modelden doğru nesneyi yaratır ve View’abindeder. View kullanıcıya responseolarak gösterilir.                                                                     |
| Script     | Javascript dosyalarının yeraldığı klasördür. DefaultjQuerydosyaları yer alır.                                                                                                                                                                                             |
| Content    | CSs dosyalarının bulunduğu klasördür.                                                                                                                                                                                                                                     |
| App_Data   | VerilerXML, txtgibi dosyalarda saklanıyorsa, bu dosyaların yer aldığı klasördür.                                                                                                                                                                                          |
| Layout     | •Uygulamalarda genelde değişmeyen UI elemanlarıbulunmaktadır (Logo, üst menü, alt menü, navigasyonbar). •ASP.NET MVC içerisindeki LayoutView’larsayesinde her sayfadabu ortak kısımları kodlamak zorunda kalmayız. ASP.NET Web Forms içerisindeki Master Page’lerebenzer. |
Dosya yapısınıda bu şekilde. 

