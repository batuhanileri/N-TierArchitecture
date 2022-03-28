using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Data.Concrete;
using NTierArchitecture.Entity.Concrete;
using NTierArchitecture.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly Context _context;
        public CategoryController(IMapper mapper, ICategoryService categoryService,Context context)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _context = context;
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IActionResult> GetAll()
        {
            var values = await _categoryService.GetAllAsync();
            return View(values);
        }

        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto categoryDto)
        {
            //await _context.Categories.AddAsync(_mapper.Map<Category>(categoryDto));
            //await _context.SaveChangesAsync();
            //await CommitAsync(); 
            await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
                       
           
            return RedirectToAction("GetAll");

        }
    }
}
