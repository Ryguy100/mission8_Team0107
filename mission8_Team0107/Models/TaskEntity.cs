using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission8_Team0107.Models
{
    public class TaskEntity
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Task is a required field")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Due Date is a required field")]
        public DateTime DueDate { get; set; }
        
        [Required(ErrorMessage = "Quadrant is a required field")]
        public int? Quadrant { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public bool IsCompleted { get; set; }


    }
}
