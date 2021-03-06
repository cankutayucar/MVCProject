using CankutayUcarMvc.WebUI.ActionFilter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashBoardController : Controller
    {
        [AdminLogIn]
        public IActionResult Index()
        {
            return View();
        }
    }
}
