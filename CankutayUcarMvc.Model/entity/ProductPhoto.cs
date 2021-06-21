using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.Model.entity
{
    public class ProductPhoto : BaseEntity
    {
        public string PhotoPath { get; set; }
        public int? ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
