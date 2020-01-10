using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebApp.Core.Services.Contracts.Models
{
	public class UserInfoModel
	{
        [Description("User Id.")]
        public int Id { get; set; }

        [Description("User unique Id.")]
        public Guid UniqueId { get; set; }

        [Description("User creation date.")]
        public DateTime DateCreated { get; set; }

        [Description("User last modification date.")]
        public DateTime DateModified { get; set; }

        [Description("User first name.")]
        public string FirstName { get; set; }

        [Description("User last name.")]
        public string LastName { get; set; }

        [Description("User email.")]
        public string Email { get; set; }

        [Description("User list of articles.")]
        public ICollection<ArticleTagInfoModel> Articles { get; set; }

        [Description("User list of comments.")]
        public ICollection<CommentInfoModel> Comments { get; set; }
        public AccountInfoModel Account { get; set; }
    }
}
