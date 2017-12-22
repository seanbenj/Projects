using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace AJAXCOUPONPRJ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public Boolean ValidateCoupon(string couponEntry)
        {
            if (couponEntry.Trim().Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}