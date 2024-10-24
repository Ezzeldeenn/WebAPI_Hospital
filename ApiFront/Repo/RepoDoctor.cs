using ApiFront.Interfaces;
using ApiFront.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ApiFront.Repo
{
    public class RepoDoctor : Idoctorrepo
    {
        private readonly AppDbContext _context;
        public RepoDoctor(AppDbContext Context)
        {
            _context = Context;
        }
        public Doctors_DTO Getdotorname(string name)
        {
          var doctor=_context.Doctors.FirstOrDefault(x => x.Name == name);

            Doctors_DTO doctors_DTO = new Doctors_DTO
            {
                name = doctor.Name,
                Specialty = doctor.Specialty,
                Managername=doctor.Manager.Name
            };
            return doctors_DTO;
        }
    }
}
