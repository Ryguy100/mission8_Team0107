using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission8_Team0107.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

    }
}
