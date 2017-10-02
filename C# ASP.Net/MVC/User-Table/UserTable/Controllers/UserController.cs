using UserTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserTable.Controllers
{
    public class UserController : Controller
    {
        UserModel userModel;

        public UserController()
        {
            userModel = new UserModel();
        }

        public ActionResult GetAll()
        {
            try
            {
                IList<User> allUsers = userModel.GetAllUsers();
                return View(allUsers);
            }
            catch
            {
                return View("Error404");
            }
        }

        [HttpGet]
        public ActionResult Edit(User user, bool forOverload = true)
        {
            try
            {
                var userInfo = userModel.GetUser(user.Id);
                return View(userInfo[0]);
            }
            catch
            {
                return View("Error404");
            }
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            try
            {
                userModel.EditUser(user);
                return RedirectToAction("GetAll");
            }
            catch
            {
                return View("Error404");
            }
        }

        [HttpPost]
        public ActionResult Rearrange(User users)
        {
            try
            {
                userModel.RearrangeUser(users.UserIds);
                return RedirectToAction("GetAll");
            }
            catch
            {
                return View("Error404");
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            try
            {
                return View();
            }
            catch
            {
                return View("Error404");
            }
        }

        [HttpPost]
        public ActionResult Create(User inputUser)
        {
            try
            {
                User user = new User();
                user.Name = inputUser.Name;
                user.Age = inputUser.Age;
                userModel.AddUser(user);
                return RedirectToAction("GetAll");
            }
            catch
            {
                return View("Error404");
            }
        }

        [HttpGet]
        public ActionResult Delete(User user)
        {
            try
            {
                userModel.DeleteUser(user.Id);
                return RedirectToAction("GetAll");
            }
            catch
            {
                return View("Error404");
            }
        }
    }
}