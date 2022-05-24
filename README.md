---
description: 
>- Emrehan Baysal - C#  Basılan tuşu engelleme
---

<img align="right" alt="GIF" src="https://global-uploads.webflow.com/6097e0eca1e875de53031ff6/61bb05edca00197f2e7a19cf_Csharp_Logo.png" width="15%"/>
# 🌱 C# Merkez Bankası Döviz Kuru Bilgilerini Çekme – XML

> 📣 Proje amaçlı yapılmıştır.</br>
> ⏬ Güncelleme yapılmayacaktır. </br>


## 🔰 Ne İşe Yarar
⭐ Basılan tuşu yakalar ve engeller.</br>
❇️ Projenin genel amacı yapılan programlarda veri tabanlarıyla olan iletişim problemleri olduğunda veya db serverine bağlanılmadığında işlerin gecikmesini önlemek amacıyla 1 uzak sunucuda 1 de localde olan db bağlantısı sayesinde bağlantı sürekliliğini sağlamaktır. Uzak sunucu bağlantısı kopsa bile bilgiler local db ye kaydedilmekte bağlantı sağlandığında uzak sunucuya eşitlenme sağlanmaktadır.</br>

          public void DinlenecekTuslariAyarla()
        {
            // hangi tuşları dinlemek istiyorsak burada ekliyoruz                
            klavyeDinleyicisi.HookedKeys.Add(Keys.Delete);
            //Delete tuşunu yakalar

            //basıldığında ilk burası çalışır
            klavyeDinleyicisi.KeyDown += new KeyEventHandler(islem1);
            //basıldıktan sonra ikinci olarak burası çalışır
            klavyeDinleyicisi.KeyUp += new KeyEventHandler(islem2);
        }



## <h3 align="left"> 📫 Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/emrehan-baysal" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="emrehan-baysal" height="30" width="40" /></a>
<a href="https://instagram.com/emrehanbysal" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/instagram.svg" alt="emrehanbysal" height="30" width="40" /></a>
  
</p>

- Website: [emrehanbaysal.xyz](https://www.emrehanbaysal.xyz//)
- Email: [bymrhan@gmail.com](mailto:bymrhan@gmail.com)
