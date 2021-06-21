using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.Model.entity
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductPhotos = new HashSet<ProductPhoto>();
            ProductComments = new HashSet<ProductComment>();
        }

        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? discount { get; set; }
        public string ShortDescription { get; set; }
        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; }
    }
}
