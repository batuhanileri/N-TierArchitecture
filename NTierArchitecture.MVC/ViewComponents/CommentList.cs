using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.ViewComponents
{
    public class CommentList:ViewComponent
    {
        
        private readonly ICommentService _commentService;

        public CommentList( ICommentService commentService)
        {
         
            _commentService = commentService;

        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetAllAsync(x=>x.BlogId==id);
            return View(values);
        }
    }
}
