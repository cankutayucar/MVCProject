﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.Model.entity
{
    public class ProductComment : BaseEntity
    {
        public DateTime? CommentDate { get; set; }
        public string Comment { get; set; }
        public int? ProductID { get; set; }
        public int? UserID { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
