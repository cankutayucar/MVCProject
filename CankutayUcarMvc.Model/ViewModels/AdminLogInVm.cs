using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.Model.ViewModels
{
    public class AdminLogInVm
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool? rememberMe { get; set; }
    }
}
