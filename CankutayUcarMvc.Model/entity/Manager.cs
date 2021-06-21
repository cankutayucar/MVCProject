using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.Model.entity
{
    public class Manager : BaseEntity
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
    }
}
