using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelConection;

namespace WEB_datphong.Models.BUS
{
    public class TinTucBUS
    {
        public static IEnumerable<TINTUC> DanhSach()
        {
            var db = new HotelConectionDB();
            return db.Query<TINTUC>("select * from TINTUC");
        }
        public static void them(TINTUC tINTUC)
        {
            var db = new HotelConectionDB();
            tINTUC.NgayDang = DateTime.Now;
            db.Insert(tINTUC);
        }
        public static void xoatintuc(int id)
        {
            var db = new HotelConectionDB();
            var a = db.Query<TINTUC>("Select * from TINTUC Where id='" + id + "' ").FirstOrDefault();
            db.Delete(a);
        }
    }
}