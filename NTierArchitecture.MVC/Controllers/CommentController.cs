using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.Controllers
{
    public class CommentController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;

        public CommentController(IMapper mapper, ICommentService commentService)
        {
            _mapper = mapper;
            _commentService = commentService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            
            var result = _commentService.GetAllAsync(x => x.BlogId == id);
            return PartialView(result);
        }
        public PartialViewResult CommentAddByBlog()
        {
            return PartialView();
        }
    }
}
