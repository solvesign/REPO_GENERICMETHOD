using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPO_GENERICMETHOD.Models
{
    public class Bignners
    {

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID {  get; set; }

        [Required]
        public string B_Name { get; set; }
        [Required]
        public int  B_Age { get; set; }

        [Required]
       public string B_Level {  get; set; }
    }
}
