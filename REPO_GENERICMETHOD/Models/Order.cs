using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace REPO_GENERICMETHOD.Models
{
    public class Order
    {
        public int OrderId {  get; set; }

        public int ProductID { get; set; }

        [ForeignKey("ProductID")]

        public Product Product { get; set; }

        public int Qty { get; set; }

        public int PlayerId {  get; set; }

        [ForeignKey("PlayerId")]

        public Player Player { get; set; }








    }
}
