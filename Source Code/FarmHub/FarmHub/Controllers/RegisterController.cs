using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao.Trader;

using FarmHub.Common;
using Model.EF.REGISTER;

namespace FarmHub.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TRADER_REGISTER user)
        {
            if (ModelState.IsValid)
            {
                var dao = new RegisterDao();

                var encryptorMD5Pass = Encryptor.MD5Hash(user.UserAu.Password_User);
                user.UserAu.Password_User = encryptorMD5Pass;

                long id = dao.Insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", Common.ErrorList.REGISTER_ERROR);
                }
            }
            return View("Create");
        }
    

        public ActionResult GenderDetail(int id)
        {
            return View();
        }
    }
}
