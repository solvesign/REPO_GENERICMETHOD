using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.Repositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers.Services
{
    public class PlayerServices : IPlayerServices
    {

        private readonly IUnitofWork _unitofWork;

        public PlayerServices(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task<bool> AddPlayers(Player player)
        {
            if (player != null)
            {
                 _unitofWork._playerRepository.Add(player);

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

        public bool DeletePlayers(Player play)
        {
            

            if (play!= null)
            {
                  _unitofWork._playerRepository.Delete(play);

                _unitofWork.Save();

                return true;
            } 

            return false;


        }        
        

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {

            var res = await _unitofWork._playerRepository.GetAll();
           
            return res;
        }

        public async Task<Player> GetPlayerByID(int Id)
        {
            if(Id > 0)
            {
                var res1 = await _unitofWork._playerRepository.GetById(Id);

                if (res1 != null)
                {
                    return res1;
                }
                

            }
            return null; 

                  
            
            
        }

        public bool UpdatePlayer(Player player)
        {
            if (player != null) 
            {
             _unitofWork._playerRepository.Update(player);
                
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
