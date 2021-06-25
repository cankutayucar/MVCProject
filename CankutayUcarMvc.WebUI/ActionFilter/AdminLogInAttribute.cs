using CankutayUcarMvc.Model.entity;
using CankutayUcarMvc.WebUI.Helper;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI.ActionFilter
{
    [AttributeUsage(AttributeTargets.All)]
    public class AdminLogInAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Manager mg = context.HttpContext.Session.GetObject<Manager>("ActiveManager");
            if (mg != null && !string.IsNullOrEmpty(mg.UserName) && !string.IsNullOrEmpty(mg.Password))
            {
                return;
            }

            context.HttpContext.Response.Redirect("/admin");

            base.OnActionExecuting(context);
        }
    }
}
