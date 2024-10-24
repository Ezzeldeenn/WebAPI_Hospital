using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFront.Models
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }

        public string PatientName { get; set; }
        public string PatientStatus { get; set; }

        public DateOnly  Appointment { get; set; }

        //[ForeignKey("Doctors")]
        //public int DoctorId {  get; set; }
        public List<Doctor_Pations> Doctor_Pations { get; set; }



       
    }
}
