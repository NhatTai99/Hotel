using HotelConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;

namespace WEB_datphong.Areas.Admin.Controllers
{
    public class TinTucAdminController : Controller
    {
        // GET: Admin/TinTucAdmin
        [Authorize(Roles = "Admin,Manager")]

        public ActionResult Index()
        {
            var db = TinTucBUS.DanhSach();
            return View(db);
        }
        public ActionResult xoatintuc(int id)
        {
            try
            {


                // TODO: Add delete logic here
                TinTucBUS.xoatintuc(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult them()
        {
       
            return View();
        }
        [HttpPost]
        public ActionResult them(TINTUC tINTUC )
        {
            try
            {
                // TODO: Add insert logic here
                TinTucBUS.them(tINTUC);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}