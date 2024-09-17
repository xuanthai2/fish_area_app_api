
using FishAreaApp.Interfaces;
using FishAreaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishAreaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaoController : Controller
    {
        private readonly IBao _bao;
        public BaoController(IBao bao) 
        {
            this._bao = bao;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Bao>))]
        public IActionResult GetBaos()
        {
            var bao = _bao.GetBaos();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(bao);
        }
    }
}
