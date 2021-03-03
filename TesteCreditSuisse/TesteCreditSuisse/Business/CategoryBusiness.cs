using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCreditSuisse.Interface;
using TesteCreditSuisse.Model;

namespace TesteCreditSuisse.Business
{
    public class CategoryBusiness : ICategory
    {
        public bool AddCategory(Category category)
        {
            
            return true;
        }

        public List<Category> ListCategory()
        {
            List<Category> Listcategories = new List<Category>();
            return Listcategories;
            
        }

        public void RemoveCategory(int ID)
        {
            throw new NotImplementedException();
        }

        public Category UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
