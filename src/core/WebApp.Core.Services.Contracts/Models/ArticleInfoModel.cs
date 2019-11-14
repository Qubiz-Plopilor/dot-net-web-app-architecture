using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Core.Services.Contracts.Models
{
    [Description("User story info.")]
    public class ArticleInfoModel
    {
        [Description("Article Id.")]
        public int Id { get; set; }

        [Description("Article unique Id.")]
        public Guid UniqueId { get; set; }

        [Description("Article creation date.")]
        public DateTime DateCreated { get; set; }

        [Description("Article last modification date.")]
        public DateTime DateModified { get; set; }

        [Description("Article content.")]
        public string Content { get; set; }

        [Description("User Id.")]
        public int UserId { get; set; }
    }
}
