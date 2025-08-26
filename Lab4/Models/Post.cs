using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Post
    {
        [Display(Name = "Mã Post")]
        public int PostId { get; set; }
        
        [Required]
        [StringLength(200)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }

        [Display(Name = "Mã Blog")]
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}