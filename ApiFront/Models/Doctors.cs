using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFront.Models
{
    public class Doctors
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        [StringLength(50)]
        public string Specialty { get; set; }

        public List<Doctor_Pations> Doctor_Pations { get; set; }


        [ForeignKey(nameof(Manangerid))]
        public int Manangerid {  get; set; }
        public Manager Manager { get; set; }

    }
}
