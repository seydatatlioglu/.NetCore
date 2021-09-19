# FinalProject

<p>E-ticaret siteleri için kullanılabilir.<br>
.NetCore ile geliştirilmiştir.

Kayıt olma fonksiyonunda kullanıcının şifresi veritabanında hash ve salt yöntemleri ile depolanır. <br>
Kullanıcının güvenliği bu şekilde sağlanır.

<h3>FONKSİYONLAR</h3>

Bütün fonksiyonlar CRUD mantığı ile yazılmıştır. <br>
<h3>
1.Kullanıcı fonksiyonları: </h3>
<ul> 
  <li> 1.1:Register </li>
  <li>1.2:Login </li>
  </ul><br>
<h3>
2.Ürün İşlemleri</h3>
<ul>
<li>  2.1:Ekle</li>
  <li>2.2:Sil</li>
  <li>2.3:Güncelle</li>
  <li>2.4:Listele</li>
  </ul><br>
  
  <h3>
3.Yetkin Kullanıcılar:</h3>
 
 Yetkin kullanıcılar, ürünler için; ekleme, silme ve güncelleme işlemleri yapabilir. 
 Bunun için JWT kullanılarak bir token oluşturulur ve yetkinlik kontrolü yapılır.
 <ul>
 
 <li>3.1:User</li>
 <li>3.2:OperationClaim</li>
 <li>3.3:UserOperationClaim</li>
  </ul><br>
 <h3>
4.Sepet  İşlemleri</h3>
<ul>
<li>  4.1:Ekle</li>
  <li>4.2:Sil</li></ul><br>
  
 <h3>
5.Doğrulama İşlemleri</h3>
<ul>
<li> 
  5.1:Ürün Bilgisi doğrulama</li>
  <li> 5.2:Kullanıcı Bilgisi Doğrulama </li></ul><br>
  
  <h3>
6.Kullanılan Paketler</h3>
<ul>
  <li>6.1:FluentValidation</li>
  <li>6.2:Autofac</li>
  <li>6.3:Autofac.Extensions.DependencyInjection</li>
  <li>6.4:Autofac.Extras.DynamicProxy</li>
  <li>6.5:Microsoft.Extensions.Identity.Core</li>
  <li>6.6:Microsoft.AspNetCore.Http</li>
  <li>6.7:Microsoft.AspNetCore.Http.Abstractions</li>
  <li>6.8:Microsoft.EntityFrameworkCore.SqlServer</li>
  <li>6.9:Microsoft.Extensions.Configuration</li>
  <li>6.10:Microsoft.Extensions.Configuration.Binder</li>
  <li>6.11:Microsoft.AspNetCore.Authentication.JwtBearer </p></li></ul>


  
  
  

 
 
 
 


