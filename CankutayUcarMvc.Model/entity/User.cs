using System;
using System.Collections.Generic;
using System.Text;

namespace CankutayUcarMvc.Model.entity
{
    public class User : BaseEntity
    {
        public User()
        {
            ProductComments = new HashSet<ProductComment>();
        }

        public DateTime? RegisterDate { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhotoPath { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ProductComment> ProductComments { get; set; }
    }
}
