using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Moq;
using REPO_GENERICMETHOD.Controllers;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.text.Controllertest
{
   
    public  class Playerconrollertest
    {
        [Fact]
        public async Task getallemployees_returnwithView()
        {
            var mockservice = new Mock<IPlayerServices>();

            mockservice.Setup(x => x.GetAllPlayers()).ReturnsAsync(returnplayerlistfortest());

            var controllertest = new PlayerController(mockservice.Object);

            var result = await controllertest.GetallPlayers();

            Assert.NotNull(result);

            var result1 = Assert.IsType<ViewResult>(result);

            var viewresult = Assert.IsAssignableFrom<IEnumerable<Player>>(result1.ViewData.Model);

            Assert.Equal(2, viewresult.Count());

        }
        private List<Player> returnplayerlistfortest()

        {
            return new List<Player>
             {
                 new Player{PlayerID = 1, Player_Name ="Anoob", Player_Age =33, Player_Lavel ="B"},
                 new Player{PlayerID = 2, Player_Name ="Anu", Player_Age =45, Player_Lavel ="C"}

             };





        }
        [Fact]
        
        public  void DeleteStudent_ShouldReturnOk_WhenStudentIsDeleted()
        {
            Player play = new Player()
            {
                PlayerID = 1,
                Player_Name = "Anu",
                Player_Age = 33,
                Player_Lavel = "B"
                
            };

            // Arrange
            int id = 1;

            var mockService = new Mock<IPlayerServices>();
             mockService.Setup(x => x.GetPlayerByID(id)).ReturnsAsync(play);
           
            mockService.Setup(x => x.DeletePlayers(play));        
            
            var controller = new PlayerController(mockService.Object);

            // Act
            var result =  controller.DeletePlayer(id);

            // Assert
             
            var redirect = Assert.IsType<RedirectToActionResult>("GetallPlayers");
            
            Assert.Equal("GetallPlayers", redirect.ActionName);
            
            
            // Verify service calls
            mockService.Verify(x => x.GetPlayerByID(id), Times.Once); mockService.Verify(x => x.DeletePlayers(play), Times.Once);
        }






    }
}
