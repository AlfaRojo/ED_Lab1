﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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

        // GET: api/Soda
        [HttpGet]
        public ActionResult<List<Soda>> Get =>
            _serviSoda.Get();

        // POST: api/Soda

        [HttpPost]
        public ActionResult<Tree<Soda>> Post(Soda Drink)
        {
            _serviSoda.Post(Drink);
            return Ok();
        }
    }
}
