using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string ApplicationUserID { get; set; }
        [ForeignKey("ApplicationUserID")]
        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Bình luận")]
        public string UserComment { get; set; }
        [Display(Name = "Ngày bình luận")]
        public DateTime CommentDate { get; set; }
        public bool IsClosed { get; set; }
        public virtual ICollection<GameComment> Games { get; set; }
    }
}
