using CankutayUcarMvc.Business.Abstract;
using CankutayUcarMvc.Model.entity;
using CankutayUcarMvc.WebUI.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI.Areas.AdminPanel.Components
{
    public class RightMenuDashBarViewComponent : ViewComponent
    {
        private readonly IManagerBs _managerBs;
        public RightMenuDashBarViewComponent(IManagerBs managerBs)
        {
            _managerBs = managerBs;
        }
        public IViewComponentResult Invoke(int id)
        {
            Manager activeMg = HttpContext.Session.GetObject<Manager>("ActiveManager");
            return View(activeMg);
        }
    }
}
