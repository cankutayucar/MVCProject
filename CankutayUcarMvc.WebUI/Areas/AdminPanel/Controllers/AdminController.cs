using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.Model.entity;
using CankutayUcarMvc.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        private readonly IManagerBs _managerBs;
        public AdminController(IManagerBs managerBs)
        {
            _managerBs = managerBs;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            string UN = Request.Cookies["UserNameCK_UN"];
            string PW = Request.Cookies["PasswordCK_PW"];
            if (!string.IsNullOrEmpty(UN) && !string.IsNullOrEmpty(PW))
            {
                ViewData["username"] = UN;
                ViewData["password"] = PW;
                ViewData["rememberme"] = "checked";
            }
            else
            {
                ViewData["rememberme"] = "";
            }
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(AdminLogInVm vm)
        {
            Manager mg = _managerBs.LogIn(vm.userName, vm.password);
            if (mg != null)
            {
                if (vm.rememberMe == true)
                {
                    Response.Cookies.Append("UserNameCK_UN", vm.userName);
                    Response.Cookies.Append("PasswordCK_PW", vm.password);
                }
                else
                {
                    Response.Cookies.Delete("UserNameCK_UN");
                    Response.Cookies.Delete("PasswordCK_PW");
                }
                return Json(new { isok = true });
            }
            else
            {
                return Json(new { isok = false, message = "Böyle Bir Admin Bulunamadı" });
            }
        }


    }
}
