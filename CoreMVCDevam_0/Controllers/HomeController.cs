using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDevam_0.Controllers
{
    public class HomeController : Controller
    {

        //Eger URL patterninizde sizin wildcard'inizde (Action'dan sonraki WildCard'inizda) bir isim belirliyse acacagınız action'in parametresine ancak aynı ismi verirseniz slash ile bir deger gönderebilirsiniz...Eger isimler farklı olursa slash ile o ilgili parametreye degeri gönderemezsiniz bunun icin querystring kullanmanız gerekir...
        //Home/Index?id=2


        //MVC'de bir Action'a bir request vermediyseniz o Action otomatik olarak kendisini HTTPGet request'ine göre ayarlar


        //Eger bir Action'in parametresi program.cs'deki MapControllerRoute'daki wildcard ile eşleşmiyorsa direkt slash ile argüman alamaz...

        //Yeni bir sayfa hazırlayarak (CarpimTablosu isminde) 
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarpimTablosu()
        {
            return View();
        }
    }
}



