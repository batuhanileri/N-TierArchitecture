using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryList(ICategoryService categoryService)
        {

            _categoryService = categoryService;

        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _categoryService.GetAllAsync();
            return View(values);
        }
    }
}
