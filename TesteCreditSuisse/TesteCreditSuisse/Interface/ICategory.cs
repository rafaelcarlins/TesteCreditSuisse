using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCreditSuisse.Model;

namespace TesteCreditSuisse.Interface
{
    public interface ICategory
    {
        bool AddCategory(Category category);
        void RemoveCategory(int ID);
        bool UpdateCategory(Category category);
        List<Category> ListCategory();
    }
}
