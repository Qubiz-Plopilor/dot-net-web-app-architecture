using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Core.Domain.Entities
{
	public class ArticleTag: BaseEntity
	{
		public int ArticleID { get; set; }
		public Article Article { get; set; }
		public int TagID { get; set; }
		public Tag Tag { get; set; }
	}
}
