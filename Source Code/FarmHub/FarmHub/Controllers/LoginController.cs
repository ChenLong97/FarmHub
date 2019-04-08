using FarmHub.Areas.Admin.Models;
using FarmHub.Common;
using Model.Dao;
using Model.Dao.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
namespace FarmHub.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new LoginDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.PassWord));
                if (result == "Success")
                {
                    var user = dao.GetUserByID(model.UserName);
                    var userSession = new UserLoginSession();

                    userSession.UserName = user.Name_User;
                    userSession.UserID = user.Id_User;
                    Session.Add(Constant.USER_SESSION, userSession);

                    return RedirectToAction("Index", "Home");
                }
                else if (result == "InCorrect")
                {
                    ModelState.AddModelError("", "Tài Khoản hoặc mật khẩu không chính xác");
                }
                else if (result == "Locked")
                {
                    ModelState.AddModelError("", "Tài Khoản đã bị khóa");
                }
            }

            return View("Index");
        }
    }
}