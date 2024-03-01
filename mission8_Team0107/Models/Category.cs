using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission8_Team0107.Models
{
    public class Category
    {
        [Key]
        public int? CategoryId { get; set; }

        public string? CategoryName { get; set; }

    }
}
