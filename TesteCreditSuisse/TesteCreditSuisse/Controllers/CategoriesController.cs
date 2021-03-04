using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteCreditSuisse.Interface;
using TesteCreditSuisse.Model;

namespace TesteCreditSuisse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoriesController(ICategory category)
        {
            _category = category;
        }

        [Route("AddCategory")]
        [HttpPost]
        public bool AddCategory(Category Newcategory)
        {
            _category.AddCategory(Newcategory);
            return true;
        }

        [Route("RemoveCategory")]
        [HttpDelete]
        public bool RemoveCategory(int ID)
        {
            _category.RemoveCategory(ID);
            return true;
        }

        [Route("ListCategories")]
        [HttpGet]
        public List<Category> ListCategories()
        {
            List<Category> categories = new List<Category>();
            categories = _category.ListCategory();
            return categories;
        }

        [Route("UpdateCategory")]
        [HttpPut]
        public bool UpdateCategory(Category Newcategory)
        {
            return _category.UpdateCategory(Newcategory);
        }
    }
}
