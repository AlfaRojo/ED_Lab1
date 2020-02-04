using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Lab1.Models;
using Lab1.Services;

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
        // GET: api/Soda/5
        [HttpGet]


        public ActionResult<Tree<Soda>> Get =>
            _serviSoda.Get();

        [HttpGet("{id:lenght(24)}", Name = "GetSoda")]
        public ActionResult<Tree<Soda> Get(string id)
        {
            var soda = _serviSoda.Get(id);
            if (soda == null)
            {
                return NotFound();
            }
            return Ok();
        }

        // POST: api/Soda
        [HttpPost]
        public ActionResult<Tree<Soda> Post(Soda Drink)
        {
            _serviSoda.Post(Drink);
            return Ok();
        }
    }
}
