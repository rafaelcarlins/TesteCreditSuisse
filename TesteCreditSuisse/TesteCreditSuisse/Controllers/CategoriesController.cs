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
        public bool AddCategory(double value, string category, string risk)
        {
            Category Newcategory = new Category();
            Newcategory.Value = value;
            Newcategory.ClientSector = category;
            Newcategory.Risk = risk;
            _category.AddCategory(Newcategory);
            return true;
        }

        [Route("RemoveCategory")]
        [HttpDelete]
        public void RemoveCategory(int ID)
        {
            _category.RemoveCategory(ID);
        }

        [Route("ListCategories")]
        [HttpGet]
        public List<Category> ListCategories()
        {
            List<Category> categories = new List<Category>();
            _category.ListCategory();
            return categories;
        }

        [Route("UpdateCategory")]
        [HttpPut]
        public void UpdateCategory()
        {
            Category category = new Category();
            _category.UpdateCategory(category);
        }
    }
}
