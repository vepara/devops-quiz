# Problem

Iki uygulama ve her ikisinin de kullandigi bir database vardir.

Uygulamalar:

- TechApp

- SideApp

Database

- Postgresql



Calisma sekli

1. Docker-compose ile bu uclunun local ortamda calistirilmasi

2. Db'de logdb database'inde logs tablosunda geldigi uygulama ve tarih kaydi olusturulur.

3. her uygulama'ya /swagger ile girilince ```list``` metodlari bulunur. 

4. TechApp/Swagger > List cagrildiginda bir array json doner.

5. SideApp/Swagger > List cagrildiginda bir array json doner.



Istenenler:

1. Uygulamalarin docker image'leri bir registry'de tutulacak sekilde olusturulmasi (dockerfile projelerde var)

2. Docker compose dosyasi, 3 image'in local ortamda calistiginin gosterilmesi

3. Kubernetes yaml dosyalari
   
      1. NGN'de verilen cluster'in olusturulmasi
   
      2. Cluster'a apply yapilacak yaml dosyalarinin olusturulmasi
         
            1. Ingress yonetimi
         
            2. Service ve Deployment yaml'lari
         
            3. Volume icin yaml
         
            4. Applicationlara ENV'tan verilen connection string'in guvenli/ozel bir yerde tutulmasi
   
      3. {KUBERNETESIP}/tech -> TechApp'a yonlenecek
   
      4. {KUBERNETESIP}/side -> SideApp'a yonlenecek
         
         
