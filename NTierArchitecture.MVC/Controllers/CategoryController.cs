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
       
        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            
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
        public async Task<IActionResult> Edit(int id)
        {

            var category = await _categoryService.GetByIdAsync(id);

            return View(_mapper.Map<CategoryDto>(category));
        }

        [HttpPost]
        public IActionResult Edit(CategoryDto categoryDto)
        {
           
              _categoryService.Update(_mapper.Map<Category>(categoryDto));

              return RedirectToAction("GetAll");

        }
       
        public async Task<IActionResult> Delete(int id)
        {
            
            var category = await _categoryService.GetByIdAsync(id);

             _categoryService.Remove(category);

            return RedirectToAction("GetAll");
        }
    }
}
