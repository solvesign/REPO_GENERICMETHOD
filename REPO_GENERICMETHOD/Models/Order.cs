using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace REPO_GENERICMETHOD.Models
{
    public class Order
    {

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int OrderId { get; set; }

        public string Name { get; set; }


        public int PlayerId { get; set; }

       
        [ ForeignKey("PlayerID")]

       public Player Player { get; set; }

       



    }
}
