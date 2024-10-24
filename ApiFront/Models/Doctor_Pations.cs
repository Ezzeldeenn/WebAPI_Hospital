using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFront.Models
{
    public class Doctor_Pations
    {

        [ForeignKey(nameof(Doctor))]
        public int Dcotorid { get; set; }
        public Doctors Doctor { get; set; }


        [ForeignKey(nameof(Patient))]
        public int Pationid { get; set; }
        public Patients Patient { get; set; }

        public string Description { get; set; }

    }
}
