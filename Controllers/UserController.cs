using baiTapTuan2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace baiTapTuan2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            User user = new User()
            {
                Account = "sykhang",
                Password = "123khang",
                UserName = "Bạch Sỹ Khang",
                age = 19,
            };
            return View(user);
        }

        [HttpPost]
        public ActionResult Index(User a)
        {
            return View(a);
        }
    }
}