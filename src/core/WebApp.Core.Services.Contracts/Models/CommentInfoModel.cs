using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebApp.Core.Services.Contracts.Models
{
	public class CommentInfoModel
	{
        [Description("Comment Id.")]
        public int Id { get; set; }

        [Description("Comment unique Id.")]
        public Guid UniqueId { get; set; }

        [Description("Comment creation date.")]
        public DateTime DateCreated { get; set; }

        [Description("Comment last modification date.")]
        public DateTime DateModified { get; set; }

        [Description("Comment content.")]
        public string Content { get; set; }
        public ArticleInfoModel Article { get; set; }
        public UserInfoModel User { get; set; }
    }
}
