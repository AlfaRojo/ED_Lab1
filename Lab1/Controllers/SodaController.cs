using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using Lab1.Services;
using Lab1.Helpers;

namespace Lab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SodaController : ControllerBase
    {
        private readonly ServiceSoda _serviSoda;
        public SodaController(ServiceSoda serviSoda)
        {
            _serviSoda = serviSoda;
        }

        // GET: api/Soda
        [HttpGet]
        public ActionResult<List<Soda>> Get()
        {
            var listaReturn = _serviSoda.Get();
            return Ok(listaReturn);
        }

        // Post: api/Soda
        [HttpPost]
        public Soda Post ([FromBody] Soda soda)
        {
           // Singleton.Instance.thisTree.Insert();
            return soda;
        }

        // POST: api/Soda
        [HttpPost]
        public ActionResult<List<Soda>> Post(List<Soda> Drink)
        {
            _serviSoda.Post(Drink);
            return Ok();
        }
    }
}
