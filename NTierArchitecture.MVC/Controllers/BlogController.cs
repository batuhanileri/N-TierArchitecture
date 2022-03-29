using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBlogService _blogService;

        public BlogController(IMapper mapper, IBlogService blogService)
        {
            _mapper = mapper;
            _blogService = blogService;

        }

        public async Task<IActionResult> Index()
        {
            var values = await _blogService.GetListWithCategory();
            return View(values);
        }
        public async Task<IActionResult> BlogDetails(int id)
        {
            ViewBag.id = id;
            var values = await _blogService.GetByIdAsync(id);
            return View(values);
        }
    }
}
