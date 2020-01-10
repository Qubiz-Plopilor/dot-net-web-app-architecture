using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Domain.Contracts.Exceptions;
using WebApp.Core.Services.Contracts;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services
{
	public class CommentService : ICommentService
	{
		public async Task<CommentInfoModel> GetCommentById(int id)
		{
			throw new EntityNotFoundException($"Comment with Id = {id} not found!");
		}
	}
}
