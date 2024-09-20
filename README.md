

# SavasOyunu

**SavasOyunu**, Windows Forms kullanılarak C# dilinde geliştirilmiş bir karakter tabanlı savaş oyunudur. Oyuncular, farklı büyü branşlarından, ırklardan ve silahlardan bir karakter seçip düşmanlarına saldırır. Oyuncunun saldırı gücü, seçtiği özellikler ve rastgele bir hasar değeri ile hesaplanır.

## Özellikler

- **Karakter Seçimi:** Oyuncular, karakterlerinin ismini, branşını, ırkını ve silahını seçebilirler.
- **Saldırı Sistemi:** Oyunun saldırı gücü, seçilen branş, ırk ve silah doğrultusunda hesaplanır.
- **Düşman Can Barı:** Oyuncular düşmana saldırır ve düşmanın can barı buna göre azalır. Düşman canı sıfıra ulaştığında oyun sona erer.
- **Dinamik Hesaplamalar:** Her saldırıda karakter özelliklerinden gelen sabit bonusların yanı sıra rastgele bir hasar elemanı da vardır, bu da her saldırıyı eşsiz kılar.

## Karakter Sınıfları

- **Branşlar:**
  - Karabüyü: +50 saldırı gücü
  - BüyülüSilah: +65 saldırı gücü
  - Iyileştirici: +35 saldırı gücü
  - EjderhaGücü: +45 saldırı gücü
- **Irklar:**
  - Şaman: +3 saldırı gücü
  - Sura: +5 saldırı gücü
- **Silahlar:**
  - AntikaÇan: +15 saldırı gücü
  - DolunayKılıcı: +25 saldırı gücü

## Rastgele Saldırı Gücü

Her saldırıya 0 ile 65 arasında rastgele bir bonus hasar eklenir.

## Kullanım

1. **Karakterinizi Seçin:** İsminizi girin, branşınızı, ırkınızı ve silahınızı seçin.
2. **Düşmana Saldırın:** 'Saldır' butonuna tıklayın. Saldırı gücünüz hesaplanacak ve düşmanın canı azalacaktır.
3. **Oyunu Kazanın:** Düşmanın canı sıfıra ulaştığında oyunu kazanırsınız.
