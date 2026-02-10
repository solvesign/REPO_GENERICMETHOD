using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPO_GENERICMETHOD.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PlayerID {  get; set; }

        [Required]

        [StringLength(50)]

        public string Player_Name { get; set; }
        [Required]
        [StringLength(50)]
        public int Player_Age { get; set; }
        [Required]
        [StringLength(50)]
        public string Player_Lavel { get; set; }
       
    }
}
