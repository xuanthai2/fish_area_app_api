using FishAreaApp.Interfaces;
using FishAreaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishAreaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoController : Controller
    {
        private readonly IKho kho;
        
        public KhoController(IKho kho)
        {
            this.kho = kho; 
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Kho>))]
        public IActionResult GetKhos()
        {
            var dsbao = kho.GetKhos();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(dsbao);
        }
    }
}
