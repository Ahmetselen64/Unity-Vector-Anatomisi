# Unity Vector3 Fizik Parkuru 🎮

Bu proje, Unity oyun motorunda `Vector3` kütüphanesinin temel matematiksel ve fiziksel işlevlerini uygulamalı olarak göstermek amacıyla hazırlanmış bir eğitim ve test parkurudur. Bursa Uludağ Üniversitesi Yönetim Bilişim Sistemleri (YBS) bölümü oyun programlama projesi kapsamında geliştirilmiştir.

## 📹 Proje Tanıtım Fotoğrafı
   <img width="1903" height="831" alt="Ekran görüntüsü 2026-03-12 022342" src="https://github.com/user-attachments/assets/c1ce6165-419b-48c5-998c-b23bd1a89470" />
         <img width="1901" height="828" alt="Ekran görüntüsü 2026-03-12 022328" src="https://github.com/user-attachments/assets/42b5232e-98fc-4a72-8004-a2873b448156" />
          

---

## 🛠️ Parkur İstasyonları ve Kullanılan Fonksiyonlar

Bu test parkuru, 4 farklı istasyondan oluşmaktadır. Her bir istasyon, oyun geliştirmede sıkça kullanılan farklı bir vektör mekaniğini temsil eder:

### 1. Mesafe Ölçer (Distance)
* **Kullanılan Komut:** `Vector3.Distance`
* **İşlev:** Karakter ile hedef obje arasındaki mesafe dinamik olarak ölçülür. Belirli bir mesafenin altına inildiğinde (yaklaşıldığında) sistem tehlike durumu algılar ve objenin materyal rengini anlık olarak değiştirir.

### 2. Hareketli Platform (Lerp)
* **Kullanılan Komut:** `Vector3.Lerp` & `Mathf.PingPong`
* **İşlev:** Bir noktanın diğerine yumuşak bir ivmeyle (pürüzsüz) geçişini sağlar. Platform aniden ışınlanmak veya sabit bir hızla gitmek yerine, uç noktalarda yavaşlayarak doğal bir fiziksel süzülme hareketi yapar.

### 3. Vektör Normalizasyonu (Normalize)
* **Kullanılan Komut:** `Vector3.Normalize`
* **İşlev:** Çapraz hareket eden iki objenin hız yarışını simüle eder. Normalize edilmeyen obje (kırmızı), hem X hem Z ekseninde tam güç gittiği için matematiksel olarak daha hızlı ilerler. Normalize edilen obje (mavi) ise yönü korunarak hız vektörü 1'e sabitlenir, böylece oyunlarda "çapraz yürüme hız hilesi" engellenmiş olur.

### 4. Trambolin ve Hazır Yönler
* **Kullanılan Komut:** `Vector3.up`
* **İşlev:** Objeleri zıplatmak için karmaşık koordinat hesaplamaları yerine Unity'nin hazır dünya yönleri kullanılmıştır. Tramboline temas eden `Rigidbody` bileşenli objeler, `Impulse` kuvvetiyle tam yukarı doğru fırlatılır.

---
**Geliştirici:** Ahmet Selen
**Öğrenci No:** 132430070
**Bölüm:** Uludağ Üniversitesi - Yönetim Bilişim Sistemleri (YBS)
