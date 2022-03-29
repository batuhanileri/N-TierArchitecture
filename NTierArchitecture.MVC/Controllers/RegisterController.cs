using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Business.Abstract;
using NTierArchitecture.Entity.Concrete;
using NTierArchitecture.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWriterService _writerService;

        public RegisterController(IMapper mapper, IWriterService writerService)
        {
            _mapper = mapper;
            _writerService = writerService;

        }
        public IActionResult Index()
        {
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
            await _writerService.AddAsync(_mapper.Map<Writer>(registerDto));
            return RedirectToAction("Index", "Blog");
        }
    }
}
