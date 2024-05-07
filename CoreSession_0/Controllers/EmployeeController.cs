using CoreSession_0.ExtensionMethods;
using CoreSession_0.Models.ContextClasses;
using CoreSession_0.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreSession_0.Controllers
{
    //Bir Employeer ismi ve soyismini girip SignIn Action'ina post yapsın.
    //Eger o isimde ve soyisimde bir Employee varsa bu employee nesnesi Session'a eklensin
    //ve onu 3. bir Action'a yönlendirerek Session bilgisindeki ismi ve soyismi yazdırın
    //eger öyle bir Employee yoksa ViewBag.Message'de "Böyle bir calısan yoktur" diye mesaj cıkarıp SignIn sayfasında kalmasını saglayın...
    public class EmployeeController : Controller
    {
        NorthwindContext _db;

        public EmployeeController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(Employee item)
        {
           Employee e =  _db.Employees.FirstOrDefault(x=>x.FirstName == item.FirstName &&x.LastName == item.LastName);
            if(e == null)
            {
                ViewBag.Message = "Calısan bulunamadı";
                return View();
            }
            HttpContext.Session.SetObject("cagri", e);
            return RedirectToAction("GetSessionData");
        }

        public IActionResult GetSessionData()
        {
            return View();
        }
    }
}
