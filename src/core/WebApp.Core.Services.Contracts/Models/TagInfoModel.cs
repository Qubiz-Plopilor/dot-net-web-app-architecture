using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebApp.Core.Services.Contracts.Models
{
    [Description("Tag story info.")]
    public class TagInfoModel
    {
        [Description("Tag Id.")]
        public int Id { get; set; }

        [Description("Tag unique Id.")]
        public Guid UniqueId { get; set; }

        [Description("Tag creation date.")]
        public DateTime DateCreated { get; set; }

        [Description("Tag last modification date.")]
        public DateTime DateModified { get; set; }

        [Description("Tag name.")]
        public string Name { get; set; }
        public ICollection<ArticleTagInfoModel> ArticleTags { get; set; }

        [Description("User Id.")]
        public int UserId { get; set; }
    }
}
