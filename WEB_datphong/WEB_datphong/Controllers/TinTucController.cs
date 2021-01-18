using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_datphong.Models.BUS;
using HotelConection;

namespace WEB_datphong.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult Index()
        {
            var db = TinTucBUS.DanhSach();
            return View(db);
        }
    }
}