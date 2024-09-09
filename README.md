## TextBox İle Kelime Seçme ve Çeviri MVC Projesi
### Proje Amacı
Bu proje, bir TextBox içerisindeki metinden fare imleci yardımıyla seçilen kelime veya kelimeleri, bir popup aracılığıyla başka bir dile çeviren bir örnek ASP.NET Core MVC uygulamasıdır. Çeviri işlemi, bir API entegrasyonu kullanılarak gerçekleştirilir ve çeviri sonuçları kullanıcıya anlamlı bir şekilde gösterilir.

### Proje Özellikleri
#### Kullanıcı Etkileşimi: 
TextBox içerisinden seçilen kelime veya kelimeler, bir çeviri popup’ı ile kullanıcıya sunulur.
#### Çeviri API Entegrasyonu: 
Kullanıcının seçtiği metin, bir API yardımıyla (DeepL) istenilen dilden farklı bir dile çevrilir.
#### Dinamik Çeviri Seçenekleri: 
Kullanıcı farklı diller arasında seçim yapabilir ve anında çeviri sonuçlarını görebilir.
#### Basit ve Kullanıcı Dostu Arayüz: 
Seçilen metin ve çeviri popup’ı, kullanıcı deneyimini kolaylaştırmak amacıyla basit bir şekilde tasarlanmıştır.

### Kurulum Talimatları
1. Proje Dosyalarını Klonlayın:

```
git clone https://github.com/enesaks/Dodnet-TranslatePopUp 
cd Dodnet-TranslatePopUp
```

2. API Anahtarı Oluşturma:

* Çeviri için kullanılacak API’ye kaydolun (DeepL).

* [DefaultController](https://github.com/enesaks/Dodnet-TranslatePopUp/blob/main/TranslateApi/Controllers/DefaultController.cs#L21) içierisine API anahtarınızı yerleştiriniz.

3. Bağımlılıkları Yükleyin:

Projeyi ilk kez çalıştırmadan önce gerekli bağımlılıkları yükleyin:

```
dotnet restore
```
4. Projenin Çalıştırılması: 
Projeyi başlatmak için aşağıdaki komutu kullanabilirsiniz:

```
dotnet run
```

## Örnek Video 
[video](https://github.com/user-attachments/assets/e47566c7-bcbb-430a-b53a-282fa565b452
)




