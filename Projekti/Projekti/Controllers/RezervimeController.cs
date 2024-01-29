using Microsoft.AspNetCore.Mvc;
using Projekti.Data.Services;
using Projekti.Data.ViewModels;

namespace Projekti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervimeController : ControllerBase
    {
        private readonly RezervimeService _rezervimeService;

        public RezervimeController(RezervimeService rezervimeService)
        {
            _rezervimeService = rezervimeService;
        }

        [HttpGet]
        public IActionResult GetAllRezervime()
        {
            var allRezervime = _rezervimeService.GetAllRezervime();
            return Ok(allRezervime);
        }

        [HttpGet("{ID}")]
        public IActionResult GetUniversityById(int ID)
        {
            var rezervim = _rezervimeService.GetRezervimByid(ID);
            if (rezervim == null)
            {
                return NotFound($"Rezervim with id = {ID} not found");
            }
            return Ok(rezervim);
        }

        [HttpPost]
        public IActionResult AddRezervim([FromBody] RezervimeVM rezervim)
        {
            _rezervimeService.AddRezervim(rezervim);
            return Ok();
        }

        [HttpPut("{ID}")]
        public IActionResult UpdateRezervimById(int ID, [FromBody] RezervimeVM rez1)
        {
            var updatedrez = _rezervimeService.UpdateRezervimById(ID, rez1);
            if (updatedrez == null)
            {
                return NotFound($"Rezrvim with id = {ID} not found");
            }
            return Ok(updatedrez);
        }

        [HttpDelete("delete-rezervim-by-id/{ID}")]
        public IActionResult DeleteRezervimById(int ID)
        {
            _rezervimeService.DeleteRezervimById(ID);
            return Ok();
        }
    }
}
