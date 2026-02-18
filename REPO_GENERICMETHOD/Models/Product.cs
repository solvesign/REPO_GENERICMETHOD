using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPO_GENERICMETHOD.Models
{
    public class Product
    {
        [Key]
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId {  get; set; }

        public string Name { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public double TotalAmount => Qty * Price;


        public string Description { get; set; }


    }
}
