using System.ComponentModel.DataAnnotations;

namespace CRUDoperations.Models
{
    public class Employee
    {
        // Id primary key 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

     
        [Required(ErrorMessage = "Position is required")]
        [StringLength(50, ErrorMessage = "Position cannot be longer than 50 characters")]
        public string Position { get; set; }

        
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive value")]
        public decimal Salary { get; set; }
    }
}
