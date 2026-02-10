using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.Models;
namespace REPO_GENERICMETHOD.Controllers.Services
{
    public class BignnersServices : IBignnersServices
    {

        private readonly IUnitofWork _unitofWork;

        public BignnersServices(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task<bool> AddBignners(Bignners Bignners)
        {
            if (Bignners != null)
            {
                 _unitofWork._bignnersRepository.Add(Bignners);

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

        public bool DeleteBignners(Bignners Bignners)
        {
            

            if (Bignners!= null)
            {
                  _unitofWork._bignnersRepository.Delete(Bignners);

                _unitofWork.Save();

                return true;
            } 

            return false;


        }        
        

        public async Task<IEnumerable<Bignners>> GetAllBignners()
        {

            var res = await _unitofWork._bignnersRepository.GetAll();
           
            return res;
        }

        public async Task<Bignners> GetBignnersByID(int Id)
        {
            if(Id > 0)
            {
                var res1 = await _unitofWork._bignnersRepository.GetById(Id);

                if (res1 != null)
                {
                    return res1;
                }
                

            }
            return null; 

                  
            
            
        }

        public bool UpdateBignners(Bignners Bignners)
        {
            if (Bignners != null) 
            {
             _unitofWork._bignnersRepository.Update(Bignners);
                
                var res = _unitofWork.Save();

                if (res > 0)
                {
                    return true;
                }
                return false;
            }
            return false ;
           

           
        }
    }
}
