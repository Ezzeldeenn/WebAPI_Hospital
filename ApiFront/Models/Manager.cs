using System.ComponentModel.DataAnnotations;

namespace ApiFront.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public double  Salary { get; set; }
        public List<Doctors> Doctors { get; set; } 
    }
}
