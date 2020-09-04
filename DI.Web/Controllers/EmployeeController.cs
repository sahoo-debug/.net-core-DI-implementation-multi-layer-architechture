using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Services.Contract;
//using DI.Contracts;
//using DI.Core;
using DI.Web.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        // GET: api/<EmployeeController>
        [Route("getemployees")]
        [HttpGet]
        public IEnumerable<string> Getemployees()
        {
            var str = _service.Display();
            return new string[] { str };
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
