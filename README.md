
** Case 1 (Case.KeyGenerator): Belirli alfabe ile 8 Karakterli Key üreten algoritma.

Gereksinimler: 
* Visual Studio 2022
* .Net 7
* WinForms
** Ekstra bir Nuget Package kullanılmamıştır.

Projenin Çalıştırılması : 
Proje .Net 7 kullanılarak oluşturulmuş Windows Forms uygulamasıdır. Kullanıcı kolaylığı açısından Windows Forms kullanılmıştır.
Solutionu indirdikten sonra Case.KeyGenerator projesine sağ tıklayarak "Set as Startup Project" e tıklayarak çalıştırıp test edilebilir.
Proje çalıştırıldıktan sonra geçerli inputlar doldurularak veya default versiyonları kullanılarak 3 farklı algoritma ile key üretilip test edilebilir.
1. Yöntem :
  - Karakter sayısı kadar alfabeyi birleştirerek karmaşıklığı artırarak string büyütülmüştür. Sonrasında ise oluşan yeni alfabe New.Guid() parametresiyle order
    işlemi yapılarak random keyler üretip sağ taraftaki panele ürettiği keyleri yazmaktadır.
2. Yöntem : 
  - Random kütüphanesinden 0 ile 1 arasında double değer üretip bu değerin 23 ile çarpılarak bir integer sayı elde edip alfabeden o indexe denk gelen karakterin           seçilmesiyle key uzunluğu kadar bu işlemin devam etmesi sonucu üretilen listenin sağ taraftaki listbox üzerinde gösterilmesidir.
3. Yöntem :
  - Diğerlerine nazaran tamamlanmamış ve aynı değeri bir veritabanından kontrol etmeden oluşturulması durumunda aynı şifreyi üretme ihtimali yüksek olan bir               algoritmadır. Algoritma zaman parametresini alarak bu zaman parametrelerinin alfabe modundan üretilen sayının alfabedeki indexine ait karakteri birleştirerek           oluşturulmuş bir algoritmadır. istek üzerine üretmesi amacıyla oluşturulmuştur. Vakit probleminden dolayı tamamlanamamış ve kesin bir sonuç vermemektedir.
4. Kontrol:
  - Algoritmalardan birisini çalıştırdıktan sonra üretilen keylerde aynı key olup olmadığını test etmektedir.


** Case 2 (Case.ReceiptGenerator): Belirli alfabe ile 8 Karakterli Key üreten algoritma.

Gereksinimler: 
* Visual Studio 2022
* .Net 7
* WinForms
** Ekstra olarak "NewtonSoft.JSON" kütüphanesi kullanılmıştır. Çalışmaması durumunda Nuget Package Manager üzerinden son sürümünü kurabilirsiniz.

Projenin Çalıştırılması : 
Proje .Net 7 kullanılarak oluşturulmuş Windows Forms uygulamasıdır. Kullanıcı kolaylığı açısından Windows Forms kullanılmıştır.
Solutionu indirdikten sonra Case.ReceiptGenerator projesine sağ tıklayarak "Set as Startup Project" e tıklayarak çalıştırıp test edilebilir.
Proje çalıştıktan sonra ise istenilirse verilen Default Json ile istenilirse farklı Json dosyası bilgisayardan seçilerek çalıştırılabilir. 
Sağ tarafta bulunan listboxa istenilen çıktıyı. Sol tarafa ise labelları konumlarını görebilirsiniz. Ayrıca listboxtan seçtiğiniz line'ı sağ tarafta backgroundu kırmızı şekilde görüntüleyebilirisiniz.
