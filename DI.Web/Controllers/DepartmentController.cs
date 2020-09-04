using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Services.Contract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public IDepartmentService _service;
        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }
        //GET: api/<EmployeeController>
        [Route("getdepartments")]
        [HttpGet]
        public IEnumerable<string> Getdepartments()
        {
            var str = _service.GetDepartment();
            return new string[] { str };
        }
        // GET: api/<Department>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Department>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Department>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Department>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Department>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
