﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;//Checar error 1

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        // GET: api/<TarjetaController>
        [HttpGet]
        public IEnumerable<string> Get() //Checar errror 1 
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TarjetaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TarjetaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id:int}")]
        public void Put(int id) 
        {
        }
        //public void Put(int id, [FromBody] string value) 
        //{
        //}

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
