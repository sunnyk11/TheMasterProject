using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheMasterProject.Controllers
{
    public class DealerController : Controller
    {
        public string GetUserId()
        {
            var userId = Session["UserId"].ToString();
            return userId;
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}