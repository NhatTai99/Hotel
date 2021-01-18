using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class LienHeAdminController : Controller
    {
        // GET: Admin/LienHeAdmin
        [Authorize(Roles = "Admin,Manager")] 
      
        public ActionResult Index()
        {
            var db = LienHeBUS.DanhSach();
            return View(db);
        }
        [HttpGet]
        
        public ActionResult xoalienhe(int idLienHe)
        {
            try
            {
              

                // TODO: Add delete logic here
                LienHeBUS.xoalienhe(idLienHe);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}