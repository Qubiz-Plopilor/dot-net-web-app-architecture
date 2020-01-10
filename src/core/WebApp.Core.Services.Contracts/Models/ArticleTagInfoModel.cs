using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebApp.Core.Services.Contracts.Models
{
	public class ArticleTagInfoModel
	{
        [Description("ArticleTag Id.")]
        public int Id { get; set; }

        [Description("ArticleTag unique Id.")]
        public Guid UniqueId { get; set; }

        [Description("ArticleTag creation date.")]
        public DateTime DateCreated { get; set; }

        [Description("ArticleTag last modification date.")]
        public DateTime DateModified { get; set; }

        public int ArticleID { get; set; }
        public ArticleInfoModel Article { get; set; }
        public int TagID { get; set; }
        public TagInfoModel Tag { get; set; }
    }
}
