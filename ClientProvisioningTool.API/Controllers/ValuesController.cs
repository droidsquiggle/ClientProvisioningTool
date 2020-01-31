using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClientProvisioningTool.API.Data;
using Microsoft.EntityFrameworkCore;

namespace ClientProvisioningTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        private readonly IValuesRepository _repo;

        public ValuesController(IValuesRepository repo)
        {
            this._repo = repo;
        }


        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _repo.GetValues();

            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _repo.GetValue(id);

            return Ok(value);
        }

        // POST api/values
        // to create a record
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        // to update a record
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        // to delte a record
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
