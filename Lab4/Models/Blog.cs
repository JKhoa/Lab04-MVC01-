using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }

        [Display(Name = "Mã Blog")]
        public int BlogId { get; set; }
        
        [Required]
        [StringLength(100)]
        [Display(Name = "Tên Blog")]
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}