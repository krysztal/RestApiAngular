using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RAaA.DAL.Interfaces;
using RAaA.API.Services;
using RAaA.API.Interfaces;

namespace RAaA.API.Controllers
{
    [Route("api/[controller]")]
    public class PCBuildController : Controller
    {
        IPCBuilderService _pcBuildService;
        public PCBuildController(IPCBuilderService pcBuildService)
        {
            _pcBuildService = pcBuildService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //_pcBuildService.MakeBuild()
            var procs = _pcBuildService.GetBuilds();
            if (procs.Any())
                return new string[] { procs.First().Name, procs.First().TotalPrice.ToString() };
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
