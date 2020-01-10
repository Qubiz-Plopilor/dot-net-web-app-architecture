using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Domain.Entities;

namespace WebApp.Core.Domain.Contracts.Repositories
{
	public interface IArticleRepository: IGenericRepository<Article>
	{
	}
}
