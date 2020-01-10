using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Core.Domain.Entities
{
    public class Article : BaseEntity
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Theme cannot exceed 100 characters")]
        public string Theme { get; set; }
        [Required]
        public string Content { get; set; }
        
        [Required]
        public string ArticleImage { get; set; }
        public ICollection<ArticleTag> ArticleTags { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public User User { get; set; }
    }
}
