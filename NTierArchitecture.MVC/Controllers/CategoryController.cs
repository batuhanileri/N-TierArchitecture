using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
             
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
          
        }
        public async Task<IActionResult> GetAll()
        {
            var values = await _categoryService.GetAllAsync();
            return View(values);
        }
    }
}
