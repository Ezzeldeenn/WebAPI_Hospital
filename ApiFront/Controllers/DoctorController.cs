using ApiFront.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFront.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly Idoctorrepo _repo;
        public DoctorController(Idoctorrepo idoctorrepo)
        {
            _repo = idoctorrepo;
        }

        [HttpGet("{name}")]
        public IActionResult Displaydocbyname(string name) 
        {
            var doctor=_repo.Getdotorname(name);

            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(doctor);
            }
        }
    }
}
