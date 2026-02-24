using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.Models;
namespace REPO_GENERICMETHOD.Controllers.Services
{
    public class CategoryServices : ICategoryServices
    {

        private readonly IUnitofWork _unitofWork;

        public CategoryServices(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task<bool> Addcategory(Category category)
        {
            if (category != null)
            {
                await _unitofWork._categoryRepository.Add(category);

                var res = _unitofWork.Save();

                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            return false;

        }

        public bool Deletecategorys(Category category)
        {


            if (category != null)
            {
                _unitofWork._categoryRepository.Delete(category);

                _unitofWork.Save();

                return true;
            }

            return false;


        }


        public async Task<IEnumerable<Category>> GetAllcategory()
        {

            var res = await _unitofWork._categoryRepository.GetAll();

            return res;
        }

        public async Task<Category> GetcategoryByID(int Id)
        {
            if (Id > 0)
            {
                var res = await _unitofWork._categoryRepository.GetById(Id);

                return res;
            }
            return null;







        }

        public async Task<bool> Updatecategory(Category category)
        {

            if (category != null)
            {
                var res = await _unitofWork._categoryRepository.GetById(category.Id);

                if (res != null)
                {
                    res.Id = category.Id;
                    res.Name = category.Name;
                    res.Description = category.Description;

                    _unitofWork.Save();

                    return true;



                }
            }

            return false;
        }

    }
  }

