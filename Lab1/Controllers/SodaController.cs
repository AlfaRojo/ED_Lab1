using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using Lab1.Services;

namespace Lab1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SodaController : ControllerBase
    {
        private readonly ServiceSoda _serviSoda;
        public SodaController(ServiceSoda serviSoda)
        {
            _serviSoda = serviSoda;
        }
        // GET: api/Soda/5
        [HttpGet]
        public ActionResult<List<Tree>> Get() =>
            _serviSoda.Get();

        // POST: api/Soda
        [HttpPost]
        public ActionResult<> Post(Soda Drink)
        {
            _serviSoda.Post(Drink);
            return Ok();

        }
    }
}
