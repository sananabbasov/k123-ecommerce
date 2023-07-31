using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K123Ecommerce.Business.Abstract;
using K123Ecommerce.Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace K123Ecommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add")]
        public IActionResult AddCategory([FromBody]CategoryAddDTO categoryAdd)
        {
            var result = _categoryService.AddCategory(categoryAdd);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }


        [HttpGet("homecategories")]
        public IActionResult GetHomeCategories()
        {
            var cats =_categoryService.GetHomeCategories();
            if (cats.Success)
            {
                return Ok(cats);
            }
            return BadRequest(new {status = 404, message = cats.Message});
        }

        [HttpPost("addwith")]
        public IActionResult Adds()
        {
            var test =_categoryService.AddWith();
            return Ok(test);
        }

    }
}

