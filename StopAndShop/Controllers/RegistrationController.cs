using StopAndShop.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StopAndShop.Entites;
using System.Web.Mvc;

namespace StopAndShop.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            
            return View();
        }

        public JsonResult PopulateGenderList()
        {
            RegistrationService service = new RegistrationService();
            var temp = service.PopulateGenderList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddNewUser(UserDetails data)
        {
            RegistrationService service = new RegistrationService();
            var temp = service.AddNewUser(data);
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult RenderPartial()
        {
            return PartialView("_PartialViewRender");
        }
    }
}