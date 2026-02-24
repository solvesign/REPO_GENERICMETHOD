using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Update.Internal;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers.IService
{
    public interface ICategoryServices
    {
        Task <IEnumerable<Category>> GetAllcategory();
          bool Deletecategorys(Category category);
        Task <bool> Addcategory(Category category);

        Task  <Category> GetcategoryByID(int Id);

       Task <bool> Updatecategory(Category category);

    }
}
