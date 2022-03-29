using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentListByBlog(ICommentService commentService)
        {

            _commentService = commentService;

        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _commentService.Where(x => x.BlogId == id);
            return View(values);
        }
    }
}
